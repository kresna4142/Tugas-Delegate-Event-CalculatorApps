using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculatorApps
{
    public partial class FrmPerhitungan : Form
    {
        public delegate void Proses(int a, int b, string operasi, string tanda, float hasil);
        public event Proses Event;
        public FrmPerhitungan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPerhitungan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operasi operasi1 = new Operasi();
         int a = int.Parse(txtNilaiA.Text);
         int b = Convert.ToInt32(txtNilaiB.Text);
            string operasi, tanda;
            float hasil;
            if (comboBox1.Text == "Penjumlahan")
            {
                hasil = operasi1.Penjumlahan(a, b);
                operasi = "Penjumlahan";
                tanda = "+";
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                hasil = operasi1.Pengurangan(a,b);
                operasi = "Pengurangan";
                tanda = "-";
            }
            else if (comboBox1.Text == "Perkalian")
            {
                hasil = operasi1.Perkalian(a, b);
                operasi = "Perkalian";
                tanda = "x";
            }
            else
            {
                hasil = operasi1.Pembagian(a, b);
                operasi = "Pembagian";
                tanda = "/";

            }

            Event(a, b, operasi, tanda, hasil);
        }
    }
}      