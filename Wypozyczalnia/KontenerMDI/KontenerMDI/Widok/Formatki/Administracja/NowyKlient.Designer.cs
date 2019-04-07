namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class NowyKlient
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
            this.TMiasto = new System.Windows.Forms.TextBox();
            this.TKodPocztowy = new System.Windows.Forms.TextBox();
            this.TUlica = new System.Windows.Forms.TextBox();
            this.TImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TNazwisko = new System.Windows.Forms.TextBox();
            this.DDataUrodzenia = new System.Windows.Forms.DateTimePicker();
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
            this.tableLayoutPanel1.Controls.Add(this.TMiasto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TKodPocztowy, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TUlica, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TImie, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TNazwisko, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DDataUrodzenia, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TMiasto
            // 
            this.TMiasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TMiasto.Location = new System.Drawing.Point(150, 133);
            this.TMiasto.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TMiasto.Name = "TMiasto";
            this.TMiasto.Size = new System.Drawing.Size(312, 20);
            this.TMiasto.TabIndex = 11;
            // 
            // TKodPocztowy
            // 
            this.TKodPocztowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TKodPocztowy.Location = new System.Drawing.Point(150, 107);
            this.TKodPocztowy.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TKodPocztowy.Name = "TKodPocztowy";
            this.TKodPocztowy.Size = new System.Drawing.Size(312, 20);
            this.TKodPocztowy.TabIndex = 10;
            // 
            // TUlica
            // 
            this.TUlica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TUlica.Location = new System.Drawing.Point(150, 81);
            this.TUlica.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TUlica.Name = "TUlica";
            this.TUlica.Size = new System.Drawing.Size(312, 20);
            this.TUlica.TabIndex = 9;
            // 
            // TImie
            // 
            this.TImie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TImie.Location = new System.Drawing.Point(150, 29);
            this.TImie.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TImie.Name = "TImie";
            this.TImie.Size = new System.Drawing.Size(312, 20);
            this.TImie.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwisko:";
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
            this.label2.Text = "Imie:";
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
            this.label3.Text = "Data urodzenia:";
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
            this.label4.Text = "Ulica:";
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
            this.label5.Text = "Kod pocztowy:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miasto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TNazwisko
            // 
            this.TNazwisko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TNazwisko.Location = new System.Drawing.Point(150, 3);
            this.TNazwisko.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TNazwisko.Name = "TNazwisko";
            this.TNazwisko.Size = new System.Drawing.Size(312, 20);
            this.TNazwisko.TabIndex = 6;
            // 
            // DDataUrodzenia
            // 
            this.DDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DDataUrodzenia.Location = new System.Drawing.Point(150, 55);
            this.DDataUrodzenia.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.DDataUrodzenia.Name = "DDataUrodzenia";
            this.DDataUrodzenia.Size = new System.Drawing.Size(84, 20);
            this.DDataUrodzenia.TabIndex = 12;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            this.error.RightToLeft = true;
            // 
            // BAnuluj
            // 
            this.BAnuluj.Location = new System.Drawing.Point(387, 159);
            this.BAnuluj.Name = "BAnuluj";
            this.BAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BAnuluj.TabIndex = 1;
            this.BAnuluj.Text = "Anuluj";
            this.BAnuluj.UseVisualStyleBackColor = true;
            this.BAnuluj.Click += new System.EventHandler(this.BAnuluj_Click);
            // 
            // BZapisz
            // 
            this.BZapisz.Location = new System.Drawing.Point(306, 159);
            this.BZapisz.Name = "BZapisz";
            this.BZapisz.Size = new System.Drawing.Size(75, 23);
            this.BZapisz.TabIndex = 2;
            this.BZapisz.Text = "Zapisz";
            this.BZapisz.UseVisualStyleBackColor = true;
            this.BZapisz.Click += new System.EventHandler(this.BZapisz_Click);
            // 
            // NowyKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 186);
            this.Controls.Add(this.BZapisz);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NowyKlient";
            this.Text = "NowyKlient";
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
        private System.Windows.Forms.TextBox TNazwisko;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox TMiasto;
        private System.Windows.Forms.TextBox TKodPocztowy;
        private System.Windows.Forms.TextBox TUlica;
        private System.Windows.Forms.TextBox TImie;
        private System.Windows.Forms.DateTimePicker DDataUrodzenia;
        private System.Windows.Forms.Button BZapisz;
        private System.Windows.Forms.Button BAnuluj;
    }
}