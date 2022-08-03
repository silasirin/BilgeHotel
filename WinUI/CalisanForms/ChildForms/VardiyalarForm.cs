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
    public partial class VardiyalarForm : Form
    {
        public VardiyalarForm()
        {
            InitializeComponent();
        }
        BaseRepository<Calisan> calisanRepo = new BaseRepository<Calisan>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.

        private void VardiyaListele()

        {

            List<Calisan> calisanlar = calisanRepo.GetList();

           
            foreach (Calisan calisan in calisanlar)
            {
                switch (calisan.GorevTuru)
                {
                    case DAL.Enums.GorevTuru.Yonetim:
                        break;
                    case DAL.Enums.GorevTuru.Calisan:
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = DateTime.Today.ToString();
                        lvi.SubItems.Add(calisan.CalisanID.ToString());
                        lvi.SubItems.Add(calisan.CalisanAd);
                        lvi.SubItems.Add(calisan.CalisanSoyad);
                        lvi.SubItems.Add(calisan.Gorev.ToString());
                        lvi.SubItems.Add(calisan.Vardiya.ToString());

                        listView1.Items.Add(lvi);
                        break;
                }               

            }
        }
        private void VardiyalarForm_Load(object sender, EventArgs e)
        {
            VardiyaListele();
        }
    }
}
