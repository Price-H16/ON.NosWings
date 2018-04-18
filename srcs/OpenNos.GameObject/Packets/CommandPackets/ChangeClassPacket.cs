﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$ChangeClass", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class ChangeClassPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public ClassType ClassType { get; set; }

        public static string ReturnHelp() => "$ChangeClass CLASS";

        #endregion
    }
}