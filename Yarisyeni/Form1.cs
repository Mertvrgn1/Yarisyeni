using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yarisyeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            SolaYasla();
        }

        private void SolaYasla()
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            TmBasla.Enabled = true;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TmBasla_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(1, 20);

            pictureBox2.Left += rnd.Next(1, 20);

            if (pictureBox1.Right >= panel1.Left || pictureBox2.Right >= panel1.Left)
            {
                TmBasla.Enabled = false;

                if (pictureBox1.Left < pictureBox2.Left)
                {
                    MessageBox.Show("Siyah At Kazandı");
                }
                else
                {
                    MessageBox.Show("Beyaz At Kazandı");
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TmBasla.Interval = Convert.ToInt32(comboBox1.SelectedItem) * 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeriYasla();
        }

        private void GeriYasla()
        {
            pictureBox1.Left = panel1.Left - pictureBox1.Width;
            pictureBox2.Left = panel1.Left - pictureBox2.Width;
            TmBitir.Enabled = true;
        }

        private void TmBitir_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= rnd.Next(1, 20);
            pictureBox2.Left -= rnd.Next(1, 20);
            if (pictureBox2.Left <= 0 || pictureBox1.Left <= 0)
            {
                TmBitir.Enabled = false;
                if (pictureBox1.Left < pictureBox2.Left)
                {
                    MessageBox.Show("Beyaz At Kazandı");
                }
                else
                {
                    MessageBox.Show("Siyah At Kazandı");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int siyahTop = pictureBox1.Top;
            int beyazTop = pictureBox2.Top;
            pictureBox1.Top = beyazTop;
            pictureBox2.Top = siyahTop;
        }

        private void ButtonFormD_Click(object sender, EventArgs e)
        {
            if (ClDiaFon.ShowDialog() == DialogResult.OK) 
            {
                Color formrenk = ClDiaFon.Color;
                this.BackColor = formrenk;
                    
            }
             
        }

        private void btnPanelC_Click(object sender, EventArgs e)
        {
            if (ClDiaPanel.ShowDialog() == DialogResult.OK)
            {
                Color Panelrenk = ClDiaPanel.Color;
                this.panel1.BackColor = Panelrenk;

            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font fnt = fontDialog1.Font;
                this.Font= fnt;
            }
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolaYasla();
        }

        private void geriYarışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeriYasla();
        }

        private void formRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonFormD_Click(null,null);
        }

        private void panelRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPanelC_Click(null, null);
        }
    }

    
}
