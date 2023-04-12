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
    public partial class FormMegtekintés : Form
    {
        public FormMegtekintés()
        {
            InitializeComponent();

        }
        private void clear()
        {
            textBoxCim.Text= string.Empty;
            textBoxFizetes.Text= string.Empty;
            textBoxId.Text= string.Empty;
            textBoxNem.Text= string.Empty;
            textBoxNev.Text= string.Empty;
            textBoxpozicio.Text= string.Empty;
            textBoxTelszam.Text = string.Empty;
            textBoxDate.Text= string.Empty;

         }

        private void Megtekintés_Load(object sender, EventArgs e)
        {
            listaupdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmberek.SelectedIndex < 0)
            {
                return;
            }

            Alkalmazott kivalasztottalkalmazott = (Alkalmazott)listBoxEmberek.SelectedItem;
            textBoxNev.Text = kivalasztottalkalmazott.Nev.ToString();
            textBoxCim.Text = kivalasztottalkalmazott.Cim.ToString();
            textBoxpozicio.Text = kivalasztottalkalmazott.Pozicio.ToString();
            textBoxNem.Text = kivalasztottalkalmazott.Nem.ToString();
            textBoxTelszam.Text = kivalasztottalkalmazott.Telefonszam.ToString();
            textBoxFizetes.Text = kivalasztottalkalmazott.Napifizetese.ToString();
            textBoxId.Text = kivalasztottalkalmazott.Id.ToString();
            textBoxDate.Text = kivalasztottalkalmazott.Szuletesidatum.ToString("d");

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

        private void FormMegtekintés_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.Fooldal.Show();
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fooldal.Show();
            clear();
        }




    }
}
