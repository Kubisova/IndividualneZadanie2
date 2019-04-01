namespace FinishLine
{
    partial class FrmSettings
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
            this.lblRonudLength = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.lblNumberOfWinners = new System.Windows.Forms.Label();
            this.numRoundLength = new System.Windows.Forms.NumericUpDown();
            this.numRoundCount = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfWinners = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRonudLength
            // 
            this.lblRonudLength.AutoSize = true;
            this.lblRonudLength.Location = new System.Drawing.Point(34, 38);
            this.lblRonudLength.Name = "lblRonudLength";
            this.lblRonudLength.Size = new System.Drawing.Size(58, 13);
            this.lblRonudLength.TabIndex = 0;
            this.lblRonudLength.Text = "Dĺžka kola";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(34, 77);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(52, 13);
            this.lblRoundCount.TabIndex = 1;
            this.lblRoundCount.Text = "Počet kôl";
            // 
            // lblNumberOfWinners
            // 
            this.lblNumberOfWinners.AutoSize = true;
            this.lblNumberOfWinners.Location = new System.Drawing.Point(34, 114);
            this.lblNumberOfWinners.Name = "lblNumberOfWinners";
            this.lblNumberOfWinners.Size = new System.Drawing.Size(75, 13);
            this.lblNumberOfWinners.TabIndex = 2;
            this.lblNumberOfWinners.Text = "Počet víťazov";
            // 
            // numRoundLength
            // 
            this.numRoundLength.Location = new System.Drawing.Point(139, 38);
            this.numRoundLength.Name = "numRoundLength";
            this.numRoundLength.Size = new System.Drawing.Size(120, 20);
            this.numRoundLength.TabIndex = 3;
            // 
            // numRoundCount
            // 
            this.numRoundCount.Location = new System.Drawing.Point(139, 77);
            this.numRoundCount.Name = "numRoundCount";
            this.numRoundCount.Size = new System.Drawing.Size(120, 20);
            this.numRoundCount.TabIndex = 4;
            // 
            // numNumberOfWinners
            // 
            this.numNumberOfWinners.Location = new System.Drawing.Point(139, 114);
            this.numNumberOfWinners.Name = "numNumberOfWinners";
            this.numNumberOfWinners.Size = new System.Drawing.Size(120, 20);
            this.numNumberOfWinners.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ulož";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 204);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numNumberOfWinners);
            this.Controls.Add(this.numRoundCount);
            this.Controls.Add(this.numRoundLength);
            this.Controls.Add(this.lblNumberOfWinners);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblRonudLength);
            this.MaximumSize = new System.Drawing.Size(352, 242);
            this.MinimumSize = new System.Drawing.Size(352, 242);
            this.Name = "FrmSettings";
            this.Text = "Nastavenie";
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfWinners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRonudLength;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label lblNumberOfWinners;
        private System.Windows.Forms.NumericUpDown numRoundLength;
        private System.Windows.Forms.NumericUpDown numRoundCount;
        private System.Windows.Forms.NumericUpDown numNumberOfWinners;
        private System.Windows.Forms.Button btnSave;
    }
}