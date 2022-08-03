using BLL.Repository;
using DAL.Context;
using DAL.Entity;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.ChildForms
{
    public partial class CalisanlarForm : Form
    {
        public CalisanlarForm()
        {
            InitializeComponent();
        }

        BaseRepository<Calisan> calisanRepo = new BaseRepository<Calisan>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.

        private void CalisanList()


        {
            listView1.Items.Clear();
            cmbVardiya.SelectedIndex = -1;
            cmbGorevTuru.SelectedIndex = -1;

            List<Calisan> calisanlar = calisanRepo.GetList();

            foreach (Calisan calisan in calisanlar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = calisan.CalisanID.ToString();
                lvi.SubItems.Add(calisan.CalisanAd);
                lvi.SubItems.Add(calisan.CalisanSoyad);
                lvi.SubItems.Add(calisan.Email.ToString());
                lvi.SubItems.Add(calisan.Sifre.ToString());
                lvi.SubItems.Add(calisan.Maas.ToString());
                lvi.SubItems.Add(calisan.Gorev.ToString());
                lvi.SubItems.Add(calisan.GorevTuru.ToString());
                lvi.SubItems.Add(calisan.CalismaSaati.ToString());
                lvi.SubItems.Add(calisan.Ucret.ToString());
                lvi.SubItems.Add(calisan.Vardiya.ToString());

                listView1.Items.Add(lvi);

            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            CalisanList();
        }


        private void CalisanlarForm_Load(object sender, EventArgs e)
        {
            List<Vardiya> vardiyalar = Enum.GetValues(typeof(Vardiya)).Cast<Vardiya>().ToList();
            cmbVardiya.DataSource = vardiyalar;

            List<GorevTuru> gorevler = Enum.GetValues(typeof(GorevTuru)).Cast<GorevTuru>().ToList();
            cmbGorevTuru.DataSource = gorevler;

            listView1.Items.Clear();
            cmbVardiya.SelectedIndex = -1;
            cmbGorevTuru.SelectedIndex = -1;
        }

        Calisan calisan = new Calisan();
        private void btnEkle_Click_1(object sender, EventArgs e)
        {

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtEmail.Text != "" && txtSifre.Text != "" && txtGorev.Text != "")
            {
                calisan.CalisanAd = txtAd.Text;
                calisan.CalisanSoyad = txtSoyad.Text;
                calisan.Email = txtEmail.Text;
                calisan.Sifre = txtSifre.Text;
                calisan.Gorev = txtGorev.Text;
                calisan.GorevTuru = (GorevTuru)cmbGorevTuru.SelectedIndex;
                calisan.CalismaSaati = Convert.ToInt32(nudCalismaSaati.Value);
                calisan.Ucret = Convert.ToInt32(nudSaatlikUcret.Value);
                //Enum'i getirmek icin casting yapilmali:
                calisan.Vardiya = (Vardiya)cmbVardiya.SelectedIndex;
            }
            if (txtMaas.Text != "")
            {
                calisan.Maas = Convert.ToInt32(txtMaas.Text);
            }



            string result = calisanRepo.Create(calisan);
            MessageBox.Show(result);
            CalisanList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtCalisanID.Text);

            Calisan guncellenen = calisanRepo.FindById(yakalananId);

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtEmail.Text != "" && txtSifre.Text != "" && txtGorev.Text != "")
            {
                guncellenen.CalisanAd = txtAd.Text;
                guncellenen.CalisanSoyad = txtSoyad.Text;
                guncellenen.Email = txtEmail.Text;
                guncellenen.Sifre = txtSifre.Text;
                guncellenen.Gorev = txtGorev.Text;
                guncellenen.GorevTuru = (GorevTuru)cmbGorevTuru.SelectedIndex;
                guncellenen.CalismaSaati = Convert.ToInt32(nudCalismaSaati.Value);
                guncellenen.Ucret = Convert.ToInt32(nudSaatlikUcret.Value);
                //Enum'i getirmek icin casting yapilmali:
                guncellenen.Vardiya = (Vardiya)cmbVardiya.SelectedIndex;
            }
            if (txtMaas.Text != "")
            {
                guncellenen.Maas = Convert.ToInt32(txtMaas.Text);
            }



            CalisanList();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtCalisanID.Text);
                yakalananId = Convert.ToInt32(txtCalisanID.Text);
                string result = calisanRepo.Delete(yakalananId);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            CalisanList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
