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

namespace Munkaido_nyilvantarto
{
    public partial class FormFizetes : Form
    {
        public FormFizetes()
        {
            InitializeComponent();
            listaupdate();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM";
            dateTimePicker1.ShowUpDown = true;
            buttonKilepes.FlatStyle= FlatStyle.Flat;
            buttonKilepes.FlatAppearance.BorderSize = 3;

        }

        private void FormFizetes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();

        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
            listBoxEmberek.SelectedItem= null;
            dateTimePicker1.Value = DateTime.Now;
            labelFizetes.Text = "";
            labelEvesFizetes.Text = "";
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


        private void listBoxEmberek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;

            }
            labelFizetes.Text = "0 Ft";
            Database database = new Database();
            Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
            database.comm.CommandText = "SELECT SUM(`Napifizetese`) AS ertek FROM `alkalmazottak_adatai`NATURAL JOIN jelenletiiv WHERE jelenletiiv.jelenlet='Megjelent' AND jelenletiiv.id=@id AND MONTH(jelenletiiv.datum)=@month AND YEAR(jelenletiiv.datum)=@year GROUP BY jelenletiiv.id;";
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
            database.comm.Parameters.AddWithValue("@month",dateTimePicker1.Value.Month);
            database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

            database.conn.Open();
            using(MySqlDataReader dr=database.comm.ExecuteReader())
            {
                while (dr.Read())
                {

                    labelFizetes.Text = dr.GetInt32("ertek").ToString("#,##0 Ft");


                }
                    

            }
            labelEvesFizetes.Text = "0 Ft";

            database.comm.CommandText = "SELECT SUM(`Napifizetese`) AS ertek FROM `alkalmazottak_adatai`NATURAL JOIN jelenletiiv WHERE jelenletiiv.jelenlet='Megjelent' AND jelenletiiv.id=@id AND YEAR(jelenletiiv.datum)=@year GROUP BY jelenletiiv.id;";
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
            database.comm.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
            database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);
            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {
                while (dr.Read())
                {

                    labelEvesFizetes.Text = dr.GetInt32("ertek").ToString("#,##0 Ft");


                }


            }


        }
            
        private void FormFizetes_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.Fooldal.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;

            }
            {
                labelFizetes.Text = "0 Ft";
                Database database = new Database();
                Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
                database.comm.CommandText = "SELECT SUM(`Napifizetese`) AS ertek FROM `alkalmazottak_adatai`NATURAL JOIN jelenletiiv WHERE jelenletiiv.jelenlet='Megjelent' AND jelenletiiv.id=@id AND MONTH(jelenletiiv.datum)=@month AND YEAR(jelenletiiv.datum)=@year GROUP BY jelenletiiv.id;";
                database.comm.Parameters.Clear();
                database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
                database.comm.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);

                database.conn.Open();
                using (MySqlDataReader dr = database.comm.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        labelFizetes.Text = dr.GetInt32("ertek").ToString("#,##0 Ft");


                    }


                }
                labelEvesFizetes.Text = "0 Ft";

                database.comm.CommandText = "SELECT SUM(`Napifizetese`) AS ertek FROM `alkalmazottak_adatai`NATURAL JOIN jelenletiiv WHERE jelenletiiv.jelenlet='Megjelent' AND jelenletiiv.id=@id AND YEAR(jelenletiiv.datum)=@year GROUP BY jelenletiiv.id;";
                database.comm.Parameters.Clear();
                database.comm.Parameters.AddWithValue("@id", kivalasztottalkalmazott.Id);
                database.comm.Parameters.AddWithValue("@month", dateTimePicker1.Value.Month);
                database.comm.Parameters.AddWithValue("@year", dateTimePicker1.Value.Year);
                using (MySqlDataReader dr = database.comm.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        labelEvesFizetes.Text = dr.GetInt32("ertek").ToString("#,##0 Ft");


                    }


                }


            }
        }


    }
}
