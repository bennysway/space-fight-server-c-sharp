using System;
using System.Collections.Generic;
using System.Text;

namespace Bindings
{
    class PacketBuffer : IDisposable
    {
        List<byte> Buff;
        byte[] readBuff;
        int readPos;
        bool buffUpdate;

        public PacketBuffer()
        {
            Buff = new List<byte>();
            readPos = 0;
        }
        public int GetReadPos()
        {
            return readPos;
        }
        public byte[] ToArray()
        {
            return Buff.ToArray();
        }
        public int Count()
        {
            return Buff.Count;
        }
        public int Length()
        {
            return Count() - readPos;
        }
        public void Clear()
        {
            Buff.Clear();
            readPos = 0;
        }
        //Writing data
        public void AddInteger(int _int)
        {
            Buff.AddRange(BitConverter.GetBytes(_int));
            buffUpdate = true;
        }
        public void AddFloat(float _float)
        {
            Buff.AddRange(BitConverter.GetBytes(_float));
            buffUpdate = true;
        }
        public void AddString(string _string)
        {
            Buff.AddRange(BitConverter.GetBytes(_string.Length));
            Buff.AddRange(Encoding.ASCII.GetBytes(_string));
            buffUpdate = true;
        }
        public void AddByte(byte _byte)
        {
            Buff.Add(_byte);
            buffUpdate = true;
        }
        public void AddBytes(byte[] _bytes)
        {
            Buff.AddRange(_bytes);
            buffUpdate = true;
        }
        public void AddShort(short _short)
        {
            Buff.AddRange(BitConverter.GetBytes(_short));
            buffUpdate = true;
        }
        //Read data
        public int GetInt(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                int result = BitConverter.ToInt32(readBuff, readPos);
                if (Peak && Buff.Count > readPos)
                    readPos += 4;
                return result;
            }
            else
            {
                throw new Exception("Packet has passed its limit.");
            }
        }
        public float GetFloat(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                float result = BitConverter.ToSingle(readBuff, readPos);
                if (Peak && Buff.Count > readPos)
                    readPos += 4;
                return result;
            }
            else
            {
                throw new Exception("Packet has passed its limit.");
            }
        }
        public string GetString(bool Peak = true)
        {
            int length = GetInt(true);
            if (buffUpdate)
            {
                readBuff = Buff.ToArray();
                buffUpdate = false;
            }
            string result = Encoding.ASCII.GetString(readBuff, readPos, length);
            if (Peak && Buff.Count > readPos)
            {
                readPos += length;
            }     
            return result;
        }
        public byte GetByte(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                byte result = readBuff[readPos];
                if (Peak && Buff.Count > readPos)
                    readPos += 1;
                return result;
            }
            else
            {
                throw new Exception("Packet has passed its limit.");
            }
        }
        public byte[] GetBytes(int length, bool Peak = true)
        {
            if (buffUpdate)
            {
                readBuff = Buff.ToArray();
                buffUpdate = false;
            }
            byte[] result = Buff.GetRange(readPos, length).ToArray();
            if (Peak)
                readPos += 4;
            return result;
           
        }
        //variables
        public bool DisposedValue;

        //interface IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!DisposedValue)
            {
                if (disposing)
                {
                    Buff.Clear();
                }
                readPos = 0;
            }
            DisposedValue = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
