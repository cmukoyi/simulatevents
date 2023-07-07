using ProtoBuf;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace Scope.FiveC.Protocol.UnitControlRequest
{
	/// <summary>
	/// An XML serializable class representing a request to control an unit.
	/// </summary>
	[ProtoContract]
	[Serializable]
	public partial class UnitControlRequest
	{
		#region Public Members

		/// <summary>
		/// Request to the MHub to set an output port on or off using a specific behaviour.
		/// </summary>
		[ProtoMember(1)]
		public UnitControlRequestOutput[] Output
		{
			get { return _Output; }
			set { _Output = value; }
		}

		/// <summary>
		/// Request to the MHub to disable the vehicle.
		/// </summary>
		[ProtoMember(2)]
		public UnitControlRequestDisable[] Disable
		{
			get { return _Disable; }
			set { _Disable = value; }
		}

		/// <summary>
		/// Request that the MHub sends either an updated position.
		/// </summary>
		[ProtoMember(3)]
		public UnitControlRequestPoll[] Poll
		{
			get { return _Poll; }
			set { _Poll = value; }
		}

		/// <summary>
		/// Request the unit to send CAN bus related data.
		/// </summary>
		/// <remarks>Applicable to the MHub918 only.</remarks>
		[ProtoMember(4)]
		public UnitControlRequestCanDataPoll[] CanDataPoll
		{
			get { return _CanDataPoll; }
			set { _CanDataPoll = value; }
		}

		/// <summary>
		/// Requests that the specified profile become active on the unit.
		/// </summary>
		/// <remarks>Applicable to the MHub CS905 only.</remarks>
		[ProtoMember(5)]
		public UnitControlRequestExecuteProfile[] ExecuteProfile
		{
			get { return _ExecuteProfile; }
			set { _ExecuteProfile = value; }
		}

		/// <summary>
		/// Requests that the specified unit enters Active Recovery mode.
		/// </summary>
		/// <remarks>Applicable to the MHub 701 only.</remarks>
		[ProtoMember(6)]
		public UnitControlRequestActiveRecovery[] ActiveRecovery
		{
			get { return _ActiveRecovery; }
			set { _ActiveRecovery = value; }
		}

		/// <summary>
		/// The Unit ID of the MHub to control.
		/// </summary>
		[ProtoMember(7)]
		public string UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		#endregion

		#region Private Members

		private UnitControlRequestActiveRecovery[] _ActiveRecovery;
		private UnitControlRequestExecuteProfile[] _ExecuteProfile;
		private UnitControlRequestCanDataPoll[] _CanDataPoll;
		private UnitControlRequestDisable[] _Disable;
		private UnitControlRequestOutput[] _Output;
		private UnitControlRequestPoll[] _Poll;
		private string _UnitId;

		#endregion


		/// <summary>
		/// Deserialize from protocol buffers format
		/// </summary>
		/// <param name="pbuf"></param>
		/// <returns></returns>
		public static UnitControlRequest DeserializeProtocolBuffers(byte[] pbuf)
		{
			using (MemoryStream ms = new MemoryStream(pbuf))
			{
				return Serializer.Deserialize<UnitControlRequest>(ms);
			}
		}

		/// <summary>
		/// Get proto for UnitControlRequest
		/// </summary>
		/// <returns></returns>
		public static string GetGetProto()
		{
			return Serializer.GetProto<UnitControlRequest>();
		}
	}
}