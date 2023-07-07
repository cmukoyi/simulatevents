using System;
using System.Globalization;
using System.IO;
using Scope.FiveC.Protocol.Events;

namespace Scope.FiveC.Protocol
{
	public class FiveCData
	{
		public const byte ProtocolId = 0x5C;

		private byte[] _serializedData;

		public uint TemplateId { get; private set; }
		public ushort DataLength { get; private set; }
		public byte[] ProtocolBufferData { get; private set; }


		/// <summary>
		/// Constructor for FiveCData
		/// </summary>
		/// <param name="templateId"></param>
		/// <param name="protocolBufferData"></param>
		public FiveCData(uint templateId, byte[] protocolBufferData)
		{
			if (templateId == (uint)ProtocolBufferTemplate.UnknownEvent) throw new ArgumentOutOfRangeException("templateId");
			if (templateId > 0x00ffffff) throw new ArgumentOutOfRangeException("templateId");
			if (protocolBufferData == null) throw new ArgumentNullException("protocolBufferData");
			if (protocolBufferData.Length == 0) throw new ArgumentException("protocolBufferData");

			TemplateId = templateId;
			DataLength = (ushort)protocolBufferData.Length;
			ProtocolBufferData = protocolBufferData;
		}


		/// <summary>
		/// Serialized Data
		/// </summary>
		public byte[] SerializedData
		{
			get
			{
				SerializeData();
				return _serializedData;
			}
		}


		/// <summary>
		/// Deserialize 5C data into the FiveCData class
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static FiveCData Deserialize(byte[] data)
		{
			using (var ms = new MemoryStream(data))
			{
				using (var br = new BinaryReader(ms)) // little endian stream
				{
					var protocolId = br.ReadByte();
					if (protocolId != ProtocolId)
						throw new ApplicationException(string.Format(CultureInfo.InvariantCulture, "Incorrect protocolId, it should be 0x{0:X2} but was: 0x{1:X2}", ProtocolId, protocolId));

					int templateId = br.ReadUInt16();
					// check whether templateId is 2 or 3 bytes long
					if ((templateId & 0x8000) != 0)
					{
						byte templateId2 = br.ReadByte();
						templateId &= ~0x8000; // clear that bit
						templateId |= (templateId2 << 15); // shift one bit less than usual
					}

					ushort dataLength = br.ReadUInt16();
					byte[] protocolBufferData = br.ReadBytes(dataLength);

					return new FiveCData((uint)templateId, protocolBufferData);
				}
			}
		}


		/// <summary>
		/// TemplateId can be 2-3 bytes long. Bit15 indicates if 1 more byte will follow
		/// </summary>
		/// <returns></returns>
		private int GetTemplateIdLength()
		{
			return (TemplateId > 0x0000ffff) ? 3 : 2;
		}


		/// <summary>
		/// Serialize templateId to 2 or 3 bytes of data
		/// </summary>
		/// <returns></returns>
		private byte[] SerializeTemplateId()
		{
			var result = new byte[GetTemplateIdLength()];
			result[0] = (byte)(TemplateId & 0xff);

			if (result.Length == 2)
			{
				result[1] = (byte)((TemplateId >> 8) & 0xff);
			}
			else
			{
				result[1] = (byte)((TemplateId >> 8) & 0xff);
				result[1] |= 0x80; // set indicator that 1 more byte will follow
				result[2] = (byte)((TemplateId >> 15) & 0xff); // shift 16-1 bits only
			}

			return result;
		}


		private void SerializeData()
		{
			// do it only once
			if (_serializedData != null)
				return;

			using (var ms = new MemoryStream())
			{
				using (var bw = new BinaryWriter(ms))
				{
					bw.Write(ProtocolId);
					bw.Write(SerializeTemplateId());
					bw.Write(DataLength);
					bw.Write(ProtocolBufferData);

					_serializedData = ms.ToArray();
				}
			}
		}

		public static FiveCData FromProtocolBufferBase(ProtocolBufferEventBase eventBase)
		{
			if (eventBase == null)
				throw new ArgumentNullException("eventBase");

			byte[] protocolBufferData;
			using (var ms = new MemoryStream())
			{
				ProtoBuf.Serializer.NonGeneric.Serialize(ms, eventBase);
				protocolBufferData = ms.ToArray();
			}

			var fiveCData = new FiveCData((uint) eventBase.TemplateId, protocolBufferData);
			return fiveCData;
		}
	}
}
