﻿namespace Fohjin.DDD.BankApplication.Views
{
    partial class ClientDetails
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
            this._clientName = new System.Windows.Forms.TextBox();
            this._street = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._streetNumber = new System.Windows.Forms.TextBox();
            this._postalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._accounts = new System.Windows.Forms.ListBox();
            this._phoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasMovedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasMovedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changedHisPhonenumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _clientName
            // 
            this._clientName.Location = new System.Drawing.Point(112, 36);
            this._clientName.Name = "_clientName";
            this._clientName.Size = new System.Drawing.Size(260, 20);
            this._clientName.TabIndex = 1;
            this._clientName.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // _street
            // 
            this._street.Location = new System.Drawing.Point(112, 71);
            this._street.Name = "_street";
            this._street.Size = new System.Drawing.Size(205, 20);
            this._street.TabIndex = 2;
            this._street.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address / Number";
            // 
            // _city
            // 
            this._city.Location = new System.Drawing.Point(167, 97);
            this._city.Name = "_city";
            this._city.Size = new System.Drawing.Size(205, 20);
            this._city.TabIndex = 5;
            this._city.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postalcode / City";
            // 
            // _streetNumber
            // 
            this._streetNumber.Location = new System.Drawing.Point(323, 71);
            this._streetNumber.Name = "_streetNumber";
            this._streetNumber.Size = new System.Drawing.Size(49, 20);
            this._streetNumber.TabIndex = 3;
            this._streetNumber.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // _postalCode
            // 
            this._postalCode.Location = new System.Drawing.Point(112, 97);
            this._postalCode.Name = "_postalCode";
            this._postalCode.Size = new System.Drawing.Size(49, 20);
            this._postalCode.TabIndex = 4;
            this._postalCode.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Accounts";
            // 
            // _accounts
            // 
            this._accounts.FormattingEnabled = true;
            this._accounts.Location = new System.Drawing.Point(12, 175);
            this._accounts.Name = "_accounts";
            this._accounts.Size = new System.Drawing.Size(360, 95);
            this._accounts.TabIndex = 7;
            this._accounts.DoubleClick += new System.EventHandler(this._accounts_DoubleClick);
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Location = new System.Drawing.Point(112, 123);
            this._phoneNumber.Name = "_phoneNumber";
            this._phoneNumber.Size = new System.Drawing.Size(260, 20);
            this._phoneNumber.TabIndex = 6;
            this._phoneNumber.TextChanged += new System.EventHandler(this._client_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone number";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.accountsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hasMovedToolStripMenuItem,
            this.hasMovedToolStripMenuItem1,
            this.changedHisPhonenumberToolStripMenuItem,
            this.createToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // hasMovedToolStripMenuItem
            // 
            this.hasMovedToolStripMenuItem.Name = "hasMovedToolStripMenuItem";
            this.hasMovedToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hasMovedToolStripMenuItem.Text = "Got his name changed";
            // 
            // hasMovedToolStripMenuItem1
            // 
            this.hasMovedToolStripMenuItem1.Name = "hasMovedToolStripMenuItem1";
            this.hasMovedToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.hasMovedToolStripMenuItem1.Text = "Has moved";
            // 
            // changedHisPhonenumberToolStripMenuItem
            // 
            this.changedHisPhonenumberToolStripMenuItem.Name = "changedHisPhonenumberToolStripMenuItem";
            this.changedHisPhonenumberToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.changedHisPhonenumberToolStripMenuItem.Text = "Changed his phonenumber";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addNewAccountToolStripMenuItem.Text = "Add new account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // ClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 283);
            this.Controls.Add(this._phoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._accounts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._postalCode);
            this.Controls.Add(this._streetNumber);
            this.Controls.Add(this._city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._street);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._clientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDetails";
            this.Text = "Client Details";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _clientName;
        private System.Windows.Forms.TextBox _street;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _streetNumber;
        private System.Windows.Forms.TextBox _postalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox _accounts;
        private System.Windows.Forms.TextBox _phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasMovedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasMovedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changedHisPhonenumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}