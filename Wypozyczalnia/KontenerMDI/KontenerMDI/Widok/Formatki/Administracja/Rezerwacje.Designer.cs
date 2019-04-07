namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class Rezerwacje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezerwacje));
            this.GListaOperatorow = new System.Windows.Forms.DataGridView();
            this.CImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDataUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoofBagage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Childseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BDodajOperatora = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GListaOperatorow)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GListaOperatorow
            // 
            this.GListaOperatorow.AllowUserToAddRows = false;
            this.GListaOperatorow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GListaOperatorow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CImie,
            this.CDataUrodzenia,
            this.CMiasto,
            this.RoofBagage,
            this.Childseat,
            this.GPS});
            this.GListaOperatorow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GListaOperatorow.Location = new System.Drawing.Point(0, 25);
            this.GListaOperatorow.MultiSelect = false;
            this.GListaOperatorow.Name = "GListaOperatorow";
            this.GListaOperatorow.RowHeadersVisible = false;
            this.GListaOperatorow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GListaOperatorow.Size = new System.Drawing.Size(612, 297);
            this.GListaOperatorow.TabIndex = 2;
            this.GListaOperatorow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GListaOperatorow_CellContentClick);
            // 
            // CImie
            // 
            this.CImie.HeaderText = "Klient";
            this.CImie.Name = "CImie";
            // 
            // CDataUrodzenia
            // 
            this.CDataUrodzenia.FillWeight = 130F;
            this.CDataUrodzenia.HeaderText = "Auto";
            this.CDataUrodzenia.Name = "CDataUrodzenia";
            this.CDataUrodzenia.Width = 130;
            // 
            // CMiasto
            // 
            this.CMiasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMiasto.HeaderText = "Okres Wypożyczenia";
            this.CMiasto.Name = "CMiasto";
            // 
            // RoofBagage
            // 
            this.RoofBagage.HeaderText = "Bagażnik na rower";
            this.RoofBagage.Name = "RoofBagage";
            this.RoofBagage.Width = 70;
            // 
            // Childseat
            // 
            this.Childseat.HeaderText = "Fotelik dziecięcy";
            this.Childseat.Name = "Childseat";
            this.Childseat.Width = 70;
            // 
            // GPS
            // 
            this.GPS.HeaderText = "GPS";
            this.GPS.Name = "GPS";
            this.GPS.Width = 70;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDodajOperatora,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BDodajOperatora
            // 
            this.BDodajOperatora.Image = ((System.Drawing.Image)(resources.GetObject("BDodajOperatora.Image")));
            this.BDodajOperatora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BDodajOperatora.Name = "BDodajOperatora";
            this.BDodajOperatora.Size = new System.Drawing.Size(116, 22);
            this.BDodajOperatora.Text = "Dodaj rezerwacje";
            this.BDodajOperatora.Click += new System.EventHandler(this.BDodajOperatora_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton1.Text = "Usun Rezerwacje";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Rezerwacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 322);
            this.Controls.Add(this.GListaOperatorow);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Rezerwacje";
            this.Text = "Rezerwacja";
            ((System.ComponentModel.ISupportInitialize)(this.GListaOperatorow)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GListaOperatorow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDataUrodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoofBagage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Childseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BDodajOperatora;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}