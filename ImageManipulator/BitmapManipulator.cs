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
        public ZoneManipulator zone;

        Bitmap image;

        public BitmapManipulator(Bitmap image)
        {
            this.image = image;

            zone = new ZoneManipulator(image.Width, image.Height);
        }

        public Color[] GetZone()
        {
            var pos  = zone.GetPosition();
            var size = zone.GetSize();

            List<Color> colors = new List<Color>(size.X * size.Y);

            for (int x = pos.X; x < pos.X + size.X; x++)
            {
                for (int y = pos.Y; y < pos.Y + size.Y; y++)
                {
                    colors.Add(image.GetPixel(x, y));
                }
            }

            return colors.ToArray();
        }
        
    }
}
