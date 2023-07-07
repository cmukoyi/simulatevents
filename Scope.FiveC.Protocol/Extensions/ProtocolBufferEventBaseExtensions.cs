using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Scope.FiveC.Protocol.Events;

namespace Scope.FiveC.Protocol.Extensions
{
	public static class ProtocolBufferEventBaseExtensions
	{
		private const string Specified = "Specified";

		private static readonly IList<string> IgnoreProperties = new[] {"Header", "Template"};


		/// <summary>
		/// Return public property names and their string values
		/// </summary>
		/// <param name="ev"></param>
		/// <returns></returns>
		public static IList<KeyValuePair<string, string>> ToPropertyNameAndStringValueList(this ProtocolBufferEventBase ev)
		{
			var list = new List<KeyValuePair<string, string>>();

			IDictionary<string, PropertyInfo> propertyInfoDict = ev.GetType()
				.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
				.OrderBy(v => v.Name)
				.ToDictionary(v => v.Name);

			foreach (PropertyInfo propertyInfo in propertyInfoDict.Values)
			{
				string name = propertyInfo.Name;

				// ignore some predefined properties
				if (IgnoreProperties.Contains(name))
					continue;

				// do not show values for properties ending with "Specified"
				if (name.EndsWith(Specified) && (name != Specified))
					continue;

				// ignore properties which are not specified
				string specifiedName = name + Specified;
				if (propertyInfoDict.ContainsKey(specifiedName) && !(bool)propertyInfoDict[specifiedName].GetValue(ev))
					continue;

				// add property only if the Specified property does not exist or it's value is true
				object value;

				try
				{
					// if getting property fails, it will at least show the valid properties
					value = propertyInfo.GetValue(ev);
				}
				catch
				{
					value = "INVALID VALUE";
				}
				
				list.Add(new KeyValuePair<string, string>(name, (value != null) ? value.ToString() : null));
			}

			return list;
		}
	}
}
