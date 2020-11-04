namespace Builder
{
    partial class FormIssueModify
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
            this.InitialDescription = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.ModifyIssueButton = new System.Windows.Forms.Button();
            this.SelectCancelButton = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DiscovererComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComponentBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.InitialDescriptionLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ComponentLabel = new System.Windows.Forms.Label();
            this.DiscovererLabel = new System.Windows.Forms.Label();
            this.DiscoveryDateLabel = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.IdLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitialDescription
            // 
            this.InitialDescription.Location = new System.Drawing.Point(127, 298);
            this.InitialDescription.Multiline = true;
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InitialDescription.Size = new System.Drawing.Size(341, 184);
            this.InitialDescription.TabIndex = 36;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.SystemColors.Menu;
            this.IdBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IdBox.Location = new System.Drawing.Point(127, 56);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(100, 20);
            this.IdBox.TabIndex = 35;
            this.IdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ModifyIssueButton
            // 
            this.ModifyIssueButton.Location = new System.Drawing.Point(371, 513);
            this.ModifyIssueButton.Name = "ModifyIssueButton";
            this.ModifyIssueButton.Size = new System.Drawing.Size(97, 23);
            this.ModifyIssueButton.TabIndex = 34;
            this.ModifyIssueButton.Text = "Modify Issue";
            this.ModifyIssueButton.UseVisualStyleBackColor = true;
            this.ModifyIssueButton.Click += new System.EventHandler(this.ModifyIssueButton_Click);
            // 
            // SelectCancelButton
            // 
            this.SelectCancelButton.Location = new System.Drawing.Point(222, 513);
            this.SelectCancelButton.Name = "SelectCancelButton";
            this.SelectCancelButton.Size = new System.Drawing.Size(98, 23);
            this.SelectCancelButton.TabIndex = 33;
            this.SelectCancelButton.Text = "Cancel";
            this.SelectCancelButton.UseVisualStyleBackColor = true;
            this.SelectCancelButton.Click += new System.EventHandler(this.SelectCancelButton_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(127, 231);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(341, 21);
            this.StatusComboBox.TabIndex = 32;
            // 
            // DiscovererComboBox
            // 
            this.DiscovererComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DiscovererComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscovererComboBox.FormattingEnabled = true;
            this.DiscovererComboBox.Location = new System.Drawing.Point(127, 164);
            this.DiscovererComboBox.Name = "DiscovererComboBox";
            this.DiscovererComboBox.Size = new System.Drawing.Size(341, 21);
            this.DiscovererComboBox.TabIndex = 31;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(127, 127);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(341, 20);
            this.DateTimePicker.TabIndex = 30;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // ComponentBox
            // 
            this.ComponentBox.BackColor = System.Drawing.SystemColors.Window;
            this.ComponentBox.Location = new System.Drawing.Point(127, 198);
            this.ComponentBox.Name = "ComponentBox";
            this.ComponentBox.Size = new System.Drawing.Size(341, 20);
            this.ComponentBox.TabIndex = 29;
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleBox.Location = new System.Drawing.Point(127, 97);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(341, 20);
            this.TitleBox.TabIndex = 28;
            // 
            // InitialDescriptionLabel
            // 
            this.InitialDescriptionLabel.AutoSize = true;
            this.InitialDescriptionLabel.Location = new System.Drawing.Point(81, 273);
            this.InitialDescriptionLabel.Name = "InitialDescriptionLabel";
            this.InitialDescriptionLabel.Size = new System.Drawing.Size(87, 13);
            this.InitialDescriptionLabel.TabIndex = 27;
            this.InitialDescriptionLabel.Text = "Initial Description";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(81, 234);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 26;
            this.StatusLabel.Text = "Status:";
            // 
            // ComponentLabel
            // 
            this.ComponentLabel.AutoSize = true;
            this.ComponentLabel.Location = new System.Drawing.Point(57, 201);
            this.ComponentLabel.Name = "ComponentLabel";
            this.ComponentLabel.Size = new System.Drawing.Size(64, 13);
            this.ComponentLabel.TabIndex = 25;
            this.ComponentLabel.Text = "Component:";
            // 
            // DiscovererLabel
            // 
            this.DiscovererLabel.AutoSize = true;
            this.DiscovererLabel.Location = new System.Drawing.Point(65, 167);
            this.DiscovererLabel.Name = "DiscovererLabel";
            this.DiscovererLabel.Size = new System.Drawing.Size(61, 13);
            this.DiscovererLabel.TabIndex = 24;
            this.DiscovererLabel.Text = "Discoverer:";
            // 
            // DiscoveryDateLabel
            // 
            this.DiscoveryDateLabel.AutoSize = true;
            this.DiscoveryDateLabel.Location = new System.Drawing.Point(43, 133);
            this.DiscoveryDateLabel.Name = "DiscoveryDateLabel";
            this.DiscoveryDateLabel.Size = new System.Drawing.Size(78, 13);
            this.DiscoveryDateLabel.TabIndex = 23;
            this.DiscoveryDateLabel.Text = "Dicovery Date:";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(91, 100);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(30, 13);
            this.TitleLable.TabIndex = 22;
            this.TitleLable.Text = "Title:";
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(102, 59);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(19, 13);
            this.IdLable.TabIndex = 21;
            this.IdLable.Text = "Id:";
            // 
            // FormIssueModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 584);
            this.Controls.Add(this.InitialDescription);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.ModifyIssueButton);
            this.Controls.Add(this.SelectCancelButton);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.DiscovererComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ComponentBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.InitialDescriptionLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ComponentLabel);
            this.Controls.Add(this.DiscovererLabel);
            this.Controls.Add(this.DiscoveryDateLabel);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.IdLable);
            this.Name = "FormIssueModify";
            this.Text = "Modify Issue";
            this.Load += new System.EventHandler(this.FormIssueModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InitialDescription;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button ModifyIssueButton;
        private System.Windows.Forms.Button SelectCancelButton;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox DiscovererComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox ComponentBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label InitialDescriptionLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ComponentLabel;
        private System.Windows.Forms.Label DiscovererLabel;
        private System.Windows.Forms.Label DiscoveryDateLabel;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label IdLable;
    }
}