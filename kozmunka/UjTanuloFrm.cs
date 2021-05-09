using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kozmunka
{
    public partial class UjTanuloFrm : Form
    {
        private readonly SqlConnection _connection;
        public UjTanuloFrm(SqlConnection connection)
        {
            this._connection = connection;
            InitializeComponent();
        }

        private void btn_rogzit_Click(object sender, EventArgs e)
        {
            lbl_hiba.Text = "";
            if (tb_nev.Text.Trim().Length < 1)
            {
                lbl_hiba.Text += "Nem lehet a nev ures\n";
            }
            if (tb_nev.Text.Trim().Length > 30)
            {
                lbl_hiba.Text += "Nem lehet a nev hosszabb mint 30 karakter\n";
            }
            if (tb_osztaly.Text.Trim().Length < 1)
            {
                lbl_hiba.Text += "Nem lehet az osztaly ures\n";
            }
            if (tb_osztaly.Text.Trim().Length > 3)
            {
                lbl_hiba.Text += "Nem lehet az osztaly hosszabb mint 3 karakter\n";
            }

            if (lbl_hiba.Text == "")
            {

                string nev = tb_nev.Text;
                string evfolyam = cb_evfolyam.SelectedItem.ToString();
                string osztaly = tb_osztaly.Text;
                string evismetlo = cb_evismetlo.SelectedIndex.ToString();


                _connection.Open();

                var insertCommand = new SqlCommand($"Insert INTO gyak_tanulo(nev,evfolyam,osztaly,evismetlo) values ('{nev}',{evfolyam},'{osztaly}','{evismetlo}')", _connection).ExecuteNonQuery();

                _connection.Close();

                this.Close();


            }



        }
    }
}
