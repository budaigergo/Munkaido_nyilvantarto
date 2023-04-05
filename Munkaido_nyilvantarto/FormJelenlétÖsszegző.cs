using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Munkaido_nyilvantarto
{
    public partial class FormJelenlétÖsszegző : Form
    {
        public FormJelenlétÖsszegző()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM";
            dateTimePicker1.ShowUpDown = true;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
        }
        private void buttonVissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
        }
        private void listaupdate()
        {
            Database database = new Database();
            listBoxEmberek.Items.Clear();
            database.comm.CommandText = "SELECT `Id`,`Nev`,`Nem`,`Szuletesidatum`,`Telefonszam`,`Napifizetese`,`Cim`,`Pozicio` FROM `alkalmazottak_adatai` WHERE `aktiv`='true'";
            database.conn.Open();

            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {
                while (dr.Read())
                {
                    Alkalmazott uj = new Alkalmazott(dr.GetString("Nev"), dr.GetInt32("Id"), dr.GetString("Nem"), dr.GetString("Cim"), dr.GetString("Pozicio"), dr.GetDateTime("Szuletesidatum"), dr.GetString("Telefonszam"), dr.GetInt32("Napifizetese"));
                    listBoxEmberek.Items.Add(uj);
                }
            }
            database.conn.Close();
        }
        private void FormAlkalmazott_napjai_Load(object sender, EventArgs e)
        {
            listaupdate();

        }
 

        private void buttonDateReset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }



        private void listBoxEmberek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;
            }
            listBoxNapok.Items.Clear();
            Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
            Database database = new Database();
            database.comm.CommandText = "SELECT `datum`,`jelenlet` FROM `jelenletiiv` WHERE `Id`=@id AND MONTH(datum)= @month AND YEAR(datum)= @year;";
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
            database.comm.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
            database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

            database.conn.Open();

            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {

                while (dr.Read())
                {
                    string jelenlet = dr.GetString("jelenlet");
                    string a = $"{dr.GetDateTime("datum").ToString("yyyy-MM-dd ddd")} {" - " + (jelenlet)}";
                    listBoxNapok.Items.Add(a);
                }


            }
            listBoxNapokOsszes.Items.Clear();

            database.comm.CommandText = "SELECT `datum`,`jelenlet` FROM `jelenletiiv` WHERE `Id`=@id;" ;
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {

                while (dr.Read())
                {
                    string jelenlet = dr.GetString("jelenlet");
                    string a = $"{dr.GetDateTime("datum").ToString("yyyy-MM-dd ddd")} {" - " + (jelenlet)}";
                    listBoxNapokOsszes.Items.Add(a);
                }


            }
            database.conn.Close();
        }

        private void FormJelenlétÖsszegző_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.Fooldal.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;

            }
            listBoxNapok.Items.Clear();
            Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
            Database database = new Database();
            database.comm.CommandText = "SELECT `datum`,`jelenlet` FROM `jelenletiiv` WHERE `Id`= @id AND MONTH(datum)= @month AND YEAR(datum)= @year;";
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
            database.comm.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
            database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

            database.conn.Open();

            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {

                while (dr.Read())
                {
                    string jelenlet = dr.GetString("jelenlet");
                    string a = $"{dr.GetDateTime("datum").ToString("yyyy-MM-dd ddd")} {" - " + (jelenlet)}";
                    listBoxNapok.Items.Add(a);
                }


            }
            database.conn.Close();
        }
    }
}
