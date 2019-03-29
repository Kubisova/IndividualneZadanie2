namespace FinishLine
{
    partial class FrmView
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
            this.nastaveniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretekáriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.načítajZoSúboruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložDoSúboruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.lblEnterRacerNumber = new System.Windows.Forms.Label();
            this.txtRacerNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.nastaveniaToolStripMenuItem,
            this.pretekáriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveniaToolStripMenuItem
            // 
            this.nastaveniaToolStripMenuItem.Name = "nastaveniaToolStripMenuItem";
            this.nastaveniaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.nastaveniaToolStripMenuItem.Text = "Nastavenia";
            // 
            // pretekáriToolStripMenuItem
            // 
            this.pretekáriToolStripMenuItem.Name = "pretekáriToolStripMenuItem";
            this.pretekáriToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pretekáriToolStripMenuItem.Text = "Pretekári";
            this.pretekáriToolStripMenuItem.Click += new System.EventHandler(this.pretekáriToolStripMenuItem_Click);
            // 
            // súborToolStripMenuItem
            // 
            this.súborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.načítajZoSúboruToolStripMenuItem,
            this.uložDoSúboruToolStripMenuItem});
            this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            this.súborToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.súborToolStripMenuItem.Text = "Súbor";
            // 
            // načítajZoSúboruToolStripMenuItem
            // 
            this.načítajZoSúboruToolStripMenuItem.Name = "načítajZoSúboruToolStripMenuItem";
            this.načítajZoSúboruToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.načítajZoSúboruToolStripMenuItem.Text = "Načítaj zo súboru";
            // 
            // uložDoSúboruToolStripMenuItem
            // 
            this.uložDoSúboruToolStripMenuItem.Name = "uložDoSúboruToolStripMenuItem";
            this.uložDoSúboruToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.uložDoSúboruToolStripMenuItem.Text = "Ulož do súboru";
            // 
            // btnStartRace
            // 
            this.btnStartRace.Location = new System.Drawing.Point(231, 1);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(75, 23);
            this.btnStartRace.TabIndex = 1;
            this.btnStartRace.Text = "Preteky štart";
            this.btnStartRace.UseVisualStyleBackColor = true;
            // 
            // lblEnterRacerNumber
            // 
            this.lblEnterRacerNumber.AutoSize = true;
            this.lblEnterRacerNumber.Location = new System.Drawing.Point(12, 46);
            this.lblEnterRacerNumber.Name = "lblEnterRacerNumber";
            this.lblEnterRacerNumber.Size = new System.Drawing.Size(108, 13);
            this.lblEnterRacerNumber.TabIndex = 2;
            this.lblEnterRacerNumber.Text = "Zadaj číslo pretekára";
            // 
            // txtRacerNumber
            // 
            this.txtRacerNumber.Location = new System.Drawing.Point(126, 39);
            this.txtRacerNumber.Name = "txtRacerNumber";
            this.txtRacerNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRacerNumber.TabIndex = 3;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 614);
            this.Controls.Add(this.txtRacerNumber);
            this.Controls.Add(this.lblEnterRacerNumber);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmView";
            this.Text = "Bežecké preteky";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem súborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem načítajZoSúboruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložDoSúboruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretekáriToolStripMenuItem;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Label lblEnterRacerNumber;
        private System.Windows.Forms.TextBox txtRacerNumber;
    }
}

