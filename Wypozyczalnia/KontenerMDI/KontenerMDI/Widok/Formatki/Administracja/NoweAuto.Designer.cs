namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class NoweAuto
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
            this.TNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TKod = new System.Windows.Forms.TextBox();
            this.BAnuluj = new System.Windows.Forms.Button();
            this.BZapisz = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TNazwa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TCena, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TKod, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 79);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TNazwa
            // 
            this.TNazwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TNazwa.Location = new System.Drawing.Point(150, 29);
            this.TNazwa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TNazwa.Name = "TNazwa";
            this.TNazwa.Size = new System.Drawing.Size(386, 20);
            this.TNazwa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kod:";
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
            this.label2.Text = "Nazwa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TCena
            // 
            this.TCena.DecimalPlaces = 2;
            this.TCena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TCena.Location = new System.Drawing.Point(150, 55);
            this.TCena.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TCena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TCena.Name = "TCena";
            this.TCena.Size = new System.Drawing.Size(61, 20);
            this.TCena.TabIndex = 7;
            this.TCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TKod
            // 
            this.TKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TKod.Location = new System.Drawing.Point(150, 3);
            this.TKod.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.TKod.Name = "TKod";
            this.TKod.Size = new System.Drawing.Size(386, 20);
            this.TKod.TabIndex = 6;
            // 
            // BAnuluj
            // 
            this.BAnuluj.Location = new System.Drawing.Point(452, 85);
            this.BAnuluj.Name = "BAnuluj";
            this.BAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BAnuluj.TabIndex = 5;
            this.BAnuluj.Text = "Anuluj";
            this.BAnuluj.UseVisualStyleBackColor = true;
            this.BAnuluj.Click += new System.EventHandler(this.BAnuluj_Click);
            // 
            // BZapisz
            // 
            this.BZapisz.Location = new System.Drawing.Point(371, 85);
            this.BZapisz.Name = "BZapisz";
            this.BZapisz.Size = new System.Drawing.Size(75, 23);
            this.BZapisz.TabIndex = 6;
            this.BZapisz.Text = "Zapisz";
            this.BZapisz.UseVisualStyleBackColor = true;
            this.BZapisz.Click += new System.EventHandler(this.BZapisz_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            this.error.RightToLeft = true;
            // 
            // NoweAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 112);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BAnuluj);
            this.Controls.Add(this.BZapisz);
            this.Name = "NoweAuto";
            this.Text = "Nowe Auto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TNazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TKod;
        private System.Windows.Forms.Button BAnuluj;
        private System.Windows.Forms.Button BZapisz;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.NumericUpDown TCena;
    }
}