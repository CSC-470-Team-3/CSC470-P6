namespace Builder
{
    partial class FormSelectIssue
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
            this.issuesDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectIssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueDiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueDiscoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueInitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectIssueButton = new System.Windows.Forms.Button();
            this.SelectCancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // issuesDataGridView
            // 
            this.issuesDataGridView.AllowUserToAddRows = false;
            this.issuesDataGridView.AllowUserToDeleteRows = false;
            this.issuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectIssueID,
            this.SelectIssueTitle,
            this.SelectIssueDiscoveryDate,
            this.SelectIssueDiscoverer,
            this.SelectIssueInitialDescription,
            this.SelectIssueComponent,
            this.SelectIssueStatus});
            this.issuesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.issuesDataGridView.MultiSelect = false;
            this.issuesDataGridView.Name = "issuesDataGridView";
            this.issuesDataGridView.ReadOnly = true;
            this.issuesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issuesDataGridView.Size = new System.Drawing.Size(787, 328);
            this.issuesDataGridView.TabIndex = 0;
            // 
            // SelectIssueID
            // 
            this.SelectIssueID.HeaderText = "Id";
            this.SelectIssueID.Name = "SelectIssueID";
            this.SelectIssueID.ReadOnly = true;
            this.SelectIssueID.Width = 35;
            // 
            // SelectIssueTitle
            // 
            this.SelectIssueTitle.HeaderText = "Title";
            this.SelectIssueTitle.Name = "SelectIssueTitle";
            this.SelectIssueTitle.ReadOnly = true;
            this.SelectIssueTitle.Width = 175;
            // 
            // SelectIssueDiscoveryDate
            // 
            this.SelectIssueDiscoveryDate.HeaderText = "DiscoveryDate";
            this.SelectIssueDiscoveryDate.Name = "SelectIssueDiscoveryDate";
            this.SelectIssueDiscoveryDate.ReadOnly = true;
            this.SelectIssueDiscoveryDate.Width = 125;
            // 
            // SelectIssueDiscoverer
            // 
            this.SelectIssueDiscoverer.HeaderText = "Discoverer";
            this.SelectIssueDiscoverer.Name = "SelectIssueDiscoverer";
            this.SelectIssueDiscoverer.ReadOnly = true;
            // 
            // SelectIssueInitialDescription
            // 
            this.SelectIssueInitialDescription.HeaderText = "InitialDescription";
            this.SelectIssueInitialDescription.Name = "SelectIssueInitialDescription";
            this.SelectIssueInitialDescription.ReadOnly = true;
            // 
            // SelectIssueComponent
            // 
            this.SelectIssueComponent.HeaderText = "Component";
            this.SelectIssueComponent.Name = "SelectIssueComponent";
            this.SelectIssueComponent.ReadOnly = true;
            // 
            // SelectIssueStatus
            // 
            this.SelectIssueStatus.HeaderText = "Status";
            this.SelectIssueStatus.Name = "SelectIssueStatus";
            this.SelectIssueStatus.ReadOnly = true;
            this.SelectIssueStatus.Width = 105;
            // 
            // SelectIssueButton
            // 
            this.SelectIssueButton.Location = new System.Drawing.Point(680, 392);
            this.SelectIssueButton.Name = "SelectIssueButton";
            this.SelectIssueButton.Size = new System.Drawing.Size(119, 23);
            this.SelectIssueButton.TabIndex = 1;
            this.SelectIssueButton.Text = "Select Issue";
            this.SelectIssueButton.UseVisualStyleBackColor = true;
            this.SelectIssueButton.Click += new System.EventHandler(this.SelectIssueButton_Click);
            // 
            // SelectCancelbutton
            // 
            this.SelectCancelbutton.Location = new System.Drawing.Point(514, 392);
            this.SelectCancelbutton.Name = "SelectCancelbutton";
            this.SelectCancelbutton.Size = new System.Drawing.Size(119, 23);
            this.SelectCancelbutton.TabIndex = 2;
            this.SelectCancelbutton.Text = "Cancel";
            this.SelectCancelbutton.UseVisualStyleBackColor = true;
            this.SelectCancelbutton.Click += new System.EventHandler(this.SelectCancelbutton_Click);
            // 
            // FormSelectIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.SelectCancelbutton);
            this.Controls.Add(this.SelectIssueButton);
            this.Controls.Add(this.issuesDataGridView);
            this.Name = "FormSelectIssue";
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormSelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issuesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueDiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueDiscoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueInitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectIssueStatus;
        private System.Windows.Forms.Button SelectIssueButton;
        private System.Windows.Forms.Button SelectCancelbutton;
    }
}