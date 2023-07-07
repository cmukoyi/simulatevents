

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// BluetoothLowEnergyDriverAbsent event
	/// </summary>
	public partial class BluetoothLowEnergyDriverAbsent : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BluetoothLowEnergyDriverAbsent; }
		}
	}
}
