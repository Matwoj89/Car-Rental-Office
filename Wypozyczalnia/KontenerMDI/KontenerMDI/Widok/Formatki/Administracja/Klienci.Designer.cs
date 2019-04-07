namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    partial class Klienci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klienci));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BDodajOperatora = new System.Windows.Forms.ToolStripButton();
            this.BEdytujOperatora = new System.Windows.Forms.ToolStripButton();
            this.BUsunOperatora = new System.Windows.Forms.ToolStripButton();
            this.GListaOperatorow = new System.Windows.Forms.DataGridView();
            this.CNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDataUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GListaOperatorow)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDodajOperatora,
            this.BEdytujOperatora,
            this.BUsunOperatora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BDodajOperatora
            // 
            this.BDodajOperatora.Image = ((System.Drawing.Image)(resources.GetObject("BDodajOperatora.Image")));
            this.BDodajOperatora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BDodajOperatora.Name = "BDodajOperatora";
            this.BDodajOperatora.Size = new System.Drawing.Size(96, 22);
            this.BDodajOperatora.Text = "Dodaj klienta";
            this.BDodajOperatora.Click += new System.EventHandler(this.BDodajOperatora_Click);
            // 
            // BEdytujOperatora
            // 
            this.BEdytujOperatora.Image = ((System.Drawing.Image)(resources.GetObject("BEdytujOperatora.Image")));
            this.BEdytujOperatora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BEdytujOperatora.Name = "BEdytujOperatora";
            this.BEdytujOperatora.Size = new System.Drawing.Size(98, 22);
            this.BEdytujOperatora.Text = "Edytuj klienta";
            // 
            // BUsunOperatora
            // 
            this.BUsunOperatora.Image = ((System.Drawing.Image)(resources.GetObject("BUsunOperatora.Image")));
            this.BUsunOperatora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BUsunOperatora.Name = "BUsunOperatora";
            this.BUsunOperatora.Size = new System.Drawing.Size(92, 22);
            this.BUsunOperatora.Text = "Usuń klienta";
            // 
            // GListaOperatorow
            // 
            this.GListaOperatorow.AllowUserToAddRows = false;
            this.GListaOperatorow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GListaOperatorow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNazwisko,
            this.CImie,
            this.CDataUrodzenia,
            this.CMiasto});
            this.GListaOperatorow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GListaOperatorow.Location = new System.Drawing.Point(0, 25);
            this.GListaOperatorow.MultiSelect = false;
            this.GListaOperatorow.Name = "GListaOperatorow";
            this.GListaOperatorow.RowHeadersVisible = false;
            this.GListaOperatorow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GListaOperatorow.Size = new System.Drawing.Size(705, 369);
            this.GListaOperatorow.TabIndex = 1;
            // 
            // CNazwisko
            // 
            this.CNazwisko.FillWeight = 150F;
            this.CNazwisko.HeaderText = "Nazwisko";
            this.CNazwisko.Name = "CNazwisko";
            this.CNazwisko.Width = 150;
            // 
            // CImie
            // 
            this.CImie.HeaderText = "Imie";
            this.CImie.Name = "CImie";
            // 
            // CDataUrodzenia
            // 
            this.CDataUrodzenia.FillWeight = 130F;
            this.CDataUrodzenia.HeaderText = "Data urodzenia";
            this.CDataUrodzenia.Name = "CDataUrodzenia";
            this.CDataUrodzenia.Width = 130;
            // 
            // CMiasto
            // 
            this.CMiasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMiasto.HeaderText = "Miasto";
            this.CMiasto.Name = "CMiasto";
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 394);
            this.Controls.Add(this.GListaOperatorow);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GListaOperatorow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BDodajOperatora;
        private System.Windows.Forms.ToolStripButton BEdytujOperatora;
        private System.Windows.Forms.ToolStripButton BUsunOperatora;
        private System.Windows.Forms.DataGridView GListaOperatorow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDataUrodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMiasto;

    }
}