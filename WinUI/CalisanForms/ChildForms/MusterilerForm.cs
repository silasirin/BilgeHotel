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
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }

        BaseRepository<MusteriBilgisi> musteriRepo = new BaseRepository<MusteriBilgisi>();

        private void MusteriListele()
        {
            listView1.Items.Clear();

            List<MusteriBilgisi> musteriler = musteriRepo.GetList();

            foreach (MusteriBilgisi musteri in musteriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = musteri.MusteriID.ToString();
                lvi.SubItems.Add(musteri.Ad.ToString());
                lvi.SubItems.Add(musteri.Soyad.ToString());
                lvi.SubItems.Add(musteri.TCKN.ToString());
                lvi.SubItems.Add(musteri.TelNo.ToString());
                lvi.SubItems.Add(musteri.Email.ToString());
                lvi.SubItems.Add(musteri.Sifre.ToString());


                listView1.Items.Add(lvi);

            }
        }
        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }
    }
}
