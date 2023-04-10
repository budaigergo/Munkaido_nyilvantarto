namespace Munkaido_nyilvantarto
{
    partial class FormJelenletFeljegyzese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJelenletFeljegyzese));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxDolgozok = new System.Windows.Forms.ListBox();
            this.buttonMegjelent = new System.Windows.Forms.Button();
            this.buttonFizetetthianyzas = new System.Windows.Forms.Button();
            this.buttonTappenz = new System.Windows.Forms.Button();
            this.buttonIgazolatlan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxOsszesKijelolese = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOsszesKijelolese)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 34);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 31, 0, 0, 0, 0);
            // 
            // listBoxDolgozok
            // 
            this.listBoxDolgozok.BackColor = System.Drawing.Color.DarkCyan;
            this.listBoxDolgozok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxDolgozok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBoxDolgozok.ForeColor = System.Drawing.Color.White;
            this.listBoxDolgozok.FormattingEnabled = true;
            this.listBoxDolgozok.ItemHeight = 29;
            this.listBoxDolgozok.Location = new System.Drawing.Point(82, 217);
            this.listBoxDolgozok.MultiColumn = true;
            this.listBoxDolgozok.Name = "listBoxDolgozok";
            this.listBoxDolgozok.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDolgozok.Size = new System.Drawing.Size(400, 584);
            this.listBoxDolgozok.TabIndex = 1;
            // 
            // buttonMegjelent
            // 
            this.buttonMegjelent.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonMegjelent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMegjelent.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonMegjelent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMegjelent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMegjelent.ForeColor = System.Drawing.Color.White;
            this.buttonMegjelent.Location = new System.Drawing.Point(612, 218);
            this.buttonMegjelent.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMegjelent.Name = "buttonMegjelent";
            this.buttonMegjelent.Size = new System.Drawing.Size(250, 75);
            this.buttonMegjelent.TabIndex = 2;
            this.buttonMegjelent.Text = "Megjelent";
            this.buttonMegjelent.UseVisualStyleBackColor = false;
            this.buttonMegjelent.Click += new System.EventHandler(this.buttonMegjelent_Click);
            // 
            // buttonFizetetthianyzas
            // 
            this.buttonFizetetthianyzas.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonFizetetthianyzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFizetetthianyzas.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonFizetetthianyzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFizetetthianyzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonFizetetthianyzas.ForeColor = System.Drawing.Color.White;
            this.buttonFizetetthianyzas.Location = new System.Drawing.Point(612, 444);
            this.buttonFizetetthianyzas.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFizetetthianyzas.Name = "buttonFizetetthianyzas";
            this.buttonFizetetthianyzas.Size = new System.Drawing.Size(250, 75);
            this.buttonFizetetthianyzas.TabIndex = 3;
            this.buttonFizetetthianyzas.Text = "Nem fizetett,igazolt távollét";
            this.buttonFizetetthianyzas.UseVisualStyleBackColor = false;
            this.buttonFizetetthianyzas.Click += new System.EventHandler(this.buttonHianyzas_Click);
            // 
            // buttonTappenz
            // 
            this.buttonTappenz.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonTappenz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTappenz.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonTappenz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTappenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTappenz.ForeColor = System.Drawing.Color.White;
            this.buttonTappenz.Location = new System.Drawing.Point(612, 331);
            this.buttonTappenz.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTappenz.Name = "buttonTappenz";
            this.buttonTappenz.Size = new System.Drawing.Size(250, 75);
            this.buttonTappenz.TabIndex = 4;
            this.buttonTappenz.Text = "Táppénz";
            this.buttonTappenz.UseVisualStyleBackColor = false;
            this.buttonTappenz.Click += new System.EventHandler(this.buttonTappenz_Click);
            // 
            // buttonIgazolatlan
            // 
            this.buttonIgazolatlan.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonIgazolatlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIgazolatlan.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonIgazolatlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgazolatlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonIgazolatlan.ForeColor = System.Drawing.Color.White;
            this.buttonIgazolatlan.Location = new System.Drawing.Point(612, 557);
            this.buttonIgazolatlan.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIgazolatlan.Name = "buttonIgazolatlan";
            this.buttonIgazolatlan.Size = new System.Drawing.Size(250, 75);
            this.buttonIgazolatlan.TabIndex = 21;
            this.buttonIgazolatlan.Text = "Igazolatlan távollét";
            this.buttonIgazolatlan.UseVisualStyleBackColor = false;
            this.buttonIgazolatlan.Click += new System.EventHandler(this.buttonIgazolatlan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 108);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jelenlét feljegyzése";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(885, 58);
            this.label5.TabIndex = 21;
            this.label5.Text = "MUNKAIDŐ NYILVÁNTARTÓ RENDSZER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(612, 735);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 65);
            this.button2.TabIndex = 25;
            this.button2.Text = "Vissza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReset.BackgroundImage")));
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonReset.Location = new System.Drawing.Point(281, 177);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(37, 34);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // pictureBoxOsszesKijelolese
            // 
            this.pictureBoxOsszesKijelolese.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBoxOsszesKijelolese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxOsszesKijelolese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOsszesKijelolese.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOsszesKijelolese.Image")));
            this.pictureBoxOsszesKijelolese.Location = new System.Drawing.Point(426, 227);
            this.pictureBoxOsszesKijelolese.Name = "pictureBoxOsszesKijelolese";
            this.pictureBoxOsszesKijelolese.Size = new System.Drawing.Size(45, 37);
            this.pictureBoxOsszesKijelolese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOsszesKijelolese.TabIndex = 26;
            this.pictureBoxOsszesKijelolese.TabStop = false;
            this.pictureBoxOsszesKijelolese.Click += new System.EventHandler(this.pictureBoxOsszesKijelolese_Click);
            // 
            // FormJelenletFeljegyzese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 845);
            this.Controls.Add(this.pictureBoxOsszesKijelolese);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonIgazolatlan);
            this.Controls.Add(this.buttonTappenz);
            this.Controls.Add(this.buttonFizetetthianyzas);
            this.Controls.Add(this.buttonMegjelent);
            this.Controls.Add(this.listBoxDolgozok);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormJelenletFeljegyzese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelenlét feljegyzése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJelenletFeljegyzese_FormClosing);
            this.Load += new System.EventHandler(this.JelenletFeljegyzese_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOsszesKijelolese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxDolgozok;
        private System.Windows.Forms.Button buttonMegjelent;
        private System.Windows.Forms.Button buttonFizetetthianyzas;
        private System.Windows.Forms.Button buttonTappenz;
        private System.Windows.Forms.Button buttonIgazolatlan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBoxOsszesKijelolese;
    }
}