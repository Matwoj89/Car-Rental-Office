namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class Auta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auta));
            this.GListaTowarow = new System.Windows.Forms.DataGridView();
            this.BUsunTowar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BDodajTowar = new System.Windows.Forms.ToolStripButton();
            this.BEdytujTowar = new System.Windows.Forms.ToolStripButton();
            this.CKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokalizacja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GListaTowarow)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GListaTowarow
            // 
            this.GListaTowarow.AllowUserToAddRows = false;
            this.GListaTowarow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GListaTowarow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CKod,
            this.CNazwa,
            this.CCena,
            this.Lokalizacja});
            this.GListaTowarow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GListaTowarow.Location = new System.Drawing.Point(0, 25);
            this.GListaTowarow.MultiSelect = false;
            this.GListaTowarow.Name = "GListaTowarow";
            this.GListaTowarow.RowHeadersVisible = false;
            this.GListaTowarow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GListaTowarow.Size = new System.Drawing.Size(554, 260);
            this.GListaTowarow.TabIndex = 3;
            this.GListaTowarow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GListaTowarow_CellContentClick);
            // 
            // BUsunTowar
            // 
            this.BUsunTowar.Image = ((System.Drawing.Image)(resources.GetObject("BUsunTowar.Image")));
            this.BUsunTowar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BUsunTowar.Name = "BUsunTowar";
            this.BUsunTowar.Size = new System.Drawing.Size(81, 22);
            this.BUsunTowar.Text = "Usuń auto";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDodajTowar,
            this.BEdytujTowar,
            this.BUsunTowar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(554, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BDodajTowar
            // 
            this.BDodajTowar.Image = ((System.Drawing.Image)(resources.GetObject("BDodajTowar.Image")));
            this.BDodajTowar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BDodajTowar.Name = "BDodajTowar";
            this.BDodajTowar.Size = new System.Drawing.Size(85, 22);
            this.BDodajTowar.Text = "Dodaj auto";
            this.BDodajTowar.Click += new System.EventHandler(this.BDodajTowar_Click);
            // 
            // BEdytujTowar
            // 
            this.BEdytujTowar.Image = ((System.Drawing.Image)(resources.GetObject("BEdytujTowar.Image")));
            this.BEdytujTowar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BEdytujTowar.Name = "BEdytujTowar";
            this.BEdytujTowar.Size = new System.Drawing.Size(87, 22);
            this.BEdytujTowar.Text = "Edytuj auto";
            // 
            // CKod
            // 
            this.CKod.FillWeight = 150F;
            this.CKod.HeaderText = "Kod";
            this.CKod.Name = "CKod";
            this.CKod.Width = 150;
            // 
            // CNazwa
            // 
            this.CNazwa.HeaderText = "Nazwa";
            this.CNazwa.Name = "CNazwa";
            // 
            // CCena
            // 
            this.CCena.FillWeight = 130F;
            this.CCena.HeaderText = "Cena";
            this.CCena.Name = "CCena";
            this.CCena.Width = 130;
            // 
            // Lokalizacja
            // 
            this.Lokalizacja.HeaderText = "Lokalizacja";
            this.Lokalizacja.Name = "Lokalizacja";
            // 
            // Auta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 285);
            this.Controls.Add(this.GListaTowarow);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Auta";
            this.Text = "Auta";
            ((System.ComponentModel.ISupportInitialize)(this.GListaTowarow)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GListaTowarow;
        private System.Windows.Forms.ToolStripButton BUsunTowar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BDodajTowar;
        private System.Windows.Forms.ToolStripButton BEdytujTowar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokalizacja;
    }
}