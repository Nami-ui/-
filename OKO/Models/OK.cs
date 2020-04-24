using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKO
{
    public partial class OKO : Form
    {
        public OKO()
        {
            InitializeComponent();
            CenterToScreen();
            this.BackgroundImage = new Bitmap(@"F:\\Cursovay\\bgl.jpg");
        }

        private void Pathe_Click(object sender, EventArgs e)
        {
            DialogResult res = OFD.ShowDialog();
            if (res == DialogResult.OK)
            {
                Path.Text = OFD.FileName;
                Work.FilePath = OFD.FileName;
                FillData();
            }
        }

        public void FillData()
        {
            Table.DataSource = Work.Table();
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Info upd = new Info(Convert.ToInt32(Table.CurrentRow.Cells[0].Value));
            upd.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Info add = new Info(0);
            add.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
