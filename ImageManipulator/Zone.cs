using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulator
{
    public sealed class Zone
    {
        int viewZonePosX = 0;
        int viewZonePosY = 0;

        int viewZoneSizeX = 1;
        int viewZoneSizeY = 1;

        int _width;
        int _height;

        public Zone(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Point GetPosition()
        {
            return new Point(viewZonePosX, viewZonePosY);
        }

        public Point GetSize()
        {
            return new Point(viewZoneSizeX, viewZoneSizeY);
        }

        public bool SetSizeX(int x)
        {
            if ((viewZonePosX + x) < (_width - x) && x > 0)
            {
                viewZoneSizeX = x;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetSizeY(int y)
        {
            if ((viewZonePosY + y) < (_height - y) && y > 0)
            {
                viewZoneSizeY = y;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetPositionX(int x)
        {
            if (x <= (_width - viewZoneSizeX) && x >= 0)
            {
                viewZonePosX = x;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SetPositionY(int y)
        {
            if (y <= (_height - viewZoneSizeY) && y >= 0)
            {
                viewZonePosY = y;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShiftPositionX(int x)
        {
            return SetPositionX(viewZonePosX + x);
        }

        public bool ShiftPositionY(int y)
        {
            return SetPositionY(viewZonePosY + y);
        }
    }
}
