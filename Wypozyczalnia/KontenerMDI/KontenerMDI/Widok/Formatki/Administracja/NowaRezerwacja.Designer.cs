namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class NowaRezerwacja
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataZwrotu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataWypozyczenia = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.roofBagade = new System.Windows.Forms.CheckBox();
            this.gps = new System.Windows.Forms.CheckBox();
            this.childSeat = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.BAnuluj = new System.Windows.Forms.Button();
            this.BZapisz = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataZwrotu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DataWypozyczenia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.roofBagade, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.gps, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.childSeat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataZwrotu
            // 
            this.DataZwrotu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataZwrotu.Location = new System.Drawing.Point(150, 81);
            this.DataZwrotu.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.DataZwrotu.Name = "DataZwrotu";
            this.DataZwrotu.Size = new System.Drawing.Size(84, 20);
            this.DataZwrotu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klient:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data wypozyczenia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data zwrotu auta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "fotelik dla dziecka:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "bagażnik na rowery";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DataWypozyczenia
            // 
            this.DataWypozyczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataWypozyczenia.Location = new System.Drawing.Point(150, 55);
            this.DataWypozyczenia.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.DataWypozyczenia.Name = "DataWypozyczenia";
            this.DataWypozyczenia.Size = new System.Drawing.Size(84, 20);
            this.DataWypozyczenia.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "GPS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roofBagade
            // 
            this.roofBagade.AutoSize = true;
            this.roofBagade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roofBagade.Location = new System.Drawing.Point(133, 133);
            this.roofBagade.Name = "roofBagade";
            this.roofBagade.Size = new System.Drawing.Size(328, 18);
            this.roofBagade.TabIndex = 15;
            this.roofBagade.UseVisualStyleBackColor = true;
            // 
            // gps
            // 
            this.gps.AutoSize = true;
            this.gps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gps.Location = new System.Drawing.Point(133, 157);
            this.gps.Name = "gps";
            this.gps.Size = new System.Drawing.Size(328, 28);
            this.gps.TabIndex = 16;
            this.gps.UseVisualStyleBackColor = true;
            // 
            // childSeat
            // 
            this.childSeat.AutoSize = true;
            this.childSeat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.childSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childSeat.Location = new System.Drawing.Point(133, 107);
            this.childSeat.Name = "childSeat";
            this.childSeat.Size = new System.Drawing.Size(328, 20);
            this.childSeat.TabIndex = 14;
            this.childSeat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.childSeat.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            this.error.RightToLeft = true;
            // 
            // BAnuluj
            // 
            this.BAnuluj.Location = new System.Drawing.Point(386, 194);
            this.BAnuluj.Name = "BAnuluj";
            this.BAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BAnuluj.TabIndex = 1;
            this.BAnuluj.Text = "Anuluj";
            this.BAnuluj.UseVisualStyleBackColor = true;
            this.BAnuluj.Click += new System.EventHandler(this.BAnuluj_Click);
            // 
            // BZapisz
            // 
            this.BZapisz.Location = new System.Drawing.Point(305, 194);
            this.BZapisz.Name = "BZapisz";
            this.BZapisz.Size = new System.Drawing.Size(75, 23);
            this.BZapisz.TabIndex = 2;
            this.BZapisz.Text = "Zapisz";
            this.BZapisz.UseVisualStyleBackColor = true;
            this.BZapisz.Click += new System.EventHandler(this.BZapisz_Click);
            // 
            // NowaRezerwacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 229);
            this.Controls.Add(this.BZapisz);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NowaRezerwacja";
            this.Text = "Nowa Rezerwacja";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DateTimePicker DataWypozyczenia;
        private System.Windows.Forms.Button BZapisz;
        private System.Windows.Forms.Button BAnuluj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox roofBagade;
        private System.Windows.Forms.CheckBox gps;
        private System.Windows.Forms.CheckBox childSeat;
        private System.Windows.Forms.DateTimePicker DataZwrotu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

    }
}