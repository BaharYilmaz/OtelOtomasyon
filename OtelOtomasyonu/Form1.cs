using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbBoxIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxListeILCE.Enabled = true;
            cmbBoxListeILCE.Items.Clear();
            if (cmbBoxListeIL.Text=="İzmir")
            {
                cmbBoxListeILCE.Items.Add("Alaçatı");
                cmbBoxListeILCE.Items.Add("Çeşme");
            }
            if(cmbBoxListeIL.Text == "Antalya")
            {
                cmbBoxListeILCE.Items.Add("Demre");
                cmbBoxListeILCE.Items.Add("Manavgat");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBoxListeIL.Enabled = false;
            cmbBoxListeILCE.Enabled = false;
            cmbBox_ilce.Enabled = false;
            cmbBox_gOtelILce.Enabled = true;




        }

        private void cmbBox_otelListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_otelListele.Text== "İl-İlçe")
            {
                cmbBoxListeIL.Enabled = true;
            }
        }

        private void cmbBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_ilce.Enabled = true;
            cmbBox_ilce.Items.Clear();
            if (cmbBox_il.Text == "İzmir")
            {
                cmbBox_ilce.Items.Add("Alaçatı");
                cmbBox_ilce.Items.Add("Çeşme");
            }
            if (cmbBox_il.Text == "Antalya")
            {
                cmbBox_ilce.Items.Add("Demre");
                cmbBox_ilce.Items.Add("Manavgat");
            }
        }

        private void cmbBox_gIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_gOtelILce.Enabled = true;
            cmbBox_gOtelILce.Items.Clear();
            if (cmbBox_gIL.Text == "İzmir")
            {
                cmbBox_gOtelILce.Items.Add("Alaçatı");
                cmbBox_gOtelILce.Items.Add("Çeşme");
            }
            if (cmbBox_gIL.Text == "Antalya")
            {
                cmbBox_gOtelILce.Items.Add("Demre");
                cmbBox_gOtelILce.Items.Add("Manavgat");
            }
        }
    }
}
