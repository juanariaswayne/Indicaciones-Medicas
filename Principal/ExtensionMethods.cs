using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace ExtensionMethods
{    
        public static class MyExtensions
        {
            public static byte[] Compress(this byte[] raw)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (GZipStream gzip = new GZipStream(memory,
                        CompressionMode.Compress, true))
                    {
                        gzip.Write(raw, 0, raw.Length);
                    }
                    return memory.ToArray();
                }
            }

            public static byte[] Decompress(this byte[] gzip)
            {
                // Create a GZIP stream with decompression mode.
                // ... Then create a buffer and write into while reading from the GZIP stream.
                using (GZipStream stream = new GZipStream(new MemoryStream(gzip),
                    CompressionMode.Decompress))
                {
                    const int size = 4096;
                    byte[] buffer = new byte[size];
                    using (MemoryStream memory = new MemoryStream())
                    {
                        int count = 0;
                        do
                        {
                            count = stream.Read(buffer, 0, size);
                            if (count > 0)
                            {
                                memory.Write(buffer, 0, count);
                            }
                        }
                        while (count > 0);
                        return memory.ToArray();
                    }
                }
            }

            public static int ToInt32(this String _string)
            {
              return Convert.ToInt32(_string);
            }
                   
            public static void Data(this ComboBox _combo, Object _Data, String _Value, String _Display)
            {
                _combo.DataSource = _Data;
                _combo.ValueMember = _Value;
                _combo.DisplayMember = _Display;
             }
            
    }    
}
