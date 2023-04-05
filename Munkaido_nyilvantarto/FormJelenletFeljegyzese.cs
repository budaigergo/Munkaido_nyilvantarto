using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munkaido_nyilvantarto
{
    public partial class FormJelenletFeljegyzese : Form
    {
        bool selectedAll = false;
        public FormJelenletFeljegyzese()
        {
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true;
            buttonMegjelent.FlatStyle = FlatStyle.Flat;
            buttonMegjelent.FlatAppearance.BorderSize =3;
            buttonTappenz.FlatStyle = FlatStyle.Flat;
            buttonTappenz.FlatAppearance.BorderSize = 3;
            buttonFizetetthianyzas.FlatStyle = FlatStyle.Flat;
            buttonFizetetthianyzas.FlatAppearance.BorderSize = 3;
            buttonIgazolatlan.FlatStyle = FlatStyle.Flat;
            buttonIgazolatlan.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 2;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;

        }




        //Listbox feltöltése
        private void JelenletFeljegyzese_Load(object sender, EventArgs e)
        {
            listBoxDolgozok.Items.Clear();
            Database database = new Database();
            database.comm.CommandText = "SELECT `Id`,`Nev`,`Nem`,`Szuletesidatum`,`Telefonszam`,`Napifizetese`,`Cim`,`Pozicio` FROM `alkalmazottak_adatai` WHERE `aktiv`='true'";
            database.conn.Open();

            using (MySqlDataReader dr = database.comm.ExecuteReader())
            {
                while (dr.Read())
                {
                    Alkalmazott uj = new Alkalmazott(dr.GetString("Nev"), dr.GetInt32("Id"), dr.GetString("Nem"), dr.GetString("Cim"), dr.GetString("Pozicio"), dr.GetDateTime("Szuletesidatum"), dr.GetString("Telefonszam"), dr.GetInt32("Napifizetese"));
                    listBoxDolgozok.Items.Add(uj);
                }
            }
            database.conn.Close();
        }



        //"Megjelent" eltárolása
        private void buttonMegjelent_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.comm.CommandText = "INSERT INTO `jelenletiiv` (`Id`, `datum`, `jelenlet`) VALUES ";
            string values = "";
            foreach (var item in listBoxDolgozok.SelectedItems)
            {
                Alkalmazott uj = (Alkalmazott)item; 
                values += (values.Length == 0 ? "" : ",") + $"({uj.Id}, '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', 'Megjelent')";

            }
            database.comm.CommandText += values;

            database.comm.Parameters.Clear();   
            database.comm.Parameters.AddWithValue("Datum", dateTimePicker1.Text);

            database.conn.Open();
            if (listBoxDolgozok.SelectedIndex<0)
            {
                MessageBox.Show("Nem jelölt ki alkalmazottat!");
            }
            else
            {
                
                try {
                     
                    database.comm.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés");
                    listBoxDolgozok.SelectedItems.Clear();
                } catch (MySqlException ex)  {
                    if (ex.Number==1062)
                    {
                        MessageBox.Show("A megadott dátumra már van lementve kijelölt alkalmazott!");
                    }
                    else 
                    {   MessageBox.Show(ex.Message);

                    }
                
                } finally { database.conn.Close(); }

               


            }
        }


        //"Táppénz" eltárolása
        private void buttonTappenz_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.comm.CommandText = "INSERT INTO `jelenletiiv` (`Id`, `datum`, `jelenlet`) VALUES ";
            string values = "";
            foreach (var item in listBoxDolgozok.SelectedItems)
            {
                Alkalmazott uj = (Alkalmazott)item;
                values += (values.Length == 0 ? "" : ",") + $"({uj.Id}, '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', 'Táppénz')";

            }
            database.comm.CommandText += values;

            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("Datum", dateTimePicker1.Text);

            database.conn.Open();
            if (listBoxDolgozok.SelectedIndex < 0)
            {
                MessageBox.Show("Nem jelölt ki alkalmazottat!");
            }
            else
            {
                try
                {
                    database.comm.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés");
                    listBoxDolgozok.SelectedItems.Clear();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("A megadott dátumra már van lementve kijelölt alkalmazott!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                { database.conn.Close();

                }


            }

        }


        //"Hiányzás" eltárolása
        private void buttonHianyzas_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.comm.CommandText = "INSERT INTO `jelenletiiv` (`Id`, `datum`, `jelenlet`) VALUES ";
            string values = "";
            foreach (var item in listBoxDolgozok.SelectedItems)
            {
                Alkalmazott uj = (Alkalmazott)item;
                values += (values.Length == 0 ? "" : ",") + $"({uj.Id}, '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', 'Nem fizetett,igazolt távollét')";

            }
            database.comm.CommandText += values;

            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("Datum", dateTimePicker1.Text);

            database.conn.Open();
            if (listBoxDolgozok.SelectedIndex < 0)
            {
                MessageBox.Show("Nem jelölt ki alkalmazottat!");
            }
            else
            {
                try
                { 
                    database.comm.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés");
                    listBoxDolgozok.SelectedItems.Clear();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("A megadott dátumra már van lementve kijelölt alkalmazott!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                finally { database.conn.Close(); }

            }

        }
        //"Igazolatlan" eltárolása
        private void buttonIgazolatlan_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.comm.CommandText = "INSERT INTO `jelenletiiv` (`Id`, `datum`, `jelenlet`) VALUES ";
            string values = "";
            foreach (var item in listBoxDolgozok.SelectedItems)
            {
                Alkalmazott uj = (Alkalmazott)item;
                values += (values.Length == 0 ? "" : ",") + $"({uj.Id}, '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', 'Igazolatlan távollét')";

            }
            database.comm.CommandText += values;

            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("Datum", dateTimePicker1.Text);

            database.conn.Open();
            if (listBoxDolgozok.SelectedIndex < 0)
            {
                MessageBox.Show("Nem jelölt ki alkalmazottat!");
            }
            else
            {
                try
                {
                     
                    database.comm.ExecuteNonQuery();
                    MessageBox.Show("Sikeres mentés");
                    listBoxDolgozok.SelectedItems.Clear();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("A megadott dátumra már van lementve kijelölt alkalmazott!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                finally { database.conn.Close(); }


            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value= DateTime.Now;    
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
        }


        private void pictureBoxOsszesKijelolese_Click(object sender, EventArgs e)
        {
            if (!selectedAll)
            {
                for (int i = 0; i < listBoxDolgozok.Items.Count; i++)
                {
                    listBoxDolgozok.SetSelected(i, true);
                    selectedAll = true;
                }
            }
            else
            {
                for (int i = 0; i < listBoxDolgozok.Items.Count; i++)
                {
                    listBoxDolgozok.SetSelected(i, false);
                    selectedAll = false;
                }
            }
            

        }

        private void FormJelenletFeljegyzese_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.Fooldal.Show();
        }
    }
}