﻿using System;

namespace MonkeyWorks.SMB.SMB2
{
    sealed class SMB2NegotiateProtocolRequest
    {
        private readonly Byte[] StructureSize = { 0x24, 0x00 };
        private readonly Byte[] DialectCount = { 0x02, 0x00 };
        private readonly Byte[] SecurityMode = { 0x01, 0x00 };
        private readonly Byte[] Reserved = { 0x00, 0x00 };
        private readonly Byte[] Capabilities = { 0x40, 0x00, 0x00, 0x00 };
        private readonly Byte[] ClientGUID = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        private readonly Byte[] NegotiateContextOffset = { 0x00, 0x00, 0x00, 0x00 };
        private readonly Byte[] NegotiateContextCount = { 0x00, 0x00 };
        private readonly Byte[] Reserved2 = { 0x00, 0x00 };
        private readonly Byte[] Dialect = { 0x02, 0x02 };
        private readonly Byte[] Dialect2 = { 0x10, 0x02 };

        internal Byte[] GetProtocols()
        {
            Byte[] protocols = Combine.combine(StructureSize, DialectCount);
            protocols = Combine.combine(protocols, SecurityMode);
            protocols = Combine.combine(protocols, Reserved);
            protocols = Combine.combine(protocols, Capabilities);
            protocols = Combine.combine(protocols, ClientGUID);
            protocols = Combine.combine(protocols, NegotiateContextOffset);
            protocols = Combine.combine(protocols, NegotiateContextCount);
            protocols = Combine.combine(protocols, Reserved2);
            protocols = Combine.combine(protocols, Dialect);
            protocols = Combine.combine(protocols, Dialect2);
            return protocols;
        }
    }
}