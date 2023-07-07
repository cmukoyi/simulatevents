using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Scope.FiveC.Protocol;

namespace EventSerializationTestApp
{
	public class TemplateInfo
	{
		public uint Id { get; set; }
		public string Description { get; set; }


		public static IList<TemplateInfo> FromProtocolBufferTemplate()
		{
			Type enumType = typeof(ProtocolBufferTemplate);
			List<uint> values = ((uint[])Enum.GetValues(enumType)).ToList();
			values.Sort();

			return values
				.Select(v => new TemplateInfo
				{
					Id = v,
					Description = string.Format(CultureInfo.InvariantCulture, "{0} - {1}", v, Enum.GetName(enumType, v))
				})
				.ToList();
		}
	}
}
