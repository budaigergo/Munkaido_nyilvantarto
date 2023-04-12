namespace Munkaido_nyilvantarto
{
    partial class FormFooldal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFooldal));
            this.pictureBoxMegtekintes = new System.Windows.Forms.PictureBox();
            this.pictureBoxFeljegyzes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxAlkalmazottszerkesztes = new System.Windows.Forms.PictureBox();
            this.buttonKijelentkezes = new System.Windows.Forms.Button();
            this.pictureBoxNapok = new System.Windows.Forms.PictureBox();
            this.labelJelenletOsszegzo = new System.Windows.Forms.Label();
            this.labelFizetesKezelese = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxFizetes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMegtekintes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeljegyzes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlkalmazottszerkesztes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNapok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMegtekintes
            // 
            this.pictureBoxMegtekintes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMegtekintes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMegtekintes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMegtekintes.Image")));
            this.pictureBoxMegtekintes.Location = new System.Drawing.Point(441, 270);
            this.pictureBoxMegtekintes.Name = "pictureBoxMegtekintes";
            this.pictureBoxMegtekintes.Size = new System.Drawing.Size(173, 148);
            this.pictureBoxMegtekintes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMegtekintes.TabIndex = 9;
            this.pictureBoxMegtekintes.TabStop = false;
            this.pictureBoxMegtekintes.Click += new System.EventHandler(this.pictureBoxMegtekintes_Click);
            // 
            // pictureBoxFeljegyzes
            // 
            this.pictureBoxFeljegyzes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFeljegyzes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFeljegyzes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFeljegyzes.Image")));
            this.pictureBoxFeljegyzes.Location = new System.Drawing.Point(774, 177);
            this.pictureBoxFeljegyzes.Name = "pictureBoxFeljegyzes";
            this.pictureBoxFeljegyzes.Size = new System.Drawing.Size(194, 153);
            this.pictureBoxFeljegyzes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFeljegyzes.TabIndex = 10;
            this.pictureBoxFeljegyzes.TabStop = false;
            this.pictureBoxFeljegyzes.Click += new System.EventHandler(this.pictureBoxJelenletFeljegyzese_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(779, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jelenlét feljegyzése";
            this.label1.Click += new System.EventHandler(this.labelJelenletFeljegyzese_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(390, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alkalmazottak megtekintése";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 150);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(885, 58);
            this.label5.TabIndex = 21;
            this.label5.Text = "MUNKAIDŐ NYILVÁNTARTÓ RENDSZER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(81, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alkalmazottak kezelése";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBoxAlkalmazottszerkesztes
            // 
            this.pictureBoxAlkalmazottszerkesztes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlkalmazottszerkesztes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlkalmazottszerkesztes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlkalmazottszerkesztes.Image")));
            this.pictureBoxAlkalmazottszerkesztes.Location = new System.Drawing.Point(91, 180);
            this.pictureBoxAlkalmazottszerkesztes.Name = "pictureBoxAlkalmazottszerkesztes";
            this.pictureBoxAlkalmazottszerkesztes.Size = new System.Drawing.Size(198, 150);
            this.pictureBoxAlkalmazottszerkesztes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlkalmazottszerkesztes.TabIndex = 13;
            this.pictureBoxAlkalmazottszerkesztes.TabStop = false;
            this.pictureBoxAlkalmazottszerkesztes.Click += new System.EventHandler(this.pictureBoxAlkalmazottszerkesztes_Click_1);
            // 
            // buttonKijelentkezes
            // 
            this.buttonKijelentkezes.BackColor = System.Drawing.Color.Red;
            this.buttonKijelentkezes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKijelentkezes.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonKijelentkezes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKijelentkezes.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKijelentkezes.ForeColor = System.Drawing.Color.White;
            this.buttonKijelentkezes.Location = new System.Drawing.Point(441, 513);
            this.buttonKijelentkezes.Name = "buttonKijelentkezes";
            this.buttonKijelentkezes.Size = new System.Drawing.Size(191, 46);
            this.buttonKijelentkezes.TabIndex = 20;
            this.buttonKijelentkezes.Text = "Kilépés";
            this.buttonKijelentkezes.UseVisualStyleBackColor = false;
            this.buttonKijelentkezes.Click += new System.EventHandler(this.buttonKijelentkezes_Click);
            // 
            // pictureBoxNapok
            // 
            this.pictureBoxNapok.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNapok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNapok.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNapok.Image")));
            this.pictureBoxNapok.Location = new System.Drawing.Point(94, 396);
            this.pictureBoxNapok.Name = "pictureBoxNapok";
            this.pictureBoxNapok.Size = new System.Drawing.Size(173, 140);
            this.pictureBoxNapok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNapok.TabIndex = 22;
            this.pictureBoxNapok.TabStop = false;
            this.pictureBoxNapok.Click += new System.EventHandler(this.pictureBoxJelenletOsszegzo_Click);
            // 
            // labelJelenletOsszegzo
            // 
            this.labelJelenletOsszegzo.AutoSize = true;
            this.labelJelenletOsszegzo.BackColor = System.Drawing.Color.Transparent;
            this.labelJelenletOsszegzo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelJelenletOsszegzo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJelenletOsszegzo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelJelenletOsszegzo.Location = new System.Drawing.Point(103, 375);
            this.labelJelenletOsszegzo.Name = "labelJelenletOsszegzo";
            this.labelJelenletOsszegzo.Size = new System.Drawing.Size(176, 28);
            this.labelJelenletOsszegzo.TabIndex = 24;
            this.labelJelenletOsszegzo.Text = "Jelenlét összegző";
            this.labelJelenletOsszegzo.Click += new System.EventHandler(this.labelJelenletOsszegzo_Click);
            // 
            // labelFizetesKezelese
            // 
            this.labelFizetesKezelese.AutoSize = true;
            this.labelFizetesKezelese.BackColor = System.Drawing.Color.Transparent;
            this.labelFizetesKezelese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFizetesKezelese.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFizetesKezelese.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelFizetesKezelese.Location = new System.Drawing.Point(802, 360);
            this.labelFizetesKezelese.Name = "labelFizetesKezelese";
            this.labelFizetesKezelese.Size = new System.Drawing.Size(166, 28);
            this.labelFizetesKezelese.TabIndex = 25;
            this.labelFizetesKezelese.Text = "Fizetés kezelése";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(1476, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "dfgdfgfdgfdg";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxFizetes
            // 
            this.pictureBoxFizetes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFizetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFizetes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFizetes.Image")));
            this.pictureBoxFizetes.Location = new System.Drawing.Point(795, 376);
            this.pictureBoxFizetes.Name = "pictureBoxFizetes";
            this.pictureBoxFizetes.Size = new System.Drawing.Size(173, 140);
            this.pictureBoxFizetes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFizetes.TabIndex = 23;
            this.pictureBoxFizetes.TabStop = false;
            this.pictureBoxFizetes.Click += new System.EventHandler(this.pictureBoxFizetes_Click_1);
            // 
            // FormFooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFizetesKezelese);
            this.Controls.Add(this.labelJelenletOsszegzo);
            this.Controls.Add(this.pictureBoxFizetes);
            this.Controls.Add(this.pictureBoxNapok);
            this.Controls.Add(this.buttonKijelentkezes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxAlkalmazottszerkesztes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFeljegyzes);
            this.Controls.Add(this.pictureBoxMegtekintes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormFooldal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Munkaidő nyilvántartó rendszer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fooldal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMegtekintes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeljegyzes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlkalmazottszerkesztes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNapok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFizetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMegtekintes;
        private System.Windows.Forms.PictureBox pictureBoxFeljegyzes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAlkalmazottszerkesztes;
        private System.Windows.Forms.Button buttonKijelentkezes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxNapok;
        private System.Windows.Forms.Label labelJelenletOsszegzo;
        private System.Windows.Forms.Label labelFizetesKezelese;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxFizetes;
    }
}

