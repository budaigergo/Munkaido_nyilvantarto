using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Munkaido_nyilvantarto
{
    public partial class Alkalmazottak_kezelese : Form
    {
        public Alkalmazottak_kezelese()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBoxCim.Text = string.Empty;
            textBoxFizetese.Text = string.Empty;
            textBoxId.Text = string.Empty;
            textBoxNev.Text = string.Empty;
            textBoxPozicio.Text = string.Empty;
            textBoxTelefonszam.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;   
            comboBoxNem.Text = string.Empty;
        }

        private void Alkalmazottak_szerkesztese_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.Fooldal.Show();
            listBoxEmberek.SelectedItem = null;
            clear();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
        }
        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
            listBoxEmberek.SelectedItem = null;
            clear();
        }



        private void Alkalmazottak_kezelese_Load(object sender, EventArgs e)
        {
            listaupdate();
        }

        private void listBoxEmberek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;
            }

            Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
            textBoxNev.Text = kivalasztottalkalmazott.Nev.ToString();
            textBoxCim.Text = kivalasztottalkalmazott.Cim.ToString();
            textBoxPozicio.Text = kivalasztottalkalmazott.Pozicio.ToString();
            comboBoxNem.Text = kivalasztottalkalmazott.Nem.ToString();
            textBoxTelefonszam.Text = kivalasztottalkalmazott.Telefonszam.ToString();
            textBoxFizetese.Text = kivalasztottalkalmazott.Napifizetese.ToString();
            textBoxId.Text = kivalasztottalkalmazott.Id.ToString();
            dateTimePicker1.Text = kivalasztottalkalmazott.Szuletesidatum.ToString();


        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {

            Database database = new Database();
            database.comm.CommandText = "UPDATE `alkalmazottak_adatai` SET `aktiv`= 'false' WHERE `Id`=@id";
            database.comm.Parameters.AddWithValue("@id", textBoxId.Text);
            database.conn.Open();   

            if (listBoxEmberek.SelectedIndex > 0)
            {
                database.comm.ExecuteNonQuery();
                MessageBox.Show("Sikeres törlés!");
                clear();

            }
            else
            {
                MessageBox.Show("Nem választott törölni kívánt alkalmazottat!");

            }
            database.conn.Close();
            listaupdate();

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

        private void buttoSzerkesztes_Click(object sender, EventArgs e)
        {
            listaupdate();
            Database database = new Database();
            database.comm.CommandText = "UPDATE `alkalmazottak_adatai` SET `Nev`= @nev,`Cim`= @cim,`Nem`= @nem,`Pozicio`= @pozicio,`Szuletesidatum`= @szuletes,`Telefonszam`= @telefonszam,`Napifizetese`= @napifizetes WHERE `Id`=@id";
            database.comm.Parameters.Clear();
            database.comm.Parameters.AddWithValue("@nev", textBoxNev.Text);
            database.comm.Parameters.AddWithValue("@id", textBoxId.Text);
            database.comm.Parameters.AddWithValue("@nem", comboBoxNem.Text);
            database.comm.Parameters.AddWithValue("@cim ", textBoxCim.Text);
            database.comm.Parameters.AddWithValue("@pozicio", textBoxPozicio.Text);
            database.comm.Parameters.AddWithValue("@szuletes", dateTimePicker1.Value);
            database.comm.Parameters.AddWithValue("@telefonszam", textBoxTelefonszam.Text);
            database.comm.Parameters.AddWithValue("@napifizetes", textBoxFizetese.Text);

            database.conn.Open();
            if (database.comm.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                database.conn.Close();
                clear();
                listaupdate();
            }
            else
            {
                MessageBox.Show("Nem jelölt ki alkalmazottat!");
            }
            if (database.conn.State == ConnectionState.Open)
            {
                database.conn.Close();
            }

        }



        private void buttonHozzaadas_Click_1(object sender, EventArgs e)
        {
            Database database = new Database();
            database.conn.Open();
            database.comm.CommandText = "INSERT INTO `alkalmazottak_adatai` (`Id`, `Nev`, `Cim`, `Nem`, `Pozicio`, `Szuletesidatum`, `Telefonszam`, `Napifizetese`) VALUES " +
                "(Null, @nev, @cim, @nem, @pozicio, @szuletes, @telefonszam, @napifizetes);";
            database.comm.Parameters.AddWithValue("@nev", textBoxNev.Text); 
            database.comm.Parameters.AddWithValue("@nem", comboBoxNem.Text);
            database.comm.Parameters.AddWithValue("@cim", textBoxCim.Text);
            database.comm.Parameters.AddWithValue("@pozicio", textBoxPozicio.Text);
            database.comm.Parameters.AddWithValue("@szuletes", dateTimePicker1.Value);
            database.comm.Parameters.AddWithValue("@telefonszam", textBoxTelefonszam.Text);
            database.comm.Parameters.AddWithValue("@napifizetes", textBoxFizetese.Text);
            database.comm.ExecuteNonQuery();
            database.conn.Close();
            MessageBox.Show("Sikeres hozzáadás");
            clear();
            listaupdate();
        }
    }
}

