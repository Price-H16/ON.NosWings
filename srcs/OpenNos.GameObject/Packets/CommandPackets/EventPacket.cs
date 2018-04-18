﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Event", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class EventPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public EventType EventType { get; set; }

        [PacketIndex(1)]
        public int? UseTimer { get; set; }

        public static string ReturnHelp() => "$Event EVENT USETIMER";

        #endregion
    }
}