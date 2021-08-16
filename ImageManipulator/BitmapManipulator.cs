using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public sealed class BitmapManipulator
    {
        public Zone _zone;

        Bitmap _image;

        public BitmapManipulator(Bitmap image)
        {
            _image = image;

            _zone = new Zone(image.Width, image.Height);
        }

        public Color[] GetZone()
        {
            var pos  = _zone.GetPosition();
            var size = _zone.GetSize();

            List<Color> colors = new List<Color>(size.X * size.Y);

            for (int x = pos.X; x < pos.X + size.X; x++)
            {
                for (int y = pos.Y; y < pos.Y + size.Y; y++)
                {
                    colors.Add(_image.GetPixel(x, y));
                }
            }

            return colors.ToArray();
        }
        
    }
}
