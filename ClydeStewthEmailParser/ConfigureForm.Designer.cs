namespace ClydeStewthEmailParser
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.filtersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveCSVButton = new System.Windows.Forms.Button();
            this.openResultsButton = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.emaiLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.descendingTextBox = new System.Windows.Forms.TextBox();
            this.emailLimitTextBox = new System.Windows.Forms.TextBox();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.toggleDateTextBox = new System.Windows.Forms.TextBox();
            this.toggleIDTextBox = new System.Windows.Forms.TextBox();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emaiLimitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // filtersCheckedListBox
            // 
            this.filtersCheckedListBox.FormattingEnabled = true;
            this.filtersCheckedListBox.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5",
            "Test6",
            "Test7",
            "Test8",
            "Test9",
            "Test10",
            "Test11",
            "Test12",
            "Test13",
            "Test14",
            "Test15",
            "Test16",
            "Test17",
            "Test18",
            "Test19",
            "Test20"});
            this.filtersCheckedListBox.Location = new System.Drawing.Point(16, 15);
            this.filtersCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtersCheckedListBox.Name = "filtersCheckedListBox";
            this.filtersCheckedListBox.Size = new System.Drawing.Size(188, 293);
            this.filtersCheckedListBox.TabIndex = 0;
            this.filtersCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchProgressBar.Location = new System.Drawing.Point(163, 252);
            this.searchProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(160, 33);
            this.searchProgressBar.TabIndex = 1;
            this.searchProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Enabled = false;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Location = new System.Drawing.Point(7, 252);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 33);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveCSVButton
            // 
            this.saveCSVButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCSVButton.Location = new System.Drawing.Point(382, 321);
            this.saveCSVButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCSVButton.Name = "saveCSVButton";
            this.saveCSVButton.Size = new System.Drawing.Size(168, 41);
            this.saveCSVButton.TabIndex = 3;
            this.saveCSVButton.Text = "Save to CSV";
            this.saveCSVButton.UseVisualStyleBackColor = false;
            this.saveCSVButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // openResultsButton
            // 
            this.openResultsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openResultsButton.Location = new System.Drawing.Point(215, 321);
            this.openResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openResultsButton.Name = "openResultsButton";
            this.openResultsButton.Size = new System.Drawing.Size(171, 41);
            this.openResultsButton.TabIndex = 4;
            this.openResultsButton.Text = "Open Results";
            this.openResultsButton.UseVisualStyleBackColor = false;
            this.openResultsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.optionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optionsPanel.Controls.Add(this.toggleIDTextBox);
            this.optionsPanel.Controls.Add(this.toggleDateTextBox);
            this.optionsPanel.Controls.Add(this.emaiLimitNumericUpDown);
            this.optionsPanel.Controls.Add(this.descendingCheckBox);
            this.optionsPanel.Controls.Add(this.endDateTimePicker);
            this.optionsPanel.Controls.Add(this.startDateTimePicker);
            this.optionsPanel.Controls.Add(this.endDateTextBox);
            this.optionsPanel.Controls.Add(this.startDateTextBox);
            this.optionsPanel.Controls.Add(this.descendingTextBox);
            this.optionsPanel.Controls.Add(this.emailLimitTextBox);
            this.optionsPanel.Controls.Add(this.folderNameTextBox);
            this.optionsPanel.Controls.Add(this.searchButton);
            this.optionsPanel.Controls.Add(this.searchProgressBar);
            this.optionsPanel.Location = new System.Drawing.Point(213, 15);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(333, 293);
            this.optionsPanel.TabIndex = 6;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // emaiLimitNumericUpDown
            // 
            this.emaiLimitNumericUpDown.Location = new System.Drawing.Point(163, 69);
            this.emaiLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emaiLimitNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.emaiLimitNumericUpDown.Name = "emaiLimitNumericUpDown";
            this.emaiLimitNumericUpDown.Size = new System.Drawing.Size(159, 22);
            this.emaiLimitNumericUpDown.TabIndex = 13;
            this.emaiLimitNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.emaiLimitNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Checked = true;
            this.descendingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descendingCheckBox.Location = new System.Drawing.Point(163, 103);
            this.descendingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(18, 17);
            this.descendingCheckBox.TabIndex = 12;
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(163, 164);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.endDateTimePicker.TabIndex = 11;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(163, 132);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.startDateTimePicker.TabIndex = 10;
            this.startDateTimePicker.Value = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.endDateTextBox.Location = new System.Drawing.Point(8, 164);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.ReadOnly = true;
            this.endDateTextBox.Size = new System.Drawing.Size(153, 22);
            this.endDateTextBox.TabIndex = 9;
            this.endDateTextBox.Text = "End Date";
            this.endDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endDateTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startDateTextBox.Location = new System.Drawing.Point(8, 132);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.ReadOnly = true;
            this.startDateTextBox.Size = new System.Drawing.Size(153, 22);
            this.startDateTextBox.TabIndex = 8;
            this.startDateTextBox.Text = "Start Date";
            this.startDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descendingTextBox
            // 
            this.descendingTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descendingTextBox.Location = new System.Drawing.Point(8, 100);
            this.descendingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descendingTextBox.Name = "descendingTextBox";
            this.descendingTextBox.ReadOnly = true;
            this.descendingTextBox.Size = new System.Drawing.Size(153, 22);
            this.descendingTextBox.TabIndex = 7;
            this.descendingTextBox.Text = "Descending";
            this.descendingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.descendingTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // emailLimitTextBox
            // 
            this.emailLimitTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailLimitTextBox.Location = new System.Drawing.Point(8, 68);
            this.emailLimitTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailLimitTextBox.Name = "emailLimitTextBox";
            this.emailLimitTextBox.ReadOnly = true;
            this.emailLimitTextBox.Size = new System.Drawing.Size(152, 22);
            this.emailLimitTextBox.TabIndex = 6;
            this.emailLimitTextBox.Text = "Email Limit";
            this.emailLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.folderNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderNameTextBox.Location = new System.Drawing.Point(9, 4);
            this.folderNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folderNameTextBox.Multiline = true;
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.ReadOnly = true;
            this.folderNameTextBox.Size = new System.Drawing.Size(313, 57);
            this.folderNameTextBox.TabIndex = 5;
            this.folderNameTextBox.Text = "jason.holloway\\inbox";
            this.folderNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.folderNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toggleDateTextBox
            // 
            this.toggleDateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toggleDateTextBox.Location = new System.Drawing.Point(7, 198);
            this.toggleDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.toggleDateTextBox.Name = "toggleDateTextBox";
            this.toggleDateTextBox.ReadOnly = true;
            this.toggleDateTextBox.Size = new System.Drawing.Size(153, 22);
            this.toggleDateTextBox.TabIndex = 14;
            this.toggleDateTextBox.Text = "Toggle Date";
            this.toggleDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toggleIDTextBox
            // 
            this.toggleIDTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toggleIDTextBox.Location = new System.Drawing.Point(9, 222);
            this.toggleIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.toggleIDTextBox.Name = "toggleIDTextBox";
            this.toggleIDTextBox.ReadOnly = true;
            this.toggleIDTextBox.Size = new System.Drawing.Size(153, 22);
            this.toggleIDTextBox.TabIndex = 15;
            this.toggleIDTextBox.Text = "Toggle Date";
            this.toggleIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toggleIDTextBox.TextChanged += new System.EventHandler(this.toggleIDTextBox_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 407);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.openResultsButton);
            this.Controls.Add(this.saveCSVButton);
            this.Controls.Add(this.filtersCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchForm";
            this.Text = "Email Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emaiLimitNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox filtersCheckedListBox;
        private System.Windows.Forms.ProgressBar searchProgressBar;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveCSVButton;
        private System.Windows.Forms.Button openResultsButton;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox descendingTextBox;
        private System.Windows.Forms.TextBox emailLimitTextBox;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.CheckBox descendingCheckBox;
        private System.Windows.Forms.NumericUpDown emaiLimitNumericUpDown;
        private System.Windows.Forms.TextBox toggleIDTextBox;
        private System.Windows.Forms.TextBox toggleDateTextBox;
    }
}