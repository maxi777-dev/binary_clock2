using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int h1 = 0;
        int h2 = 0;
        int m1 = 0;
        int m2 = 0;
        int s1 = 0;
        int s2 = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                h1 += 1;
            else
                h1 -= 1;
            lbl_h1.Text = h1.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                h1 += 2;
            else
                h1 -= 2;
            lbl_h1.Text = h1.ToString();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                h2 += 1;
            else
                h2 -= 1;
            lbl_h2.Text = h2.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                h2 += 2;
            else
                h2 -= 2;
            lbl_h2.Text = h2.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                h2 += 4;
            else
                h2 -= 4;
            lbl_h2.Text = h2.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                h2 += 8;
            else
                h2 -= 8;
            lbl_h2.Text = h2.ToString();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
                m1 += 1;
            else
                m1 -= 1;
            lbl_m1.Text = m1.ToString();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
                m1 += 2;
            else
                m1 -= 2;
            lbl_m1.Text = m1.ToString();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                m2 += 1;
            else
                m2 -= 1;
            lbl_m2.Text = m2.ToString();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                m2 += 2;
            else
                m2 -= 2;
            lbl_m2.Text = m2.ToString();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                m2 += 4;
            else
                m2 -= 4;
            lbl_m2.Text = m2.ToString();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                m2 += 8;
            else
                m2 -= 8;
            lbl_m2.Text = m2.ToString();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
                s1 += 2;
            else
                s1 -= 2;
            lbl_s1.Text = s1.ToString();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
                s1 += 1;
            else
                s1 -= 1;
            lbl_s1.Text = s1.ToString();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
                s2 += 1;
            else
                s2 -= 1;
            lbl_s2.Text = s2.ToString();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
                s2 += 2;
            else
                s2 -= 2;
            lbl_s2.Text = s2.ToString();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
                s2 += 4;
            else
                s2 -= 4;
            lbl_s2.Text = s2.ToString();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
                s2 += 8;
            else
                s2 -= 8;
            lbl_s2.Text = s2.ToString();
        }
    }
}
