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
    public partial class FrmHasil : Form
    {
        public FrmHasil()
        {
            InitializeComponent();
        }

        private void proses(int a, int b, string operasi, string tanda, float hasil)
        {
            listBox1.Items.Add(
                String.Format($"Hasil {operasi} dari {a} {tanda} {b} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)

               );
        }

        private void FrmHasil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmPerhitungan frmPerhitungan = new FrmPerhitungan();
            frmPerhitungan.Event += proses;
            frmPerhitungan.ShowDialog();
        
        }
    }
}
