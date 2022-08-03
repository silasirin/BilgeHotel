using BLL.Repository;
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

namespace WinUI.ChildForms
{
    public partial class TatilForm : Form
    {
        public TatilForm()
        {
            InitializeComponent();
        }

        BaseRepository<TatilPaketi> tatilRepo = new BaseRepository<TatilPaketi>(); 

        private void TatilTipiListele()


        {
            listView1.Items.Clear();

            List<TatilPaketi> tatilPaketleri = tatilRepo.GetList();

            foreach (TatilPaketi tatilTipi in tatilPaketleri)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = tatilTipi.TatilPaketiID.ToString();
                lvi.SubItems.Add(tatilTipi.TatilTipi);
                lvi.SubItems.Add(tatilTipi.Fiyat.ToString());


                listView1.Items.Add(lvi);

            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            TatilTipiListele();
        }
        TatilPaketi tatilPaketi = new TatilPaketi();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTatilTipi.Text != "" && txtFiyat.Text != "")
            {
                tatilPaketi.TatilTipi = txtTatilTipi.Text;
                tatilPaketi.Fiyat = Convert.ToInt32(txtFiyat.Text);


            }

            else
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır!");
            }


            string result = tatilRepo.Create(tatilPaketi);
            MessageBox.Show(result);
            TatilTipiListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtTatilID.Text);

            TatilPaketi guncelle = tatilRepo.FindById(yakalananId);


            if (txtTatilTipi.Text != "" && txtFiyat.Text !="")
            {
                guncelle.TatilTipi = txtTatilTipi.Text;
                guncelle.Fiyat = Convert.ToInt32(txtFiyat.Text);
            }

            TatilTipiListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtTatilID.Text);
                yakalananId = Convert.ToInt32(txtTatilID.Text);
                string result = tatilRepo.Delete(yakalananId);
                MessageBox.Show("Veri silindi!");

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            TatilTipiListele();
        }
    }
}
