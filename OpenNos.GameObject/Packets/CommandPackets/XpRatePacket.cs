﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("$XpRate", PassNonParseablePacket = true)]
    public class XpRatePacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public int Value { get; set; }

        #endregion
    }
}