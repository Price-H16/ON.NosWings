﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using NosSharp.Enums;
using OpenNos.Core.Serializing;

namespace OpenNos.GameObject.Packets.CommandPackets
{
    [PacketHeader("$RemoveMob", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class RemoveMobPacket : PacketDefinition
    {
        public static string ReturnHelp() => "$RemoveMob";
    }
}