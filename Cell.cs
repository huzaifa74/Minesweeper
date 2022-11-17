using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Minesweeper
{
    class Cell:Button
    {
        int num = 0;
        public bool IsOpen = false;
        public bool flag = false;
        public int ri, ci;
        public Cell(int r, int c, int H, int W)
        {
            this.Height = H;
            this.Width = W;
            this.ri = r;
            this.ci = c;
        }
        public void setnum(int n)
        {
            num = n;
        }
        public int getnum()
        {
            return num;
        }
    }
}
