// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getHistory.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesMessages"/>
	/// </summary>
	public partial class TLMessagesGetHistory : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 OffsetId { get; set; }
		public Int32 OffsetDate { get; set; }
		public Int32 AddOffset { get; set; }
		public Int32 Limit { get; set; }
		public Int32 MaxId { get; set; }
		public Int32 MinId { get; set; }
		public Int32 Hash { get; set; }

		public TLMessagesGetHistory() { }
		public TLMessagesGetHistory(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetHistory; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			OffsetId = from.ReadInt32();
			OffsetDate = from.ReadInt32();
			AddOffset = from.ReadInt32();
			Limit = from.ReadInt32();
			MaxId = from.ReadInt32();
			MinId = from.ReadInt32();
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteInt32(OffsetId);
			to.WriteInt32(OffsetDate);
			to.WriteInt32(AddOffset);
			to.WriteInt32(Limit);
			to.WriteInt32(MaxId);
			to.WriteInt32(MinId);
			to.WriteInt32(Hash);
		}
	}
}