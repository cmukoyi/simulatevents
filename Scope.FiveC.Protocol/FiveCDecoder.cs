using System;
using System.Collections.Generic;
using System.IO;
using Scope.FiveC.Protocol.Events;

namespace Scope.FiveC.Protocol
{
	public class FiveCDecoder
	{
		private static readonly Dictionary<uint, Type> UnitTemplateIdType = new Dictionary<uint, Type>();


		/// <summary>
		/// Get type from templateId. Cache data to speed up the process.
		/// </summary>
		/// <param name="templateId"></param>
		/// <returns></returns>
		public static Type GetProtocolBufferDataType(uint templateId)
		{
			if (UnitTemplateIdType.ContainsKey(templateId))
				return UnitTemplateIdType[templateId];

			lock (UnitTemplateIdType)
			{
				if (UnitTemplateIdType.ContainsKey(templateId))
					return UnitTemplateIdType[templateId];

				string templateName = ((ProtocolBufferTemplate) templateId).ToString();
				var eventBaseType = typeof (ProtocolBufferEventBase);
				string className = eventBaseType.Namespace + "." + templateName;
				Type type = eventBaseType.Assembly.GetType(className, true);

				UnitTemplateIdType.Add(templateId, type);
				return type;
			}
		}


		/// <summary>
		/// Decode 5C data
		/// </summary>
		/// <param name="unitId"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static ProtocolBufferEventBase Decode(string unitId, byte[] data)
		{
			if (data == null) throw new ArgumentNullException("data");

			return Decode(FiveCData.Deserialize(data));
		}


		/// <summary>
		/// Decode 5C data
		/// </summary>
		/// <param name="fiveCData"></param>
		/// <returns></returns>
		public static ProtocolBufferEventBase Decode(FiveCData fiveCData)
		{
			if (fiveCData == null) throw new ArgumentNullException("fiveCData");

			using (var ms = new MemoryStream(fiveCData.ProtocolBufferData))
			{
				var type = GetProtocolBufferDataType(fiveCData.TemplateId);
				return (ProtocolBufferEventBase)ProtoBuf.Serializer.NonGeneric.Deserialize(type, ms);
			}
		}


		/// <summary>
		/// Decode Protocol buffer data
		/// </summary>
		/// <param name="templateId">The proto template identifier.</param>
		/// <param name="protocolBufferRawData">The protocol buffer raw data.</param>
		/// <returns></returns>
		public static ProtocolBufferEventBase Decode(uint templateId, byte[] protocolBufferRawData)
		{
			if (protocolBufferRawData == null) throw new ArgumentNullException("protocolBufferRawData");

			using (var ms = new MemoryStream(protocolBufferRawData))
			{
				var type = GetProtocolBufferDataType(templateId);
				return (ProtocolBufferEventBase) ProtoBuf.Serializer.NonGeneric.Deserialize(type, ms);
			}
		}
	}
}
