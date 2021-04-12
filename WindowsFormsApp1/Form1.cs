using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            int x = 48, y = 88;

            for (int i = 0; i < 10; i++)
            {
                x = 48;
                y += 32;
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Margin = new Padding(3, 3, 3, 3);
                    button.Size = new Size(30, 26);
                    button.Location = new Point(x,y);
                    button.Name = (""+i.ToString()+"_"+j.ToString()+"");
                    this.Controls.Add(button);
                    x += 36;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {
                            ((Button)c).Click += ButtonClick;
                        }
                    }
                }
               
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }
    }
}
