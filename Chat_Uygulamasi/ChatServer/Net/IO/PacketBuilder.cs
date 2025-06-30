﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Net.IO
{
    class PacketBuilder
    {
        MemoryStream _ms;

        public PacketBuilder()
        {
            _ms = new MemoryStream();
        }

        public void WriteOpCode(byte opcode)
        {
            _ms.WriteByte(opcode);
        }

        public void WriteMessage(string msg)
        {
            var msgBytes = Encoding.ASCII.GetBytes(msg);
            var msgLength = msgBytes.Length;

            _ms.Write(BitConverter.GetBytes(msgLength), 0, 4);
            _ms.Write(msgBytes, 0, msgLength);

        }

        public byte[] GetPacketBytes()
        {
            return _ms.ToArray();
        }
    }
}
