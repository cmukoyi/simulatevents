using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Common;
using EventSerializationTestApp.Extensions;
using Scope.FiveC.Protocol;
using Scope.FiveC.Protocol.Events;

namespace EventSerializationTestApp
{
	public partial class MainForm : Form
	{
		private const string EventClassNamespace = "Scope.FiveC.Protocol.Events";

		private string _hexData = "";
		private readonly List<TemplateInfo> _templates = new List<TemplateInfo> ();


		public MainForm()
		{
			InitializeComponent();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				// show application version in the title
				Text += string.Format(CultureInfo.InvariantCulture, " [Version: {0}]", Utils.GetApplicationFileVersion());

				FillTemplates(comboBoxTemplates);
				// Uncomment next procedure call to get sample event data in base64 and hex encoding
				// Testing.ShowSerializedDataInTextbox(textBoxResults);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void textBoxInputData_TextChanged(object sender, EventArgs e)
		{
			try
			{
				Decode();
			}
			catch (Exception ex)
			{
				textBoxResults.Text = string.Format(CultureInfo.InvariantCulture, "{0}\r\nERROR: {1}", _hexData, ex);
			}
		}


		private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Decode();
			}
			catch (Exception ex)
			{
				textBoxResults.Text = string.Format(CultureInfo.InvariantCulture, "{0}\r\nERROR: {1}", _hexData, ex);
			}
		}


		/// <summary>
		/// Decode and show event
		/// </summary>
		private void Decode()
		{
			string stringData = textBoxInputData.Text;
			if (string.IsNullOrWhiteSpace(stringData))
			{
				textBoxResults.Text = "";
				return;
			}

			if ((comboBoxTemplates.SelectedValue == null) || ((uint)comboBoxTemplates.SelectedValue == 0))
			{
				textBoxResults.Text = "Please select a template id";
				return;
			}
			uint templateId = (uint)comboBoxTemplates.SelectedValue;

			byte[] data = GetData(stringData);
			if (data == null)
				throw new ApplicationException("Could not convert text data to binary");

			_hexData = Utils.AsHexString(data);

			ProtocolBufferEventBase result = Deserialize(data, templateId);
			ShowDecodedEvent(result, _hexData);
		}


		/// <summary>
		/// Show decoded event in result text box
		/// </summary>
		/// <param name="pbEvent"></param>
		/// <param name="hexData"></param>
		private void ShowDecodedEvent(ProtocolBufferEventBase pbEvent, string hexData)
		{
			var sb = new StringBuilder();
			sb.AppendFormat(CultureInfo.InvariantCulture, "HEX DATA: {0}\r\n\r\n", hexData);
			sb.AppendFormat(CultureInfo.InvariantCulture, "{0}\r\n", pbEvent);

			IList<KeyValuePair<string, string>> properties = pbEvent.ToPropertyNameAndStringValueList();
			int maxPropertyNameLength = properties.Max(v => v.Key.Length);

			EventHeader header = pbEvent.GetEventHeader();
			if (header != null)
			{
				sb.Append("\r\nHeader:\r\n");
				IList<KeyValuePair<string, string>> headerProperties = header.ToPropertyNameAndStringValueList();
				int maxHeaderPropertyNameLength = headerProperties.Max(v => v.Key.Length);
				maxPropertyNameLength = Math.Max(maxPropertyNameLength, maxHeaderPropertyNameLength);

				string headerPropertyFormat = string.Format(CultureInfo.InvariantCulture, "{{0,{0}}}: {{1}}\r\n", maxPropertyNameLength);
				foreach (KeyValuePair<string, string> propertyKeyValue in headerProperties)
					sb.AppendFormat(CultureInfo.InvariantCulture, headerPropertyFormat, propertyKeyValue.Key, propertyKeyValue.Value);
			}

			sb.Append("\r\nOther Properties:\r\n");
			string format = string.Format(CultureInfo.InvariantCulture, "{{0,{0}}}: {{1}}\r\n", maxPropertyNameLength);
			foreach (KeyValuePair<string, string> propertyKeyValue in properties)
				sb.AppendFormat(CultureInfo.InvariantCulture, format, propertyKeyValue.Key, propertyKeyValue.Value);
			
			textBoxResults.Text = sb.ToString();
		}


		/// <summary>
		/// Combo box with all available templates
		/// </summary>
		/// <param name="templateComboBox"></param>
		private void FillTemplates(ComboBox templateComboBox)
		{
			_templates.Clear();
			_templates.AddRange(TemplateInfo.FromProtocolBufferTemplate());

			templateComboBox.DataSource = _templates;
			templateComboBox.DisplayMember = "Description";
			templateComboBox.ValueMember = "Id";
		}


		/// <summary>
		/// Get binary data from base64 encoded string
		/// </summary>
		/// <param name="stringData"></param>
		/// <returns></returns>
		private byte[] GetData(string stringData)
		{
			byte[] data = null;

			try
			{
				data = Convert.FromBase64String(stringData);
			}
			catch
			{
			}

			return data;
		}


		/// <summary>
		/// Deserialize protcol buffer data to an event class
		/// </summary>
		/// <param name="data"></param>
		/// <param name="templateId"></param>
		/// <returns></returns>
		private ProtocolBufferEventBase Deserialize(byte[] data, uint templateId)
		{
			using (var ms = new MemoryStream(data))
			{
				Type type = GetEventClassType(templateId);
				return (ProtocolBufferEventBase)ProtoBuf.Serializer.NonGeneric.Deserialize(type, ms);
			}
		}


		/// <summary>
		/// Get event class type from template id
		/// </summary>
		/// <param name="templateId"></param>
		/// <returns></returns>
		private Type GetEventClassType(uint templateId)
		{
			Type protocolBufferTemplateType = typeof(ProtocolBufferTemplate);
			Assembly a = Assembly.GetAssembly(protocolBufferTemplateType);
			string typeName = Enum.GetName(protocolBufferTemplateType, templateId);
			return a.GetType(EventClassNamespace + "." + typeName, true);
		}
	}
}
