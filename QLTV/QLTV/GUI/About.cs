using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV.Use_Control
{
    public partial class About : UserControl
    {
        string A, B, C, D, E, F, G;
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            //Chen Flash vao Control
            flash.Movie = Application.StartupPath + "\\banner.jpg";
            
            //Hieu ung Chu Chay
            A = labelControl1.Text;
            B = labelControl2.Text;
            C = labelControl3.Text;
            D = labelControl4.Text;
            E = labelControl5.Text;
            F = labelControl6.Text;
            G = labelControl7.Text;
            labelControl7.Text = "";
            labelControl6.Text = "";
            labelControl5.Text = "";
            labelControl4.Text = "";
            labelControl3.Text = "";
            labelControl2.Text = "";
            labelControl1.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            labelControl1.Text = labelControl1.Text + a;
            if (d == x)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = B.Length;
            d++;
            string a = B.Substring(0, 1);
            B = B.Substring(1, B.Length - 1);
            labelControl2.Text = labelControl2.Text + a;
            if (d == x)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = C.Length;
            d++;
            string a = C.Substring(0, 1);
            C = C.Substring(1, C.Length - 1);
            labelControl3.Text = labelControl3.Text + a;
            if (d == x)
            {
                timer3.Stop();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = D.Length;
            d++;
            string a = D.Substring(0, 1);
            D = D.Substring(1, D.Length - 1);
            labelControl4.Text = labelControl4.Text + a;
            if (d == x)
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = E.Length;
            d++;
            string a = E.Substring(0, 1);
            E = E.Substring(1, E.Length - 1);
            labelControl5.Text = labelControl5.Text + a;
            if (d == x)
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = F.Length;
            d++;
            string a = F.Substring(0, 1);
            F = F.Substring(1, F.Length - 1);
            labelControl6.Text = labelControl6.Text + a;
            if (d == x)
            {
                timer6.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = G.Length;
            d++;
            string a = G.Substring(0, 1);
            G = G.Substring(1, G.Length - 1);
            labelControl7.Text = labelControl7.Text + a;
            if (d == x)
            {
                timer7.Stop();
            }
        }

    }
}
