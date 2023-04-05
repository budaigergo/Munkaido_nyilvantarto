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
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
            buttonBelepes.FlatStyle = FlatStyle.Flat;
            buttonBelepes.FlatAppearance.BorderSize = 0;
            buttonMegse.FlatStyle = FlatStyle.Flat;
            buttonMegse.FlatAppearance.BorderSize = 0;
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
        
        private void buttonBelepes_Click(object sender, EventArgs e)
        {
            Database database=new Database();        
            string username = "";
            string password = "";

            database.comm.CommandText = "SELECT * FROM login WHERE 1";

            database.conn.Open();
            MySqlDataReader dr = database.comm.ExecuteReader();
            while (dr.Read()) {
                username = dr["username"].ToString();
                password = dr["password"].ToString();
            } 

            dr.Close();
            database.conn.Close();

            if (textBoxFelhasznalonev.Text == "")
            {
                MessageBox.Show("Nem adott meg felhasználónevet!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxFelhasznalonev.Text == username) 
            {
                if (textBoxJelszo.Text=="")
                {
                    MessageBox.Show("Nem adott meg jelszavat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (textBoxJelszo.Text==password)
                {
                    Program.Fooldal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hibás jelszó!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxJelszo.Text = "";
            textBoxFelhasznalonev.Text = "";
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
