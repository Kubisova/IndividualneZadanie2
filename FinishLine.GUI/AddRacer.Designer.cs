namespace FinishLine
{
    partial class FrmAddRacer
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
            this.lblStartNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.grpBGender = new System.Windows.Forms.GroupBox();
            this.rdnMan = new System.Windows.Forms.RadioButton();
            this.rdnWoman = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numStartNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartNumber
            // 
            this.lblStartNumber.AutoSize = true;
            this.lblStartNumber.Location = new System.Drawing.Point(32, 30);
            this.lblStartNumber.Name = "lblStartNumber";
            this.lblStartNumber.Size = new System.Drawing.Size(87, 13);
            this.lblStartNumber.TabIndex = 0;
            this.lblStartNumber.Text = "Štartovacie číslo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Meno";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(32, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Vek";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(138, 185);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(269, 21);
            this.cmbCountry.TabIndex = 4;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(32, 185);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(39, 13);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Krajina";
            // 
            // grpBGender
            // 
            this.grpBGender.Controls.Add(this.rdnMan);
            this.grpBGender.Controls.Add(this.rdnWoman);
            this.grpBGender.Location = new System.Drawing.Point(315, 95);
            this.grpBGender.Name = "grpBGender";
            this.grpBGender.Size = new System.Drawing.Size(92, 77);
            this.grpBGender.TabIndex = 3;
            this.grpBGender.TabStop = false;
            this.grpBGender.Text = "Pohlavie";
            // 
            // rdnMan
            // 
            this.rdnMan.AutoSize = true;
            this.rdnMan.Location = new System.Drawing.Point(29, 42);
            this.rdnMan.Name = "rdnMan";
            this.rdnMan.Size = new System.Drawing.Size(45, 17);
            this.rdnMan.TabIndex = 1;
            this.rdnMan.TabStop = true;
            this.rdnMan.Text = "Muž";
            this.rdnMan.UseVisualStyleBackColor = true;
            // 
            // rdnWoman
            // 
            this.rdnWoman.AutoSize = true;
            this.rdnWoman.Location = new System.Drawing.Point(29, 19);
            this.rdnWoman.Name = "rdnWoman";
            this.rdnWoman.Size = new System.Drawing.Size(50, 17);
            this.rdnWoman.TabIndex = 0;
            this.rdnWoman.TabStop = true;
            this.rdnWoman.Text = "Žena";
            this.rdnWoman.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 1;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(138, 95);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 2;
            // 
            // numStartNumber
            // 
            this.numStartNumber.Location = new System.Drawing.Point(138, 23);
            this.numStartNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numStartNumber.Name = "numStartNumber";
            this.numStartNumber.Size = new System.Drawing.Size(120, 20);
            this.numStartNumber.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ulož";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddRacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 283);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numStartNumber);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpBGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStartNumber);
            this.MaximumSize = new System.Drawing.Size(448, 321);
            this.MinimumSize = new System.Drawing.Size(448, 321);
            this.Name = "FrmAddRacer";
            this.Text = "Pridaj pretekára";
            this.grpBGender.ResumeLayout(false);
            this.grpBGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox grpBGender;
        private System.Windows.Forms.RadioButton rdnMan;
        private System.Windows.Forms.RadioButton rdnWoman;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numStartNumber;
        private System.Windows.Forms.Button btnSave;
    }
}