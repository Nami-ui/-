using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OKO
{
    public partial class OKO : Form
    {
        public OKO()
        {
            InitializeComponent();
            CenterToScreen();
            //this.BackgroundImage = new Bitmap(@"G:\Cursovay\bgl.jpg");
            FillData();
        }

        //private void Pathe_Click(object sender, EventArgs e)
        //{
        //    DialogResult res = OFD.ShowDialog();
        //    if (res == DialogResult.OK)
        //    {
        //        Path.Text = OFD.FileName;
        //        Work.FilePath = OFD.FileName;
        //        FillData();
        //    }
        //}

        public void FillData()
        {
            Table.DataSource = null;
            //Table.DataSource = Work.Table();
            //Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string sqlCS = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\database\Database1.mdf;Integrated Security=True";
            SqlConnection sqlC = new SqlConnection(sqlCS);
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Hu.Fname 'Имя' , Hu.Mname 'Фамилия' , Hu.Lname 'Отчество' , Hu.Age 'Возраст' , P.NameJob 'Должность' , DP.NameDep 'Название депортамента',DP.Obl 'Область',DP.City 'Город',DP.Street 'Улица',DP.Home 'Дом' from Dep DP join Human Hu on DP.HumanId = Hu.id join Position P on P.HumanId = Hu.id",sqlC);
            try

            {

                sqlC.Open();

            }

            catch (SqlException exc)

            {

                MessageBox.Show(exc.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sqlDataAdapter.Fill(dataSet);
            Table.DataSource = dataSet.Tables[0].DefaultView;

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
