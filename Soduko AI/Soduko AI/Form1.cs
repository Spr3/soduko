using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Soduko_AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sudoku = new int[,]{
                { -1, -2, -3, -4, -5, -6, -7, -8, -9 },
                { -11, -12, -13, -14, -15, -16, -17, -18, -19 },
                { -21, -22, -23, -24, -25, -26, -27, -28, -29 },
                { -31, -32, -33, -34, -35, -36, -37, -38, -39 },
                { -41, -42, -43, -44, -45, -46, -47, -48, -49 },
                { -51, -52, -53, -54, -55, -56, -57, -58, -59 },
                { -61, -62, -63, -64, -65, -66, -67, -68, -69 },
                { -71, -72, -73, -74, -75, -76, -77, -78, -79 },
                { -81, -82, -83, -84, -85, -86, -87, -88, -89 }};

            //This next part makes the array board
            //the if true is to shrink everything down
            if (true)
            {
                int a;
                //Changes to origanal form
                for (int i = 8; i >= 0; i--)
                {
                    for (int r = 0; r >= 8; r++)
                    {
                        sudoku[i, r] = -1*((i * 10) + r);
                    }
                }

                //Changes to user
                if (Int32.TryParse(A1.Text, out a)) { sudoku[0, 0] = Int32.Parse(A1.Text); }
                if (Int32.TryParse(B1.Text, out a)) { sudoku[0, 1] = Int32.Parse(B1.Text); }
                if (Int32.TryParse(C1.Text, out a)) { sudoku[0, 2] = Int32.Parse(C1.Text); }
                if (Int32.TryParse(D1.Text, out a)) { sudoku[0, 3] = Int32.Parse(D1.Text); }
                if (Int32.TryParse(E1.Text, out a)) { sudoku[0, 4] = Int32.Parse(E1.Text); }
                if (Int32.TryParse(F1.Text, out a)) { sudoku[0, 5] = Int32.Parse(F1.Text); }
                if (Int32.TryParse(G1.Text, out a)) { sudoku[0, 6] = Int32.Parse(G1.Text); }
                if (Int32.TryParse(H1.Text, out a)) { sudoku[0, 7] = Int32.Parse(H1.Text); }
                if (Int32.TryParse(I1.Text, out a)) { sudoku[0, 8] = Int32.Parse(I1.Text); }
                if (Int32.TryParse(A2.Text, out a)) { sudoku[1, 0] = Int32.Parse(A2.Text); }
                if (Int32.TryParse(B2.Text, out a)) { sudoku[1, 1] = Int32.Parse(B2.Text); }
                if (Int32.TryParse(C2.Text, out a)) { sudoku[1, 2] = Int32.Parse(C2.Text); }
                if (Int32.TryParse(D2.Text, out a)) { sudoku[1, 3] = Int32.Parse(D2.Text); }
                if (Int32.TryParse(E2.Text, out a)) { sudoku[1, 4] = Int32.Parse(E2.Text); }
                if (Int32.TryParse(F2.Text, out a)) { sudoku[1, 5] = Int32.Parse(F2.Text); }
                if (Int32.TryParse(G2.Text, out a)) { sudoku[1, 6] = Int32.Parse(G2.Text); }
                if (Int32.TryParse(H2.Text, out a)) { sudoku[1, 7] = Int32.Parse(H2.Text); }
                if (Int32.TryParse(I2.Text, out a)) { sudoku[1, 8] = Int32.Parse(I2.Text); }
                if (Int32.TryParse(A3.Text, out a)) { sudoku[2, 0] = Int32.Parse(A3.Text); }
                if (Int32.TryParse(B3.Text, out a)) { sudoku[2, 1] = Int32.Parse(B3.Text); }
                if (Int32.TryParse(C3.Text, out a)) { sudoku[2, 2] = Int32.Parse(C3.Text); }
                if (Int32.TryParse(D3.Text, out a)) { sudoku[2, 3] = Int32.Parse(D3.Text); }
                if (Int32.TryParse(E3.Text, out a)) { sudoku[2, 4] = Int32.Parse(E3.Text); }
                if (Int32.TryParse(F3.Text, out a)) { sudoku[2, 5] = Int32.Parse(F3.Text); }
                if (Int32.TryParse(G3.Text, out a)) { sudoku[2, 6] = Int32.Parse(G3.Text); }
                if (Int32.TryParse(H3.Text, out a)) { sudoku[2, 7] = Int32.Parse(H3.Text); }
                if (Int32.TryParse(I3.Text, out a)) { sudoku[2, 8] = Int32.Parse(I3.Text); }
                if (Int32.TryParse(A4.Text, out a)) { sudoku[3, 0] = Int32.Parse(A4.Text); }
                if (Int32.TryParse(B4.Text, out a)) { sudoku[3, 1] = Int32.Parse(B4.Text); }
                if (Int32.TryParse(C4.Text, out a)) { sudoku[3, 2] = Int32.Parse(C4.Text); }
                if (Int32.TryParse(D4.Text, out a)) { sudoku[3, 3] = Int32.Parse(D4.Text); }
                if (Int32.TryParse(E4.Text, out a)) { sudoku[3, 4] = Int32.Parse(E4.Text); }
                if (Int32.TryParse(F4.Text, out a)) { sudoku[3, 5] = Int32.Parse(F4.Text); }
                if (Int32.TryParse(G4.Text, out a)) { sudoku[3, 6] = Int32.Parse(G4.Text); }
                if (Int32.TryParse(H4.Text, out a)) { sudoku[3, 7] = Int32.Parse(H4.Text); }
                if (Int32.TryParse(I4.Text, out a)) { sudoku[3, 8] = Int32.Parse(I4.Text); }
                if (Int32.TryParse(A5.Text, out a)) { sudoku[4, 0] = Int32.Parse(A5.Text); }
                if (Int32.TryParse(B5.Text, out a)) { sudoku[4, 1] = Int32.Parse(B5.Text); }
                if (Int32.TryParse(C5.Text, out a)) { sudoku[4, 2] = Int32.Parse(C5.Text); }
                if (Int32.TryParse(D5.Text, out a)) { sudoku[4, 3] = Int32.Parse(D5.Text); }
                if (Int32.TryParse(E5.Text, out a)) { sudoku[4, 4] = Int32.Parse(E5.Text); }
                if (Int32.TryParse(F5.Text, out a)) { sudoku[4, 5] = Int32.Parse(F5.Text); }
                if (Int32.TryParse(G5.Text, out a)) { sudoku[4, 6] = Int32.Parse(G5.Text); }
                if (Int32.TryParse(H5.Text, out a)) { sudoku[4, 7] = Int32.Parse(H5.Text); }
                if (Int32.TryParse(I5.Text, out a)) { sudoku[4, 8] = Int32.Parse(I5.Text); }
                if (Int32.TryParse(A6.Text, out a)) { sudoku[5, 0] = Int32.Parse(A6.Text); }
                if (Int32.TryParse(B6.Text, out a)) { sudoku[5, 1] = Int32.Parse(B6.Text); }
                if (Int32.TryParse(C6.Text, out a)) { sudoku[5, 2] = Int32.Parse(C6.Text); }
                if (Int32.TryParse(D6.Text, out a)) { sudoku[5, 3] = Int32.Parse(D6.Text); }
                if (Int32.TryParse(E6.Text, out a)) { sudoku[5, 4] = Int32.Parse(E6.Text); }
                if (Int32.TryParse(F6.Text, out a)) { sudoku[5, 5] = Int32.Parse(F6.Text); }
                if (Int32.TryParse(G6.Text, out a)) { sudoku[5, 6] = Int32.Parse(G6.Text); }
                if (Int32.TryParse(H6.Text, out a)) { sudoku[5, 7] = Int32.Parse(H6.Text); }
                if (Int32.TryParse(I6.Text, out a)) { sudoku[5, 8] = Int32.Parse(I6.Text); }
                if (Int32.TryParse(A7.Text, out a)) { sudoku[6, 0] = Int32.Parse(A7.Text); }
                if (Int32.TryParse(B7.Text, out a)) { sudoku[6, 1] = Int32.Parse(B7.Text); }
                if (Int32.TryParse(C7.Text, out a)) { sudoku[6, 2] = Int32.Parse(C7.Text); }
                if (Int32.TryParse(D7.Text, out a)) { sudoku[6, 3] = Int32.Parse(D7.Text); }
                if (Int32.TryParse(E7.Text, out a)) { sudoku[6, 4] = Int32.Parse(E7.Text); }
                if (Int32.TryParse(F7.Text, out a)) { sudoku[6, 5] = Int32.Parse(F7.Text); }
                if (Int32.TryParse(G7.Text, out a)) { sudoku[6, 6] = Int32.Parse(G7.Text); }
                if (Int32.TryParse(H7.Text, out a)) { sudoku[6, 7] = Int32.Parse(H7.Text); }
                if (Int32.TryParse(I7.Text, out a)) { sudoku[6, 8] = Int32.Parse(I7.Text); }
                if (Int32.TryParse(A8.Text, out a)) { sudoku[7, 0] = Int32.Parse(A8.Text); }
                if (Int32.TryParse(B8.Text, out a)) { sudoku[7, 1] = Int32.Parse(B8.Text); }
                if (Int32.TryParse(C8.Text, out a)) { sudoku[7, 2] = Int32.Parse(C8.Text); }
                if (Int32.TryParse(D8.Text, out a)) { sudoku[7, 3] = Int32.Parse(D8.Text); }
                if (Int32.TryParse(E8.Text, out a)) { sudoku[7, 4] = Int32.Parse(E8.Text); }
                if (Int32.TryParse(F8.Text, out a)) { sudoku[7, 5] = Int32.Parse(F8.Text); }
                if (Int32.TryParse(G8.Text, out a)) { sudoku[7, 6] = Int32.Parse(G8.Text); }
                if (Int32.TryParse(H8.Text, out a)) { sudoku[7, 7] = Int32.Parse(H8.Text); }
                if (Int32.TryParse(I8.Text, out a)) { sudoku[7, 8] = Int32.Parse(I8.Text); }
                if (Int32.TryParse(A9.Text, out a)) { sudoku[8, 0] = Int32.Parse(A9.Text); }
                if (Int32.TryParse(B9.Text, out a)) { sudoku[8, 1] = Int32.Parse(B9.Text); }
                if (Int32.TryParse(C9.Text, out a)) { sudoku[8, 2] = Int32.Parse(C9.Text); }
                if (Int32.TryParse(D9.Text, out a)) { sudoku[8, 3] = Int32.Parse(D9.Text); }
                if (Int32.TryParse(E9.Text, out a)) { sudoku[8, 4] = Int32.Parse(E9.Text); }
                if (Int32.TryParse(F9.Text, out a)) { sudoku[8, 5] = Int32.Parse(F9.Text); }
                if (Int32.TryParse(G9.Text, out a)) { sudoku[8, 6] = Int32.Parse(G9.Text); }
                if (Int32.TryParse(H9.Text, out a)) { sudoku[8, 7] = Int32.Parse(H9.Text); }
                if (Int32.TryParse(I9.Text, out a)) { sudoku[8, 8] = Int32.Parse(I9.Text); }
            }
            //Checks if there are Duplicates horizontaly
            for (int r = 8; r >= 0; r--)
            {
                List<int> numbers = new List<int>();
                numbers.Add(0);
                for (int i = 8; i >= 0; i--)
                {
                    numbers.Add(sudoku[r, i]);
                }
                if (numbers.Count != numbers.Distinct().Count())
                {
                    Console.WriteLine("Dups");
                }
                numbers.Clear();
            }
            //Checks if there are Dups Verticaly
            for (int r = 8; r >= 0; r--)
            {
                List<int> numbers2 = new List<int>();
                numbers2.Add(0);
                for (int i = 8; i >= 0; i--)
                {
                    numbers2.Add(sudoku[i, r]);
                }
                if (numbers2.Count != numbers2.Distinct().Count())
                {
                    Console.WriteLine("Dups");
                }
                numbers2.Clear();
            }
        }
    }
}