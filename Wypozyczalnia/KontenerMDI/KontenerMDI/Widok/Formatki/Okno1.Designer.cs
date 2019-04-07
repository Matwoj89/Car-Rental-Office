namespace Wypozyczalnia.Widok.Formatki
{
    partial class Okno1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezerwacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracjaToolStripMenuItem
            // 
            this.administracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorzyToolStripMenuItem,
            this.towaryToolStripMenuItem,
            this.rezerwacjeToolStripMenuItem});
            this.administracjaToolStripMenuItem.Name = "administracjaToolStripMenuItem";
            this.administracjaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.administracjaToolStripMenuItem.Text = "Start";
            this.administracjaToolStripMenuItem.Click += new System.EventHandler(this.administracjaToolStripMenuItem_Click);
            // 
            // operatorzyToolStripMenuItem
            // 
            this.operatorzyToolStripMenuItem.Name = "operatorzyToolStripMenuItem";
            this.operatorzyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.operatorzyToolStripMenuItem.Text = "Klienci";
            this.operatorzyToolStripMenuItem.Click += new System.EventHandler(this.operatorzyToolStripMenuItem_Click);
            // 
            // towaryToolStripMenuItem
            // 
            this.towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            this.towaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.towaryToolStripMenuItem.Text = "Auta";
            this.towaryToolStripMenuItem.Click += new System.EventHandler(this.towaryToolStripMenuItem_Click);
            // 
            // rezerwacjeToolStripMenuItem
            // 
            this.rezerwacjeToolStripMenuItem.Name = "rezerwacjeToolStripMenuItem";
            this.rezerwacjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezerwacjeToolStripMenuItem.Text = "Rezerwacje";
            this.rezerwacjeToolStripMenuItem.Click += new System.EventHandler(this.rezerwacjeToolStripMenuItem_Click);
            // 
            // Okno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 392);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Okno1";
            this.Text = "Okno1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezerwacjeToolStripMenuItem;

    }
}