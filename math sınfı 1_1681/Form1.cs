using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınfı_1_1681
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi =Convert.ToSingle(txtSayi.Text);//sayisal olarak texti çevirdik

            //işlemler
            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2); //txt içindeki sayının karesi (2. kuvveti)
            double sayıkarekok = Math.Sqrt(sayi);
            double sayıYukarıYuvarla = Math.Ceiling(sayi);
            double sayıAsagiYuvarla = Math.Floor(sayi);
            double sayıYuvarla = Math.Round(sayi);
            //round ,floor ,ceil
            




            //somuçları yazdır
            lblMutlak.Text = "sayının mutlak değeri :" + sayiMutlak.ToString();
            lblUst.Text = "sayının kuvveti :"+sayiUs.ToString();
            lblKok.Text ="sayının kar kökü :"+ sayıkarekok.ToString();
            lblYukariYuvarla.Text ="sayının Yukarı Yuvarla :" + sayıYukarıYuvarla.ToString();
            lblAsagıYuvarla.Text = "sayı Aşağı Yuvarla:" + sayıAsagiYuvarla.ToString();
            lblYuvarla.Text = "sayı Yuvarla:" + sayıYuvarla.ToString();


        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
