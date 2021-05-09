using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kozmunka
{
    public partial class Form1 : Form
    {
        public static List<TanuloModel> tanulok;
        public static  SqlConnection connection;

        public Form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.Replace(@"bin\Debug", @"\")));
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Axmart\source\repos\kozmunka\kozmunka\kozmunkaDB.mdf;Integrated Security=True");


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void FillDgv()
        {

            dgv_tanulok.Rows.Clear();
            tanulok = new List<TanuloModel>();
            connection.Open();
            var result = new SqlCommand("Select * from gyak_tanulo", connection).ExecuteReader();
            while (result.Read())
            {
                dgv_tanulok.Rows.Add(result.GetInt32(0), result[1], result.GetInt32(2), result[3], result[4]);
                tanulok.Add(new TanuloModel() { Id = result.GetInt32(0), Nev = result.GetString(1), Evfolyam = result.GetInt32(2), Osztaly = result.GetString(3), Evismetlo = int.Parse(result.GetString(4)) });
            }
            result.Close();
            connection.Close();

        }

        private void dgv_tanulok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            int id = int.Parse(dgv_tanulok.Rows[e.RowIndex].Cells[0].Value.ToString());
            var tanulo = tanulok.Find(x => x.Id == id);
            var result = new SqlCommand($"Select * from gyak_munka WHERE tanuloId = {id}", connection).ExecuteReader();

            tb_Nev.Text = tanulo.Nev;
            tb_evfolyam.Text = tanulo.Evfolyam.ToString();
            tb_osztaly.Text = tanulo.Osztaly.ToString();
            cv_evismetlo.SelectedIndex = tanulo.Evismetlo;

            List<MunkaModel> munkak = new List<MunkaModel>();
            while (result.Read())
            {
                munkak.Add(new MunkaModel { Id = result.GetInt32(0), TanuloId = result.GetInt32(1), Szervezet = result.GetString(2), Megjegyzes = result.GetString(3), Mikor = result.GetDateTime(4), Oraszam = result.GetInt32(5) });
            }

            int orakSzama = 0;
            string szoveg = "";
            foreach (var munka in munkak)
            {
                szoveg += $"{munka.Szervezet} , {munka.Mikor:d} , {munka.Megjegyzes}\n";
                orakSzama += munka.Oraszam;

            }

            rtb_adatok.Text = szoveg;
            tb_teljesitettOrak.Text = orakSzama.ToString();
            tb_megvanAz50.Text = (orakSzama >= 50 ? "igen" : "nem");

            
            result.Close();
            connection.Close();


        }

        private void btn_adatmodositas_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dgv_tanulok.SelectedRows[0].Cells[0].Value.ToString());
            string nev = tb_Nev.Text;
            string evfolyam = tb_evfolyam.Text;
            string osztaly = tb_osztaly.Text;
            string evismetlo = cv_evismetlo.SelectedIndex.ToString();


            connection.Open();
            
            var updateCommand = new SqlCommand($"Update gyak_tanulo set nev = '{nev}' , evfolyam = {evfolyam}, osztaly = '{osztaly}', evismetlo= '{evismetlo}' where id = {Id}", connection).ExecuteNonQuery();

            connection.Close();


            FillDgv();
        }

        private void btn_ujTanulo_Click(object sender, EventArgs e)
        {
            var frm = new UjTanuloFrm(connection);
            frm.Show();


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            FillDgv();
        }
    }
}
