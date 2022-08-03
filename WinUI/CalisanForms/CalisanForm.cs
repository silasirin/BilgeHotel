using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.CalisanForms.ChildForms;

namespace WinUI.CalisanForms
{
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {
            InitializeComponent();
        }
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();

            }

        }
        private void vardiyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new VardiyalarForm());
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new OdalarForm());
        }

        private void tatilPaketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new TatillerForm());
        }

        private void müşterilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childForm(new MusterilerForm());
        }

        private void rezervasyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RezervasyonlarForm());
        }
    }
}
