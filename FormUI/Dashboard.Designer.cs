namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.phoneInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailInsLabel = new System.Windows.Forms.Label();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 37;
            this.peopleFoundListBox.Location = new System.Drawing.Point(158, 274);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(969, 300);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(414, 69);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(225, 44);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(151, 76);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(164, 37);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "LastName";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(158, 151);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(186, 80);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(162, 630);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(175, 37);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            this.firstNameInsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.AcceptsReturn = true;
            this.firstNameInsText.Location = new System.Drawing.Point(414, 623);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(225, 44);
            this.firstNameInsText.TabIndex = 4;
//            this.firstNameInsText.TextChanged += new System.EventHandler(this.firstNameInsText_TextChanged);
            // 
            // phoneInsLabel
            // 
            this.phoneInsLabel.AutoSize = true;
            this.phoneInsLabel.Location = new System.Drawing.Point(162, 810);
            this.phoneInsLabel.Name = "phoneInsLabel";
            this.phoneInsLabel.Size = new System.Drawing.Size(233, 37);
            this.phoneInsLabel.TabIndex = 7;
            this.phoneInsLabel.Text = "Phone Number";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.AcceptsReturn = true;
            this.lastNameInsText.Location = new System.Drawing.Point(414, 685);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(225, 44);
            this.lastNameInsText.TabIndex = 6;
            // 
            // emailInsLabel
            // 
            this.emailInsLabel.AutoSize = true;
            this.emailInsLabel.Location = new System.Drawing.Point(162, 752);
            this.emailInsLabel.Name = "emailInsLabel";
            this.emailInsLabel.Size = new System.Drawing.Size(224, 37);
            this.emailInsLabel.TabIndex = 9;
            this.emailInsLabel.Text = "Email Address";
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(414, 745);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(225, 44);
            this.emailInsText.TabIndex = 8;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(162, 688);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(173, 37);
            this.lastNameInsLabel.TabIndex = 11;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(414, 803);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(225, 44);
            this.phoneInsText.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(158, 902);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(186, 80);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 1223);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.emailInsLabel);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.phoneInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label phoneInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailInsLabel;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox phoneInsText;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

