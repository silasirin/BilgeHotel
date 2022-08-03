using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.CalisanForms;

namespace WinUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullanici.Text.ToLower() == "yonetim" && txtSifre.Text=="12345")
            {     
                YonetimForm adminForm = new YonetimForm();
                adminForm.Show();
                this.Hide();
            }
            else if (txtKullanici.Text.ToLower()=="calisan" && txtSifre.Text=="12345")
            {
                CalisanForm userForm = new CalisanForm();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgiler Yanlış");
            }
        }
    }
}
