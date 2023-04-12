namespace Munkaido_nyilvantarto
{
    partial class FormFizetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFizetes));
            this.listBoxEmberek = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFizetes = new System.Windows.Forms.Label();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEvesFizetes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEmberek
            // 
            this.listBoxEmberek.BackColor = System.Drawing.Color.DarkCyan;
            this.listBoxEmberek.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxEmberek.ForeColor = System.Drawing.Color.White;
            this.listBoxEmberek.FormattingEnabled = true;
            this.listBoxEmberek.ItemHeight = 28;
            this.listBoxEmberek.Location = new System.Drawing.Point(13, 169);
            this.listBoxEmberek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEmberek.Name = "listBoxEmberek";
            this.listBoxEmberek.Size = new System.Drawing.Size(359, 396);
            this.listBoxEmberek.TabIndex = 0;
            this.listBoxEmberek.SelectedIndexChanged += new System.EventHandler(this.listBoxEmberek_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "A kiválasztott alkalmazott\r\nfizetése a kijelölt hónapban";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Size = new System.Drawing.Size(780, 97);
            this.panel1.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(335, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 35);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fizetés kezelése";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(885, 58);
            this.label5.TabIndex = 22;
            this.label5.Text = "MUNKAIDŐ NYILVÁNTARTÓ RENDSZER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFizetes
            // 
            this.labelFizetes.AutoSize = true;
            this.labelFizetes.BackColor = System.Drawing.Color.Transparent;
            this.labelFizetes.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFizetes.ForeColor = System.Drawing.Color.White;
            this.labelFizetes.Location = new System.Drawing.Point(531, 226);
            this.labelFizetes.Name = "labelFizetes";
            this.labelFizetes.Size = new System.Drawing.Size(0, 35);
            this.labelFizetes.TabIndex = 24;
            this.labelFizetes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.BackColor = System.Drawing.Color.Red;
            this.buttonKilepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKilepes.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonKilepes.FlatAppearance.BorderSize = 3;
            this.buttonKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKilepes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.buttonKilepes.ForeColor = System.Drawing.Color.White;
            this.buttonKilepes.Location = new System.Drawing.Point(467, 497);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(190, 52);
            this.buttonKilepes.TabIndex = 55;
            this.buttonKilepes.Text = "Vissza";
            this.buttonKilepes.UseVisualStyleBackColor = false;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(468, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 56);
            this.label2.TabIndex = 56;
            this.label2.Text = "A kiválasztott alkalmazott\r\nfizetése a kijelölt évben";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelEvesFizetes
            // 
            this.labelEvesFizetes.AutoSize = true;
            this.labelEvesFizetes.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEvesFizetes.ForeColor = System.Drawing.Color.White;
            this.labelEvesFizetes.Location = new System.Drawing.Point(531, 382);
            this.labelEvesFizetes.Name = "labelEvesFizetes";
            this.labelEvesFizetes.Size = new System.Drawing.Size(0, 35);
            this.labelEvesFizetes.TabIndex = 57;
            this.labelEvesFizetes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormFizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(780, 594);
            this.Controls.Add(this.labelEvesFizetes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.labelFizetes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxEmberek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFizetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fizetés kezelése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFizetes_FormClosing_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmberek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFizetes;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEvesFizetes;
    }
}