using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaÖdevi
{
    public partial class FrmTextBoxKontrol : Form
    {
        public FrmTextBoxKontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font eskiFont = textBox1.Font;
            FontStyle yeniStil = eskiFont.Style;

            if (eskiFont.Bold)
            {
                yeniStil &= ~FontStyle.Bold;
            }
            else
            {
                yeniStil |= FontStyle.Bold;
            }

            textBox1.Font = new Font(eskiFont, yeniStil);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font eskiFont = textBox1.Font;
            FontStyle yeniStil = eskiFont.Style;

            if (eskiFont.Italic)
            {
                yeniStil &= ~FontStyle.Italic;
            }
            else
            {
                yeniStil |= FontStyle.Italic;
            }

            textBox1.Font = new Font(eskiFont, yeniStil);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font eskiFont = textBox1.Font;
            FontStyle yeniStil = eskiFont.Style;

            if (eskiFont.Underline)
            {
                yeniStil &= ~FontStyle.Underline;
            }
            else
            {
                yeniStil |= FontStyle.Underline;
            }

            textBox1.Font = new Font(eskiFont, yeniStil);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
    }
}
