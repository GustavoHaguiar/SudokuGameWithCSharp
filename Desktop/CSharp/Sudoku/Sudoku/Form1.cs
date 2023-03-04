using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int[] arrNum = {
            (int)n1.Value, (int)n2.Value, (int)n3.Value,
            (int)n4.Value, (int)n5.Value, (int)n6.Value,
            (int)n7.Value, (int)n8.Value, (int)n9.Value
            };

            for(int a = 0; a < 8; a++)
            {
                for(int b = a + 1; b < 9; b++)
                {
                    if (arrNum[a] == arrNum[b])
                    {
                        arrNum[a] -= 1;
                    }
                }

            }
            n1.Value = arrNum[0];
            n2.Value = arrNum[1];
            n3.Value = arrNum[2];
            n4.Value = arrNum[3];
            n5.Value = arrNum[4];
            n6.Value = arrNum[5];
            n7.Value = arrNum[6];
            n8.Value = arrNum[7];
            n9.Value = arrNum[8];


            int som1 = (int)n1.Value + (int)n2.Value + (int)n3.Value;
            int som2 = (int)n4.Value + (int)n5.Value + (int)n6.Value;
            int som3 = (int)n7.Value + (int)n8.Value + (int)n9.Value;
            int som4 = (int)n1.Value + (int)n4.Value + (int)n7.Value;
            int som5 = (int)n2.Value + (int)n5.Value + (int)n8.Value;
            int som6 = (int)n3.Value + (int)n6.Value + (int)n9.Value;
            int som7 = (int)n1.Value + (int)n5.Value + (int)n9.Value;
            int som8 = (int)n3.Value + (int)n5.Value + (int)n7.Value;

            int[] arrSom =
            {
                som1, som2, som3, som4,
                som5, som6, som7, som8
            };

            for(int SomN = 0; SomN < 9; SomN++)
            {
                if(arrSom[SomN] == 15)
                {
                    Text = "você somou o número 15 sem repetir!";
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1.Value = 1; n2.Value = 2;
            n3.Value = 3; n4.Value = 4;
            n5.Value = 5; n6.Value = 6;
            n7.Value = 7; n8.Value = 8;
            n9.Value = 9;
            Text = "Sudoku Game";
            
        }
    }
}
