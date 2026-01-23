namespace ClydeStewthEmailParser
{
    partial class DataView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MercyCaseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MercyIncidentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.saveCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MercyCaseNumber,
            this.MercyIncidentNumber});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(632, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MercyCaseNumber
            // 
            this.MercyCaseNumber.FillWeight = 150F;
            this.MercyCaseNumber.HeaderText = "Mercy - Case Number";
            this.MercyCaseNumber.Name = "MercyCaseNumber";
            this.MercyCaseNumber.ReadOnly = true;
            this.MercyCaseNumber.Width = 150;
            // 
            // MercyIncidentNumber
            // 
            this.MercyIncidentNumber.FillWeight = 150F;
            this.MercyIncidentNumber.HeaderText = "Mercy - Incident Number";
            this.MercyIncidentNumber.Name = "MercyIncidentNumber";
            this.MercyIncidentNumber.ReadOnly = true;
            this.MercyIncidentNumber.Width = 150;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 389);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(173, 34);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // saveCSVButton
            // 
            this.saveCSVButton.Location = new System.Drawing.Point(191, 389);
            this.saveCSVButton.Name = "saveCSVButton";
            this.saveCSVButton.Size = new System.Drawing.Size(173, 34);
            this.saveCSVButton.TabIndex = 2;
            this.saveCSVButton.Text = "Save to CSV";
            this.saveCSVButton.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 430);
            this.Controls.Add(this.saveCSVButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataView";
            this.Text = "DataView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MercyCaseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MercyIncidentNumber;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveCSVButton;
    }
}