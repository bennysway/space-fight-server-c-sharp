using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceFightServer
{
    public class ByteBuffer : IDisposable
    {
        List<byte> Buff;
        byte[] readBuff;
        int readPos;
        bool buffUpdate;

        public ByteBuffer()
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
        #region Write Data
        public void WriteByte(byte _byte)
        {
            Buff.Add(_byte);
            buffUpdate = true;
        }
        public void WriteBytes(byte[] _bytes)
        {
            Buff.AddRange(_bytes);
            buffUpdate = true;
        }
        public void WriteShort(short _short)
        {
            Buff.AddRange(BitConverter.GetBytes(_short));
            buffUpdate = true;
        }
        public void WriteInteger(int _int)
        {
            Buff.AddRange(BitConverter.GetBytes(_int));
            buffUpdate = true;
        }
        public void WriteLong(long _long)
        {
            Buff.AddRange(BitConverter.GetBytes(_long));
            buffUpdate = true;
        }
        public void WriteFloat(float _float)
        {
            Buff.AddRange(BitConverter.GetBytes(_float));
            buffUpdate = true;
        }
        public void WriteString(string _string)
        {
            Buff.AddRange(BitConverter.GetBytes(_string.Length));
            Buff.AddRange(Encoding.ASCII.GetBytes(_string));
            buffUpdate = true;
        }
        #endregion
        #region Read Data
        public int ReadInteger(bool Peak = true)
        {
            if(Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                int result = BitConverter.ToInt32(readBuff, readPos);
                if (Peak & Buff.Count > readPos)
                {
                    readPos += 4;
                }
                return result;
            }
            else
            {
                throw new Exception("Byte buffer has exceeded its limit");
            }
        }
        public long ReadLong(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                long result = BitConverter.ToInt64(readBuff, readPos);
                if (Peak & Buff.Count > readPos)
                {
                    readPos += 8;
                }
                return result;
            }
            else
            {
                throw new Exception("Byte buffer has exceeded its limit");
            }
        }
        public string ReadString(bool Peak = true)
        {
            int length = ReadInteger(true);
           
            if (buffUpdate)
            {
                readBuff = Buff.ToArray();
                buffUpdate = false;
            }
            string result = Encoding.ASCII.GetString(readBuff, readPos, length);
            if (Peak & Buff.Count > readPos)
            {
                if (result.Length > 0)
                    readPos += length;
            }
            return result;
           
        }
        public byte ReadByte(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                byte result = readBuff[readPos];
                if (Peak & Buff.Count > readPos)
                {
                    readPos += 1;
                }
                return result;
            }
            else
            {
                throw new Exception("Byte buffer has exceeded its limit");
            }
        }
        public byte[] ReadBytes(int length, bool Peak = true)
        {
            
            if (buffUpdate)
            {
                readBuff = Buff.ToArray();
                buffUpdate = false;
            }
            byte[] result = Buff.GetRange(readPos,length).ToArray();
            if (Peak)
            {
                readPos += length;
            }
            return result;
        }
        public float ReadFloat(bool Peak = true)
        {
            if (Buff.Count > readPos)
            {
                if (buffUpdate)
                {
                    readBuff = Buff.ToArray();
                    buffUpdate = false;
                }
                float result = BitConverter.ToSingle(readBuff, readPos);
                if (Peak & Buff.Count > readPos)
                {
                    readPos += 4;
                }
                return result;
            }
            else
            {
                throw new Exception("Byte buffer has exceeded its limit");
            }
        }
        #endregion
        #region Disposing
        private bool DisposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!DisposedValue)
            {
                if (disposing)
                    Buff.Clear();
            }
            DisposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
