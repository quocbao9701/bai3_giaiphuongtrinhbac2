using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_giaiphuongtrinhbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, delta;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        lblKQ.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    lblKQ.Text = "Phương trình có vô số nghiệm";
                }
            }
            else
            {
                x1 = x2 = -c / b;
                lblKQ.Text = "Phương trình có nghiệm x = " + x1;
            }


else
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    lblKQ.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b(2 * a);
                }
                lblKQ.Text = "Phương trình có nghiệm kép x1 = x2" + 1;
            }
else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
        }
    }
}
