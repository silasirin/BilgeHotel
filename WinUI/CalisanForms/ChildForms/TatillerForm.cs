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
    public partial class TatillerForm : Form
    {
        public TatillerForm()
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
        private void TatillerForm_Load(object sender, EventArgs e)
        {
            TatilTipiListele();
        }
    }
}
