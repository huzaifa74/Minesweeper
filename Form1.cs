using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Minesweeper
{
    public partial class Form1 : Form
    {
        int _dim;
        int numofM;
        Cell[,] A;
        public Form1()
        {
            InitializeComponent();
        }


        private void Loading()
        {
            board.Controls.Clear();
            A = new Cell[_dim, _dim];

            int h = board.Height / _dim - 7;
            int w = board.Width / _dim - 7;
            for (int ri = 0; ri < _dim; ri++)
            {
                for (int ci = 0; ci < _dim; ci++)
                {
                    Cell C = new Cell(ri, ci, h, w);
                    C.Click += new System.EventHandler(this.Cell_Click);
               C.MouseDown += new System.Windows.Forms.MouseEventHandler(this.board_MouseDown);
                    board.Controls.Add(C);
                    A[ri, ci] = C;
                }
            }
            InitMines();
        }
        private void InitMines()
        {
            for (int i = 1; i <= numofM; i++)
            {
                Random R = new Random();
                int ri = R.Next(_dim);
                int ci = R.Next(_dim);
                if (A[ri, ci].getnum() == -1)
                {
                    i--;
                    continue;
                }
                A[ri, ci].setnum(-1);


            }
            for (int ri = 0; ri < _dim; ri++)
            {
                for (int ci = 0; ci < _dim; ci++)
                {
                    if (A[ri, ci].getnum() == -1)
                    {
                        continue;
                    }
                    int minescount = windowcount(ri, ci);
                    A[ri, ci].setnum(minescount);

                }
            }
        }
        int windowcount(int ri, int ci)
        {
            int count = 0;
            for (int r = ri - 1; r <= ri + 1; r++)
            {
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if ((r == ri && c == ci) || (r < 0 || c < 0 || r >= _dim || c >= _dim))
                        continue;
                    if (A[r, c].getnum() == -1)
                        count++;
                }
            }
            return count;
        }
        bool Iswin()
        {
            int count = 0;
            for (int r = 0; r < _dim; r++)
            {
                for (int c = 0; c < _dim; c++)
                {
                    if (A[r, c].getnum() == -1 && A[r, c].flag == true)
                        count++;
                }
            }
            if (count == numofM)
                return true;
            else
                return false;
        }
        private void Cell_Click(object sender, EventArgs e)
        {
            Cell C = (Cell)sender;
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                C.BackColor = Color.Red;
                C.flag = true;
                C.Text = "F";
                C.Text = C.Text.ToString();
            }
            if (C.flag == true)
                return;
            if (C.IsOpen == true)
                return;
            if (C.getnum() == -1)
            {
                start.Image = Image.FromFile("C:\\Users\\huzai\\source\\repos\\Final Minesweeper\\Final Minesweeper\\sadface.jpg");
                for (int r = 0; r < _dim; r++)
                {
                    for (int c = 0; c < _dim; c++)
                    {
                        if (A[r, c].getnum() == -1)
                        {
                            A[r, c].Image = Image.FromFile("C:\\Users\\huzai\\source\\repos\\Final Minesweeper\\Final Minesweeper\\bomb.png");

                        }

                    }
                }
                MessageBox.Show("You lost HAHAHAHAHA");
                board.Controls.Clear();
                start.BackgroundImage = Properties.Resources.smiling_face_with_smiling_eyes_1f60a;
            }
            else if (C.getnum() != 0)
            {
                C.Text = C.getnum().ToString();
                C.BackColor = Color.White;
            }
            else
            {
                C.BackColor = Color.White;
                explore(C.ri, C.ci);
            }

            if (Iswin() == true)
            {
                MessageBox.Show("You Wonnnn!!!");
            }
        }
        void explore(int r, int c)
        {
            if (A[r, c].IsOpen == true)
                return;
            A[r, c].IsOpen = true;
            for (int ri = r - 1; ri <= r + 1; ri++)
            {
                for (int ci = c - 1; ci <= c + 1; ci++)
                {
                    if (ri < 0 || ri >= _dim || ci < 0 || ci >= _dim)
                        continue;
                    if (A[ri, ci].IsOpen == false)
                    {

                        if (A[ri, ci].getnum() != 0)
                        {
                            A[ri, ci].Text = A[ri, ci].getnum().ToString();
                            if (A[ri, ci].getnum() == 1)
                            {
                                A[ri, ci].ForeColor = Color.DarkRed;
                            }
                            if (A[ri, ci].getnum() == 2)
                            {
                                A[ri, ci].ForeColor = Color.DarkBlue;
                            }
                            if (A[ri, ci].getnum() == 3)
                            {
                                A[ri, ci].ForeColor = Color.DarkGreen;
                            }
                            if (A[ri, ci].getnum() == 4)
                            {
                                A[ri, ci].ForeColor = Color.Black;
                            }
                            A[ri, ci].IsOpen = true;
                        }
                        else if (A[ri, ci].getnum() == 0)
                        {
                            explore(ri, ci);
                        }
                        A[ri, ci].BackColor = Color.LightYellow;
                    }
                }
            }
        }


        private void board_Paint(object sender, PaintEventArgs e)
        {

        }


        private void board_MouseDown(object sender, MouseEventArgs e)
        {

            Cell C = (Cell)sender;
            if (e.Button.Equals(MouseButtons.Right))
            {
                if (C.flag == false)
                {
                    C.flag = true;
                    C.BackgroundImage = Properties.Resources.flagg;
                    C.BackgroundImageLayout = ImageLayout.Stretch;
                    if (Iswin() == true)
                    {
                        MessageBox.Show("You Wonnnn!!!");
                    }
                    return;
                }
                if (C.flag == true)
                {
                    C.flag = false;
                    C.BackgroundImage = Properties.Resources.lb;
                    C.BackgroundImageLayout = ImageLayout.Stretch;
                    return;
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (easy.Checked)
            {
                _dim = 9;
                numofM = 15;
            }
            if (medium.Checked)
            {
                _dim = 15;
                numofM = 20;
            }
            if (hard.Checked)
            {
                _dim = 20;
                numofM = 25;
            }
            if (_dim == 0)
            {
                MessageBox.Show("Select te krrrr!!!");
                return;
            }
            start.BackgroundImage = Properties.Resources.smiling_face_with_smiling_eyes_1f60a;
              Loading();
        }
    }
}
