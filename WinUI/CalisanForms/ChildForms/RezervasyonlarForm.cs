using BLL.Repository;
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

namespace WinUI.CalisanForms.ChildForms
{
    public partial class RezervasyonlarForm : Form
    {
        public RezervasyonlarForm()
        {
            InitializeComponent();
        }

        BaseRepository<RezervasyonBilgisi> rezervasyonRepo = new BaseRepository<RezervasyonBilgisi>();
        private void RezervasyonListele()
        {
            listView1.Items.Clear();

            List<RezervasyonBilgisi> rezervasyonBilgileri = rezervasyonRepo.GetList();

            foreach (RezervasyonBilgisi rezervasyon in rezervasyonBilgileri)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = rezervasyon.RezervasyonID.ToString();
                lvi.SubItems.Add(rezervasyon.MusteriID.ToString());
                lvi.SubItems.Add(rezervasyon.RezervasyonTarihi.ToString());
                lvi.SubItems.Add(rezervasyon.KonaklamaBaslangic.ToString());
                lvi.SubItems.Add(rezervasyon.KonaklamaBitis.ToString());
                lvi.SubItems.Add(rezervasyon.GunSayisi.ToString());
                lvi.SubItems.Add(rezervasyon.TatilPaketiID.ToString());
                lvi.SubItems.Add(rezervasyon.OdaID.ToString());
                lvi.SubItems.Add(rezervasyon.ToplamFiyat.ToString());


                listView1.Items.Add(lvi);

            }
        }
        private void RezervasyonlarForm_Load(object sender, EventArgs e)
        {
            RezervasyonListele();
        }
    }
}
