namespace P5
{
    partial class FormDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthBox = new System.Windows.Forms.ListBox();
            this.DiscoverBox = new System.Windows.Forms.ListBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Number of issues:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issues by Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Issue by Discoverer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MonthBox
            // 
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Location = new System.Drawing.Point(34, 133);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.ScrollAlwaysVisible = true;
            this.MonthBox.Size = new System.Drawing.Size(226, 95);
            this.MonthBox.TabIndex = 4;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DiscoverBox
            // 
            this.DiscoverBox.FormattingEnabled = true;
            this.DiscoverBox.Location = new System.Drawing.Point(34, 296);
            this.DiscoverBox.Name = "DiscoverBox";
            this.DiscoverBox.ScrollAlwaysVisible = true;
            this.DiscoverBox.Size = new System.Drawing.Size(226, 95);
            this.DiscoverBox.TabIndex = 5;
            // 
            // IDBox
            // 
            this.IDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.IDBox.Location = new System.Drawing.Point(155, 51);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(20, 13);
            this.IDBox.TabIndex = 6;
            this.IDBox.Text = "#";
            this.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.DiscoverBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MonthBox;
        private System.Windows.Forms.ListBox DiscoverBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button button1;
    }
}