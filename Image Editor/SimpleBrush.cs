using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Editor
{
    class SimpleBrush
    {
        int size = 1;
        int smooth = 0;
        int opacity = 255;
        SimpleBrush(int size,int smooth,Byte opacity)
        {
            this.size = size;
            this.smooth = smooth;
            this.opacity = opacity;
        }
        SimpleBrush()
        {

        }
    }
}
