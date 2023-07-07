

namespace Scope.FiveC.Protocol.Events
{
	/// <summary>
	/// BluetoothLowEnergyTracking event
	/// </summary>
	public partial class BluetoothLowEnergyTracking : ProtocolBufferEventBase
	{
		public override ProtocolBufferTemplate Template
		{
			get { return ProtocolBufferTemplate.BluetoothLowEnergyTracking; }
		}
	}
}
