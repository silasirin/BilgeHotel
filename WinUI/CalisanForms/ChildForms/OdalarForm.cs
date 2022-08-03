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

namespace WinUI.CalisanForms.ChildForms
{
    public partial class OdalarForm : Form
    {
        public OdalarForm()
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

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtOdaID.Text);

            Oda guncelle = odaRepo.FindById(yakalananId);


                guncelle.OdaTuru = txtOdaID.Text;
                guncelle.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;

            OdaListele();
        }

        private void OdalarForm_Load(object sender, EventArgs e)
        {
            OdaListele();
        }
    }
}
