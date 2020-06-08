using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Decoder
    {
        private int _key;
        private StreamReader _outStream;

        public Decoder(StreamReader outStream, int key)
        {
            _outStream = outStream;
            _key = key;
        }

        public string Decode()
        {
            string result = string.Empty;
            string encoded = _outStream.ReadToEnd();

            foreach (var ch in encoded)
                result += (char)(ch - _key);

            return result;
        }

        public void Close() => _outStream.Close();
    }
}
