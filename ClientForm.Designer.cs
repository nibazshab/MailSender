using System.Drawing;
using System.Windows.Forms;

namespace MailSender
{
    partial class ClientForm
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
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this._ssl = new CheckBox();
            this.label5 = new Label();
            this._host = new TextBox();
            this._port = new TextBox();
            this._username = new TextBox();
            this._password = new TextBox();
            this.label6 = new Label();
            this.label7 = new Label();
            this._to = new TextBox();
            this._subject = new TextBox();
            this.send = new Button();
            this.label8 = new Label();
            this._content = new TextBox();
            this._attachments = new ListBox();
            this.label9 = new Label();
            this.attachment_add = new Button();
            this.attachment_clear = new Button();
            this.status = new Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new Size(68, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new Size(131, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new Size(132, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            // 
            // _ssl
            // 
            this._ssl.AutoSize = true;
            this._ssl.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._ssl.Location = new Point(150, 184);
            this._ssl.Name = "_ssl";
            this._ssl.Size = new Size(22, 21);
            this._ssl.TabIndex = 4;
            this._ssl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new Size(47, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "SSL";
            // 
            // _host
            // 
            this._host.BorderStyle = BorderStyle.None;
            this._host.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._host.Location = new Point(150, 12);
            this._host.Name = "_host";
            this._host.Size = new Size(285, 28);
            this._host.TabIndex = 6;
            // 
            // _port
            // 
            this._port.BorderStyle = BorderStyle.None;
            this._port.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._port.Location = new Point(150, 55);
            this._port.Name = "_port";
            this._port.Size = new Size(285, 28);
            this._port.TabIndex = 7;
            // 
            // _username
            // 
            this._username.BorderStyle = BorderStyle.None;
            this._username.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._username.Location = new Point(150, 98);
            this._username.Name = "_username";
            this._username.Size = new Size(285, 28);
            this._username.TabIndex = 8;
            // 
            // _password
            // 
            this._password.BorderStyle = BorderStyle.None;
            this._password.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._password.Location = new Point(150, 141);
            this._password.Name = "_password";
            this._password.Size = new Size(285, 28);
            this._password.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new Point(12, 286);
            this.label6.Name = "label6";
            this.label6.Size = new Size(37, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new Point(12, 329);
            this.label7.Name = "label7";
            this.label7.Size = new Size(87, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Subject";
            // 
            // _to
            // 
            this._to.BorderStyle = BorderStyle.None;
            this._to.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._to.Location = new Point(150, 286);
            this._to.Name = "_to";
            this._to.Size = new Size(285, 28);
            this._to.TabIndex = 12;
            // 
            // _subject
            // 
            this._subject.BorderStyle = BorderStyle.None;
            this._subject.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._subject.Location = new Point(150, 329);
            this._subject.Name = "_subject";
            this._subject.Size = new Size(285, 28);
            this._subject.TabIndex = 13;
            // 
            // send
            // 
            this.send.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new Point(150, 418);
            this.send.Name = "send";
            this.send.Size = new Size(110, 51);
            this.send.TabIndex = 14;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new Point(479, 12);
            this.label8.Name = "label8";
            this.label8.Size = new Size(93, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Content";
            // 
            // _content
            // 
            this._content.BorderStyle = BorderStyle.FixedSingle;
            this._content.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._content.Location = new Point(484, 58);
            this._content.Multiline = true;
            this._content.Name = "_content";
            this._content.ScrollBars = ScrollBars.Both;
            this._content.Size = new Size(585, 256);
            this._content.TabIndex = 16;
            // 
            // _attachments
            // 
            this._attachments.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this._attachments.FormattingEnabled = true;
            this._attachments.ItemHeight = 28;
            this._attachments.Location = new Point(484, 384);
            this._attachments.Name = "_attachments";
            this._attachments.Size = new Size(553, 228);
            this._attachments.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new Point(479, 338);
            this.label9.Name = "label9";
            this.label9.Size = new Size(142, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Attachments";
            // 
            // attachment_add
            // 
            this.attachment_add.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.attachment_add.Location = new Point(798, 338);
            this.attachment_add.Name = "attachment_add";
            this.attachment_add.Size = new Size(110, 39);
            this.attachment_add.TabIndex = 19;
            this.attachment_add.Text = "Add";
            this.attachment_add.UseVisualStyleBackColor = true;
            this.attachment_add.Click += new System.EventHandler(this.attachment_add_Click);
            // 
            // attachment_clear
            // 
            this.attachment_clear.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.attachment_clear.Location = new Point(927, 338);
            this.attachment_clear.Name = "attachment_clear";
            this.attachment_clear.Size = new Size(110, 39);
            this.attachment_clear.TabIndex = 20;
            this.attachment_clear.Text = "Clear";
            this.attachment_clear.UseVisualStyleBackColor = true;
            this.attachment_clear.Click += new System.EventHandler(this.attachment_clear_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new Point(145, 504);
            this.status.Name = "status";
            this.status.Size = new Size(0, 28);
            this.status.TabIndex = 21;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new SizeF(11F, 21F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1074, 649);
            this.Controls.Add(this.status);
            this.Controls.Add(this.attachment_clear);
            this.Controls.Add(this.attachment_add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._attachments);
            this.Controls.Add(this._content);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.send);
            this.Controls.Add(this._subject);
            this.Controls.Add(this._to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._password);
            this.Controls.Add(this._username);
            this.Controls.Add(this._port);
            this.Controls.Add(this._host);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._ssl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "SMTP";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox _ssl;
        private Label label5;
        private TextBox _host;
        private TextBox _port;
        private TextBox _username;
        private TextBox _password;
        private Label label6;
        private Label label7;
        private TextBox _to;
        private TextBox _subject;
        private Button send;
        private Label label8;
        private TextBox _content;
        private ListBox _attachments;
        private Label label9;
        private Button attachment_add;
        private Button attachment_clear;
        private Label status;
    }
}