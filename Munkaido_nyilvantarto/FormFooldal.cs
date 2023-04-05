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
    public partial class FormFooldal : Form
    {
        public FormFooldal()
        {
            InitializeComponent();
            buttonKijelentkezes.FlatStyle = FlatStyle.Flat;
            buttonKijelentkezes.FlatAppearance.BorderSize = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBoxAlkalmazottszerkesztes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.Alkalmazottak_kezelese.Show();
        }



        private void Fooldal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBoxMegtekintes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Megtekintés.Show();

        }

        private void pictureBoxJelenletFeljegyzese_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.JelenletFeljegyzese.Show();

        }



        private void buttonKijelentkezes_Click(object sender, EventArgs e)
        {
            Program.Login.textBoxJelszo.Text = "";
            Program.Login.textBoxFelhasznalonev.Text = "";
            this.Hide();
            Program.Login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Alkalmazottak_kezelese.Show();

        }

        private void pictureBoxJelenletOsszegzo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.JelenletOsszegzo.Show();  
        }

        private void labelJelenletFeljegyzese_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.JelenletFeljegyzese.Show();
        }

        private void labelJelenletOsszegzo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.JelenletOsszegzo.Show();
        }

        private void pictureBoxFizetes_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxFizetes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.Fizetes.Show();
        }


    }
}
