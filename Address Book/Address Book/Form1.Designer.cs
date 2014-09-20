namespace Address_Book
{
    partial class AddressBookForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personalCnTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personalCnLabel = new System.Windows.Forms.Label();
            this.homeCnLabel = new System.Windows.Forms.Label();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.homeCnTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.personListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personalCnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.homeCnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(134, 32);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(302, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // personalCnTextBox
            // 
            this.personalCnTextBox.Location = new System.Drawing.Point(134, 58);
            this.personalCnTextBox.Name = "personalCnTextBox";
            this.personalCnTextBox.Size = new System.Drawing.Size(302, 20);
            this.personalCnTextBox.TabIndex = 2;
            this.personalCnTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(89, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(92, 35);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // personalCnLabel
            // 
            this.personalCnLabel.AutoSize = true;
            this.personalCnLabel.Location = new System.Drawing.Point(19, 58);
            this.personalCnLabel.Name = "personalCnLabel";
            this.personalCnLabel.Size = new System.Drawing.Size(108, 13);
            this.personalCnLabel.TabIndex = 5;
            this.personalCnLabel.Text = "Personal Contact No:";
            // 
            // homeCnLabel
            // 
            this.homeCnLabel.AutoSize = true;
            this.homeCnLabel.Location = new System.Drawing.Point(35, 87);
            this.homeCnLabel.Name = "homeCnLabel";
            this.homeCnLabel.Size = new System.Drawing.Size(92, 13);
            this.homeCnLabel.TabIndex = 6;
            this.homeCnLabel.Text = "Home Contact No";
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Location = new System.Drawing.Point(48, 113);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.homeAddressLabel.TabIndex = 7;
            this.homeAddressLabel.Text = "Home Address:";
            // 
            // homeCnTextBox
            // 
            this.homeCnTextBox.Location = new System.Drawing.Point(134, 80);
            this.homeCnTextBox.Name = "homeCnTextBox";
            this.homeCnTextBox.Size = new System.Drawing.Size(302, 20);
            this.homeCnTextBox.TabIndex = 0;
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(134, 110);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(302, 20);
            this.homeAddressTextBox.TabIndex = 0;
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.emailColumnHeader,
            this.personalCnColumnHeader,
            this.homeCnColumnHeader,
            this.addressColumnHeader});
            this.personListView.GridLines = true;
            this.personListView.Location = new System.Drawing.Point(12, 206);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(424, 201);
            this.personListView.TabIndex = 9;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            // 
            // personalCnColumnHeader
            // 
            this.personalCnColumnHeader.Text = "Personal CN";
            this.personalCnColumnHeader.Width = 83;
            // 
            // homeCnColumnHeader
            // 
            this.homeCnColumnHeader.Text = "Home CN";
            this.homeCnColumnHeader.Width = 85;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.Width = 167;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(164, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 419);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.personListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homeAddressLabel);
            this.Controls.Add(this.homeCnLabel);
            this.Controls.Add(this.personalCnLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.personalCnTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(this.homeCnTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddressBookForm";
            this.Text = "Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox personalCnTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label personalCnLabel;
        private System.Windows.Forms.Label homeCnLabel;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.TextBox homeCnTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader personalCnColumnHeader;
        private System.Windows.Forms.ColumnHeader homeCnColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
    }
}

