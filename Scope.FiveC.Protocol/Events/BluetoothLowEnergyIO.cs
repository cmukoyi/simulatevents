

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// BluetoothLowEnergyIO event
	/// </summary>
	public partial class BluetoothLowEnergyIO : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BluetoothLowEnergyIO; }
		}
	}
}
