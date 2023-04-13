namespace Munkaido_nyilvantarto
{
    partial class FormJelenlétÖsszegző
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJelenlétÖsszegző));
            this.listBoxEmberek = new System.Windows.Forms.ListBox();
            this.listBoxNapok = new System.Windows.Forms.ListBox();
            this.listBoxNapokOsszes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVissza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEmberek
            // 
            this.listBoxEmberek.BackColor = System.Drawing.Color.DarkCyan;
            this.listBoxEmberek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxEmberek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxEmberek.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxEmberek.ForeColor = System.Drawing.Color.White;
            this.listBoxEmberek.FormattingEnabled = true;
            this.listBoxEmberek.ItemHeight = 28;
            this.listBoxEmberek.Location = new System.Drawing.Point(26, 194);
            this.listBoxEmberek.Name = "listBoxEmberek";
            this.listBoxEmberek.Size = new System.Drawing.Size(250, 366);
            this.listBoxEmberek.TabIndex = 43;
            this.listBoxEmberek.SelectedIndexChanged += new System.EventHandler(this.listBoxEmberek_SelectedIndexChanged);
            // 
            // listBoxNapok
            // 
            this.listBoxNapok.BackColor = System.Drawing.Color.DarkCyan;
            this.listBoxNapok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxNapok.Cursor = System.Windows.Forms.Cursors.No;
            this.listBoxNapok.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxNapok.ForeColor = System.Drawing.Color.White;
            this.listBoxNapok.FormattingEnabled = true;
            this.listBoxNapok.ItemHeight = 28;
            this.listBoxNapok.Location = new System.Drawing.Point(356, 194);
            this.listBoxNapok.Name = "listBoxNapok";
            this.listBoxNapok.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxNapok.Size = new System.Drawing.Size(250, 366);
            this.listBoxNapok.TabIndex = 44;
            // 
            // listBoxNapokOsszes
            // 
            this.listBoxNapokOsszes.BackColor = System.Drawing.Color.DarkCyan;
            this.listBoxNapokOsszes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxNapokOsszes.Cursor = System.Windows.Forms.Cursors.No;
            this.listBoxNapokOsszes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxNapokOsszes.ForeColor = System.Drawing.Color.White;
            this.listBoxNapokOsszes.FormattingEnabled = true;
            this.listBoxNapokOsszes.ItemHeight = 28;
            this.listBoxNapokOsszes.Location = new System.Drawing.Point(686, 194);
            this.listBoxNapokOsszes.Name = "listBoxNapokOsszes";
            this.listBoxNapokOsszes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxNapokOsszes.Size = new System.Drawing.Size(250, 366);
            this.listBoxNapokOsszes.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(415, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Havi összegző";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(740, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Összes munkanap";
            // 
            // buttonVissza
            // 
            this.buttonVissza.BackColor = System.Drawing.Color.Red;
            this.buttonVissza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVissza.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonVissza.FlatAppearance.BorderSize = 3;
            this.buttonVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVissza.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonVissza.ForeColor = System.Drawing.Color.White;
            this.buttonVissza.Location = new System.Drawing.Point(408, 589);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(147, 55);
            this.buttonVissza.TabIndex = 47;
            this.buttonVissza.Text = "Vissza";
            this.buttonVissza.UseVisualStyleBackColor = false;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 102);
            this.panel1.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 35);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jelenlét összegző";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(885, 58);
            this.label5.TabIndex = 22;
            this.label5.Text = "MUNKAIDŐ NYILVÁNTARTÓ RENDSZER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.buttonReset.Location = new System.Drawing.Point(198, 158);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(31, 30);
            this.buttonReset.TabIndex = 54;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 30);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormJelenlétÖsszegző
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 656);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVissza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNapokOsszes);
            this.Controls.Add(this.listBoxNapok);
            this.Controls.Add(this.listBoxEmberek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormJelenlétÖsszegző";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlkalmazott_napjai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJelenlétÖsszegző_FormClosing);
            this.Load += new System.EventHandler(this.FormAlkalmazott_napjai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmberek;
        private System.Windows.Forms.ListBox listBoxNapok;
        private System.Windows.Forms.ListBox listBoxNapokOsszes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}