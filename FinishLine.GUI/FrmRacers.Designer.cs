namespace FinishLine
{
    partial class FrmRacers
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
            this.dGVRacers = new System.Windows.Forms.DataGridView();
            this.StartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRacer = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRacers)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVRacers
            // 
            this.dGVRacers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVRacers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRacers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartNumber,
            this.Surname,
            this.Age,
            this.Gender,
            this.Country});
            this.dGVRacers.Location = new System.Drawing.Point(28, 12);
            this.dGVRacers.Name = "dGVRacers";
            this.dGVRacers.ReadOnly = true;
            this.dGVRacers.RowHeadersVisible = false;
            this.dGVRacers.Size = new System.Drawing.Size(740, 396);
            this.dGVRacers.TabIndex = 0;
            // 
            // StartNumber
            // 
            this.StartNumber.HeaderText = "Štartovacie číslo";
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.ReadOnly = true;
            this.StartNumber.Width = 150;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Meno";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 200;
            // 
            // Age
            // 
            this.Age.HeaderText = "Vek";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Pohlavie";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Krajina";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Country.Width = 200;
            // 
            // btnAddRacer
            // 
            this.btnAddRacer.Location = new System.Drawing.Point(28, 415);
            this.btnAddRacer.Name = "btnAddRacer";
            this.btnAddRacer.Size = new System.Drawing.Size(75, 23);
            this.btnAddRacer.TabIndex = 1;
            this.btnAddRacer.Text = "Pridaj";
            this.btnAddRacer.UseVisualStyleBackColor = true;
            this.btnAddRacer.Click += new System.EventHandler(this.btnAddRacer_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Oprav";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(209, 415);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Vymaž";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(693, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zatvor";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmRacers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddRacer);
            this.Controls.Add(this.dGVRacers);
            this.Name = "FrmRacers";
            this.Text = "Pretekári";
            ((System.ComponentModel.ISupportInitialize)(this.dGVRacers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVRacers;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.Button btnAddRacer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnClose;
    }
}