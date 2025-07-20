using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNPCPos.Level5.Compression.ETC1
{
    public class ETC1 : ICompression
    {
        private int Width;

        private int Height;

        private bool HasAlphaCanal;

        public ETC1(bool hasAlphaCanal, int width, int height)
        {
            HasAlphaCanal = hasAlphaCanal;
            Width = width;
            Height = height;
        }

        public byte[] Compress(byte[] data)
        {
            // Not Implemented
            return null;
        }

        public byte[] Decompress(byte[] data)
        {
            return ETC1Decoder.DecompressETC1A4(data, Width, Height, HasAlphaCanal);
        }
    }
}
