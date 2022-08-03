using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.ChildForms;

namespace WinUI
{
    public partial class YonetimForm : Form
    {

        public YonetimForm()
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CalisanlarForm());
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MusteriForm());
        }

        private void tatilPaketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new TatilForm());
        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new OdaForm());
        }

        private void rezervasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RezervasyonForm());
        }
    }
}
