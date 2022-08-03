using BLL.Repository;
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
    public partial class OdaForm : Form
    {
        public OdaForm()
        {
            InitializeComponent();
        }

        BaseRepository<Oda> odaRepo = new BaseRepository<Oda>();

        private void OdaListele()


        {
            listView1.Items.Clear();
            cmbOdaDurumu.Items.Clear();

            List<Oda> odaTipleri = odaRepo.GetList();

            List<OdaDurumu> OdaDurumları = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            foreach (Oda oda in odaTipleri)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = oda.OdaID.ToString();
                lvi.SubItems.Add(oda.OdaTuru.ToString());
                lvi.SubItems.Add(oda.OdaDurumu.ToString());
                lvi.SubItems.Add(oda.OdaSayisi.ToString());
                lvi.SubItems.Add(oda.Fiyat.ToString());
                listView1.Items.Add(lvi);
            }


            foreach (OdaDurumu oda in OdaDurumları) //enum cmbye eklensin diye.
            {
                cmbOdaDurumu.Items.Add(oda.ToString());
                cmbOdaDurumu.Tag = oda;

            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OdaListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda();

            oda.OdaTuru = txtOdaTuru.Text;
            oda.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
            oda.OdaSayisi = Convert.ToInt32(nudOdaSayisi.Value);
            oda.Fiyat = Convert.ToInt32(txtFiyat.Text);


            string result = odaRepo.Create(oda);
            MessageBox.Show(result);

            OdaListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtOdaID.Text);

            Oda guncelle = odaRepo.FindById(yakalananId);


            if (txtOdaTuru.Text != "" && txtFiyat.Text != "")
            {
                guncelle.OdaTuru = txtOdaTuru.Text;
                guncelle.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                guncelle.Fiyat = Convert.ToInt32(txtFiyat.Text);

            }

            OdaListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtOdaID.Text);
                yakalananId = Convert.ToInt32(txtOdaID.Text);
                string result = odaRepo.Delete(yakalananId);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            OdaListele();
        }
    }
}
