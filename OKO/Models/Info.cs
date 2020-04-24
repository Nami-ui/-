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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Info(int id)
        {
            InitializeComponent();
            CenterToScreen();
            this.BackgroundImage = new Bitmap(@"F:\\Cursovay\\bgf.jpg");
            Worker sup = new Worker(id);
            Ide.Text = id.ToString();
            FIOe.Text = sup.name;
            Agee.Text = sup.age.ToString();
            Workse.Text = sup.work;
            Arte.ImageLocation = sup.pic;
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            Work.AddUpd(Convert.ToInt32(Ide.Text), FIOe.Text, Convert.ToInt32(Agee.Text), Workse.Text, Arte.ToString());
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Work.Del(Convert.ToInt32(Ide.Text));
        }
    }
}
