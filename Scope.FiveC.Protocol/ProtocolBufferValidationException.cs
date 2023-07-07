using System;
using System.Globalization;

namespace Scope.FiveC.Protocol
{
	public class ProtocolBufferValidationException : ApplicationException
	{
		private readonly object _value = null;

		public string FieldName { get; set; }


		public ProtocolBufferValidationException() : base("Validation failed")
		{
		}


		public ProtocolBufferValidationException(string fieldName, string message) : base(message)
		{
			FieldName = fieldName;
		}


		public ProtocolBufferValidationException(string fieldName, string message, object value)
			: base(message)
		{
			FieldName = fieldName;
			_value = value;
		}


		public ProtocolBufferValidationException(string fieldName, string message, Exception innerException) : base(message, innerException)
		{
			FieldName = fieldName;
		}


		public override string Message
		{
			get
			{
				if (string.IsNullOrEmpty(FieldName))
					return base.Message;

				if (_value == null)
					return string.Format(CultureInfo.InvariantCulture, "{0}: {1}", FieldName, base.Message);
				
				return string.Format(CultureInfo.InvariantCulture, "{0}: {1}, Value: {2}", FieldName, base.Message, _value);
			}
		}
	}
}
