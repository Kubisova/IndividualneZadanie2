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
            this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RacersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.lblEnterRacerNumber = new System.Windows.Forms.Label();
            this.txtRacerNumber = new System.Windows.Forms.TextBox();
            this.dGVFinishedRounds = new System.Windows.Forms.DataGridView();
            this.lblTempResults = new System.Windows.Forms.Label();
            this.dGVResults = new System.Windows.Forms.DataGridView();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.btnRegisterFinishedRound = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFinishedRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.RacersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            this.súborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFromFileToolStripMenuItem,
            this.SaveToFileToolStripMenuItem});
            this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            this.súborToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.súborToolStripMenuItem.Text = "Súbor";
            // 
            // LoadFromFileToolStripMenuItem
            // 
            this.LoadFromFileToolStripMenuItem.Name = "LoadFromFileToolStripMenuItem";
            this.LoadFromFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.LoadFromFileToolStripMenuItem.Text = "Načítaj zo súboru";
            this.LoadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // SaveToFileToolStripMenuItem
            // 
            this.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem";
            this.SaveToFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.SaveToFileToolStripMenuItem.Text = "Ulož do súboru";
            this.SaveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.SettingsToolStripMenuItem.Text = "Nastavenia";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // RacersToolStripMenuItem
            // 
            this.RacersToolStripMenuItem.Name = "RacersToolStripMenuItem";
            this.RacersToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.RacersToolStripMenuItem.Text = "Pretekári";
            this.RacersToolStripMenuItem.Click += new System.EventHandler(this.RacersToolStripMenuItem_Click);
            // 
            // btnStartRace
            // 
            this.btnStartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartRace.Location = new System.Drawing.Point(410, 0);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(110, 23);
            this.btnStartRace.TabIndex = 1;
            this.btnStartRace.Text = "Preteky štart";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // lblEnterRacerNumber
            // 
            this.lblEnterRacerNumber.AutoSize = true;
            this.lblEnterRacerNumber.Location = new System.Drawing.Point(12, 50);
            this.lblEnterRacerNumber.Name = "lblEnterRacerNumber";
            this.lblEnterRacerNumber.Size = new System.Drawing.Size(108, 13);
            this.lblEnterRacerNumber.TabIndex = 2;
            this.lblEnterRacerNumber.Text = "Zadaj číslo pretekára";
            // 
            // txtRacerNumber
            // 
            this.txtRacerNumber.Location = new System.Drawing.Point(126, 47);
            this.txtRacerNumber.Name = "txtRacerNumber";
            this.txtRacerNumber.Size = new System.Drawing.Size(156, 20);
            this.txtRacerNumber.TabIndex = 3;
            // 
            // dGVFinishedRounds
            // 
            this.dGVFinishedRounds.AllowUserToAddRows = false;
            this.dGVFinishedRounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGVFinishedRounds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFinishedRounds.Location = new System.Drawing.Point(12, 103);
            this.dGVFinishedRounds.Name = "dGVFinishedRounds";
            this.dGVFinishedRounds.ReadOnly = true;
            this.dGVFinishedRounds.RowHeadersVisible = false;
            this.dGVFinishedRounds.Size = new System.Drawing.Size(508, 434);
            this.dGVFinishedRounds.TabIndex = 4;
            // 
            // lblTempResults
            // 
            this.lblTempResults.AutoSize = true;
            this.lblTempResults.Location = new System.Drawing.Point(15, 84);
            this.lblTempResults.Name = "lblTempResults";
            this.lblTempResults.Size = new System.Drawing.Size(98, 13);
            this.lblTempResults.TabIndex = 5;
            this.lblTempResults.Text = "Priebežné výsledky";
            // 
            // dGVResults
            // 
            this.dGVResults.AllowUserToAddRows = false;
            this.dGVResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVResults.Location = new System.Drawing.Point(526, 103);
            this.dGVResults.Name = "dGVResults";
            this.dGVResults.ReadOnly = true;
            this.dGVResults.RowHeadersVisible = false;
            this.dGVResults.Size = new System.Drawing.Size(461, 434);
            this.dGVResults.TabIndex = 6;
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Location = new System.Drawing.Point(532, 84);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(90, 13);
            this.lblFinalResult.TabIndex = 7;
            this.lblFinalResult.Text = "Celkové výsledky";
            // 
            // btnRegisterFinishedRound
            // 
            this.btnRegisterFinishedRound.Location = new System.Drawing.Point(288, 47);
            this.btnRegisterFinishedRound.Name = "btnRegisterFinishedRound";
            this.btnRegisterFinishedRound.Size = new System.Drawing.Size(127, 23);
            this.btnRegisterFinishedRound.TabIndex = 8;
            this.btnRegisterFinishedRound.Text = "Zapíš odbehnuté kolo";
            this.btnRegisterFinishedRound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegisterFinishedRound.UseVisualStyleBackColor = true;
            this.btnRegisterFinishedRound.Click += new System.EventHandler(this.btnRegisterFinishedRound_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 543);
            this.Controls.Add(this.btnRegisterFinishedRound);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.dGVResults);
            this.Controls.Add(this.lblTempResults);
            this.Controls.Add(this.dGVFinishedRounds);
            this.Controls.Add(this.txtRacerNumber);
            this.Controls.Add(this.lblEnterRacerNumber);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1010, 1000);
            this.MinimumSize = new System.Drawing.Size(1010, 581);
            this.Name = "FrmView";
            this.Text = "Bežecké preteky";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFinishedRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem súborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RacersToolStripMenuItem;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Label lblEnterRacerNumber;
        private System.Windows.Forms.TextBox txtRacerNumber;
        private System.Windows.Forms.DataGridView dGVFinishedRounds;
        private System.Windows.Forms.Label lblTempResults;
        private System.Windows.Forms.DataGridView dGVResults;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.Button btnRegisterFinishedRound;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

