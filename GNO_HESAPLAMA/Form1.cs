using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNO_HESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float vize1, ortalama1, final1, kredi1, GNO1;
            float vize2, ortalama2, final2, kredi2, GNO2;
            float vize3, ortalama3, final3, kredi3, GNO3;
            float vize4, ortalama4, final4, kredi4, GNO4;
            float vize5, ortalama5, final5, kredi5, GNO5, topkr;
            float vize6, ortalama6, final6, kredi6, GNO6, GenelNot;

            vize1 = float.Parse(textBox1.Text);
            final1 = float.Parse(textBox7.Text);
            kredi1 = float.Parse(textBox13.Text);
            float vize11 = (vize1 * 40) / 100;
            float final11 = (final1 * 60) / 100;
            ortalama1 = vize11 + final11;
            GNO1 = kredi1 * ortalama1;
            listBox1.Items.Add($"Ders 1 ortalamasi {ortalama1}");

            vize2 = float.Parse(textBox2.Text);
            final2 = float.Parse(textBox8.Text);
            kredi2 = float.Parse(textBox14.Text);
            float vize22 = (vize2 * 40) / 100;
            float final22 = (final2 * 60) / 100;
            ortalama2 = vize22 + final22;
            GNO2 = kredi2 * ortalama2;
            listBox1.Items.Add($"Ders 2 ortalamasi {ortalama2}");

            vize3 = float.Parse(textBox3.Text);
            kredi3 = float.Parse(textBox15.Text);
            final3 = float.Parse(textBox9.Text);
            float vize33 = (vize3 * 40) / 100;
            float final33 = (final3 * 60) / 100;
            ortalama3 = vize33 + final33;
            GNO3 = kredi3 * ortalama3;
            listBox1.Items.Add($"Ders 3 ortalamasi {ortalama3}");

            vize4 = float.Parse(textBox4.Text);
            kredi4 = float.Parse(textBox16.Text);
            final4 = float.Parse(textBox10.Text);
            float vize44 = (vize4 * 40) / 100;
            float final44 = (final4 * 60) / 100;
            ortalama4 = vize44 + final44;
            GNO4 = kredi4 * ortalama4;
            listBox1.Items.Add($"Ders 4 ortalamasi {ortalama4}");

            vize5 = float.Parse(textBox5.Text);
            kredi5 = float.Parse(textBox17.Text);
            final5 = float.Parse(textBox11.Text);
            float vize55 = (vize5 * 40) / 100;
            float final55 = (final5 * 60) / 100;
            ortalama5 = vize55 + final55;
            GNO5 = kredi5 * ortalama5;
            listBox1.Items.Add($"Ders 5 ortalamasi {ortalama5}");

            vize6 = float.Parse(textBox6.Text);
            kredi6 = float.Parse(textBox18.Text);
            final6 = float.Parse(textBox12.Text);
            float vize66 = (vize6 * 40) / 100;
            float final66 = (final6 * 60) / 100;
            ortalama6 = vize66 + final66;
            GNO6 = kredi6 * ortalama6;
            listBox1.Items.Add($"Ders 6 ortalamasi {ortalama6}");

            topkr = kredi1 + kredi2 + kredi3 + kredi4 + kredi5 + kredi6;

            GenelNot = (GNO1 + GNO2 + GNO3 + GNO4 + GNO5 + GNO6) / topkr;
            listBox1.Items.Add($"Genel Not Ortalamasi:{GenelNot}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
