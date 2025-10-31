using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MailSender
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            _attachments.KeyDown += AttachmentsKeyDown;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            _host.Text = ConfigurationManager.AppSettings["host"] ?? "";
            _port.Text = ConfigurationManager.AppSettings["port"] ?? "";
            _ssl.Checked = bool.Parse(ConfigurationManager.AppSettings["ssl"] ?? "false");
            _username.Text = ConfigurationManager.AppSettings["username"] ?? "";
            _password.Text = ConfigurationManager.AppSettings["password"] ?? "";
            _to.Text = ConfigurationManager.AppSettings["to"] ?? "";
            _subject.Text = ConfigurationManager.AppSettings["subject"] ?? "";
        }

        #region mail

        private void Mail(string body)
        {
            var host = _host.Text;
            var port = int.Parse(_port.Text);
            var ssl = _ssl.Checked;
            var username = _username.Text;
            var password = _password.Text;
            var to = _to.Text;
            var subject = _subject.Text;

            using (var mail = new MailMessage(username, to, subject, body))
            {
                mail.IsBodyHtml = false;
                AttachmentsFollow(mail);

                try
                {
                    using (var smtp = new SmtpClient(host, port))
                    {
                        smtp.Credentials = new NetworkCredential(username, password);
                        smtp.EnableSsl = ssl;
                        smtp.Timeout = 10000;

                        smtp.Send(mail);
                    }

                    status.Text = "success";
                    _attachments.Items.Clear();
                }
                catch (Exception ex)
                {
                    status.Text = $"error: {ex.Message}";
                }
            }
        }

        private void AttachmentsFollow(MailMessage mail)
        {
            if (_attachments.Items.Count == 0) return;

            foreach (string obj in _attachments.Items)
                if (File.Exists(obj))
                {
                    try
                    {
                        var attachment = new Attachment(obj);
                        mail.Attachments.Add(attachment);
                    }
                    catch (Exception)
                    {
                    }
                }
        }

        #endregion

        #region button

        private void send_Click(object sender, EventArgs e)
        {
            var body = _content.Text;
            var empty = _attachments.Items.Count <= 0 && string.IsNullOrWhiteSpace(body);

            if (empty) return;

            Mail(body);
        }

        private void attachment_add_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;

                if (dialog.ShowDialog() != DialogResult.OK) return;

                foreach (var obj in dialog.FileNames)
                    if (!_attachments.Items.Contains(obj))
                    {
                        _attachments.Items.Add(obj);
                    }
            }
        }

        private void attachment_clear_Click(object sender, EventArgs e)
        {
            _attachments.Items.Clear();
        }

        #endregion

        #region clipboard

        private void AttachmentsKeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.V)) return;

            e.Handled = true;
            try
            {
                if (!Clipboard.ContainsImage()) return;

                var image = Clipboard.GetImage();
                if (image == null) return;

                var tempFile = ImageTempSave(image);
                if (!string.IsNullOrEmpty(tempFile) && !_attachments.Items.Contains(tempFile))
                {
                    _attachments.Items.Add(tempFile);
                }
            }
            catch (Exception)
            {
            }
        }

        private static string ImageTempSave(Image image)
        {
            try
            {
                var tempFile = Path.Combine(Path.GetTempPath(), $"image_{DateTime.Now:yyyyMMddHHmmss}.png");
                using (image)
                {
                    image.Save(tempFile, ImageFormat.Png);
                }

                return tempFile;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
    }
}