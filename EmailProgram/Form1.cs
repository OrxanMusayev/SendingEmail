using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace EmailProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage("orxanmusayev2910@gmail.com", txtto.Text, txtSubject.Text, txtBody.Text);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential("orxanmusayev2910@gmail.com", "Orxan2910");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                MessageBox.Show("Mail göndərildi");
                //mailMessage.IsBodyHtml = true;
                //mailMessage.Priority = MailPriority.Normal;
                //mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //smtpClient.UseDefaultCredentials = false;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Mail göndərilmədi... " +exc.Message);           
            }
        }
    }
}
