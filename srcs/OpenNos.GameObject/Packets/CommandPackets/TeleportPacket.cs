﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$Teleport", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class TeleportPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string Data { get; set; }

        [PacketIndex(1)]
        public short X { get; set; }

        [PacketIndex(2)]
        public short Y { get; set; }

        public static string ReturnHelp() => "$Teleport CHARACTERNAME/MAP X(?) Y(?)";

        #endregion
    }
}