﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libopenpvp.net
{
    public class RTMPPacketReader
    {
        public RTMPPacketReader()
        {
            throw new NotImplementedException();
        }

        public RTMPPacketReader(System.IO.Stream input)
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        internal TypedObject GetPacket(int packet)
        {
            throw new NotImplementedException();
        }

        public bool running { get; set; }

        internal TypedObject PeekPacket(int id)
        {
            throw new NotImplementedException();
        }
    }
}
