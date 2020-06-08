using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Encoder
    {
        private int _key;
        private string _encodedStr;
        private StreamWriter _inStream;

        public Encoder(StreamWriter inStream, int key)
        {
            _encodedStr = string.Empty;
            _inStream = inStream;
            _key = key;
        }

        public void Encode(string input)
        {
            if (string.IsNullOrEmpty(input)) return;

            var result = string.Empty;
            _encodedStr = input;
            var length = _encodedStr.Length;

            for (int i = 0; i < length; i++)
                result += (char)(_encodedStr[i] + _key);

            _encodedStr = result;

            if (_inStream != null)
                using (_inStream)
                    _inStream.Write(_encodedStr);
        }
        public string GetString() => _encodedStr;
        public void Close() => _inStream.Close();
       
    }
}
