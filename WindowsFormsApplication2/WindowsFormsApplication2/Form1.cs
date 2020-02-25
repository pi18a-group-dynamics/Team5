using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool indicator = true;
        int x, y;
        int[,] field = new int[32, 32];
        public Button but = new Button();
        public Form1()
        {
            int i,j;
            InitializeComponent();            
            for (i = 1; i < 31; i++)                            //генерация кнопок
            {
                for (j = 1; j < 31; j++)
                {
                    but = new Button();
                    but.Size = new Size(25, 25);                //размер кнопки
                    but.Location = new Point(i*25, j*25);       //ее позиция
                    but.Click += new EventHandler(but_Click);   //действие при клике
                    but.Text = " ";
                    this.Controls.Add(but);
                }
            }
        }

        public void but_Click(object sender, EventArgs e)       //действие при нажатии 
        {
            but = (Button)sender;
            x = (but.Location.X / 25);
            y = (but.Location.Y / 25);
            string location = x + ":" + y;
            //MessageBox.Show(location);
            if (indicator)
            {
                but.Text = "X";
                field[x, y] = 1;
                indicator = false;
            }
            else
            {
                but.Text = "O";
                field[x, y] = 2;
                indicator = true;
            }
            but.Enabled = false;
            Check();
        }

        private void Check()
        {
            //if (x == 1 && y == 1) /*верхний левый угол последний элемент*/
            //{
            //    if (field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y] && field[x + 4, y] == field[x, y]                 ||  /* горизонталь */
            //        field[x + 1, y + 1] == field[x, y] && field[x + 2, y + 2] == field[x, y] && field[x + 3, y + 3] == field[x, y] && field[x + 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y] && field[x, y + 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 1 && y == 30) /*нижний левый угол последний элемент*/
            //{
            //    if (field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y] && field[x + 4, y] == field[x, y]                 ||  /* горизонталь */
            //        field[x + 1, y - 1] == field[x, y] && field[x + 2, y - 2] == field[x, y] && field[x + 3, y - 3] == field[x, y] && field[x + 4, y - 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y] && field[x, y - 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 30 && y == 1) /*верхний правый угол последний элемент*/
            //{
            //    if (field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y] && field[x - 4, y] == field[x, y]                 ||  /* горизонталь */
            //        field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] && field[x - 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y] && field[x, y + 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 30 && y == 30) /*нижний правый угол последний элемент*/
            //{
            //    if (field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y] && field[x - 4, y] == field[x, y]                 ||  /* горизонталь */
            //        field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] && field[x - 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y] && field[x, y - 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //    /* переход на другие условия-------------------------------------------------------------------------------------------------------------------------------------------------*/
            //else if (x == 1 && y == 2) /*верхний левый угол предпоследний элемент*/
            //{
            //    if (field[x - 1, y] == field[x, y] && field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y]                 ||  /* горизонталь */
            //        field[x + 1, y + 1] == field[x, y] && field[x + 2, y + 2] == field[x, y] && field[x + 3, y + 3] == field[x, y] && field[x + 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y - 1] == field[x, y] && field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 1 && y == 30) /*нижний левый угол последний элемент*/
            //{
            //    if (field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y] && field[x + 4, y] == field[x, y] ||  /* горизонталь */
            //        field[x + 1, y - 1] == field[x, y] && field[x + 2, y - 2] == field[x, y] && field[x + 3, y - 3] == field[x, y] && field[x + 4, y - 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y] && field[x, y - 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 30 && y == 1) /*верхний правый угол последний элемент*/
            //{
            //    if (field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y] && field[x - 4, y] == field[x, y] ||  /* горизонталь */
            //        field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] && field[x - 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y] && field[x, y + 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else if (x == 30 && y == 30) /*нижний правый угол последний элемент*/
            //{
            //    if (field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y] && field[x - 4, y] == field[x, y] ||  /* горизонталь */
            //        field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] && field[x - 4, y + 4] == field[x, y] ||  /* диагональ*/
            //        field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y] && field[x, y - 4] == field[x, y])                    /* вертикаль*/
            //    {
            //        MessageBox.Show("Победа");
            //    }
            //}
            //else
            //{
                if (field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y]                 || /* горизонталь, если последний элемент по середине*/
                    field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y]                 || /* вертикаль, если последний элемент по середине*/
                    field[x - 1, y - 1] == field[x, y] && field[x - 2, y - 2] == field[x, y] && field[x + 1, y + 1] == field[x, y] && field[x + 2, y + 2] == field[x, y] || /* диагональ слева на право,  элемент по середине*/
                    field[x + 1, y - 1] == field[x, y] && field[x + 2, y - 2] == field[x, y] && field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] || /* диагональ справа на лево,  элемент по середине*/
                    field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y] && field[x - 4, y] == field[x, y]                 || /* если последний элемент крайний справа*/
                    field[x + 1, y + 1] == field[x, y] && field[x + 2, y + 2] == field[x, y] && field[x + 3, y + 3] == field[x, y] && field[x +4 , y + 4] == field[x, y] || /* диагональ слева на право,  крайний сверху*/
                    field[x - 1, y - 1] == field[x, y] && field[x - 2, y - 2] == field[x, y] && field[x - 3, y - 3] == field[x, y] && field[x - 4, y - 4] == field[x, y] || /* диагональ слева на право,  крайний снизу*/
                    field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] && field[x - 4, y + 4] == field[x, y] || /* диагональ справа на лево,  крайний сверху*/
                    field[x + 1, y - 1] == field[x, y] && field[x + 2, y - 2] == field[x, y] && field[x + 3, y - 3] == field[x, y] && field[x + 4, y - 4] == field[x, y] || /* диагональ справа на лево,  крайний снизу*/
                    field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y] && field[x + 4, y] == field[x, y]                 || /* если последний элемент крайний слева*/
                    field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y] && field[x, y + 4] == field[x, y]                 || /* если последний элемент крайний сверху*/
                    field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y] && field[x, y - 4] == field[x, y]                 || /* если последний элемент крайний снизу*/
                    field[x + 1, y] == field[x, y] && field[x - 1, y] == field[x, y] && field[x - 2, y] == field[x, y] && field[x - 3, y] == field[x, y]                 || /* если последний элемент предпоследний справа*/
                    field[x - 1, y] == field[x, y] && field[x + 1, y] == field[x, y] && field[x + 2, y] == field[x, y] && field[x + 3, y] == field[x, y]                 || /* если последний элемент предпоследний слева*/
                    field[x, y - 1] == field[x, y] && field[x, y + 1] == field[x, y] && field[x, y + 2] == field[x, y] && field[x, y + 3] == field[x, y]                 || /* если последний элемент предпоследний сверху*/
                    field[x, y + 1] == field[x, y] && field[x, y - 1] == field[x, y] && field[x, y - 2] == field[x, y] && field[x, y - 3] == field[x, y]                 || /* если последний элемент предпоследний снизу*/
                    field[x - 1, y - 1] == field[x, y] && field[x + 1, y + 1] == field[x, y] && field[x + 2, y + 2] == field[x, y] && field[x + 3, y + 3] == field[x, y] || /*диагональ справа на лево, предпоследний сверху*/ 
                    field[x + 1, y + 1] == field[x, y] && field[x - 1, y - 1] == field[x, y] && field[x - 2, y - 2] == field[x, y] && field[x - 3, y - 3] == field[x, y] || /*диагональ справа на лево, предпоследний снизу*/
                    field[x + 1, y - 1] == field[x, y] && field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y] || /* диагональ справа на лево,  предпоследний сверху*/
                    field[x + 1, y - 1] == field[x, y] && field[x - 1, y + 1] == field[x, y] && field[x - 2, y + 2] == field[x, y] && field[x - 3, y + 3] == field[x, y]    /* диагональ справа на лево,  предпоследний снизу*/
                    )
                {
                    if (!indicator)
                    {
                        MessageBox.Show("Победили Х");
                    }
                    else
                    {
                        MessageBox.Show("Победили О");
                    }
                }
            /*}*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // окно с выбором игрока
            if (f.ShowDialog() == DialogResult.Yes)
            {
                indicator = true;
            }
            else
            {
                indicator = false;
            }
        }
    }
}