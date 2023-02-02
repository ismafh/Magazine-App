using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Services;

namespace MagazineGUI
{
    public partial class MagazineAppSignup : Form
    {
        private IMagazineService service;
        public MagazineAppSignup(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            passwordbox.UseSystemPasswordChar = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Id = idbox.Text;
            u.Name = namebox.Text;
            u.Surname = surnamebox.Text;
            u.Alerted = checkBox1.Checked;
            u.AreasOfInterest = interestbox.Text;
            u.Email = emailbox.Text;
            u.Login = textBox1.Text;
            u.Password = passwordbox.Text;

            try
            {
                service.AddUser(u);

                Form services = new MagazineServices(service);
                services.Show();
                this.Close();
            }
            catch (ServiceException)
            {
                errorlabel.Text = "Error: User already exists.";
            } catch (Exception)
            {
                errorlabel.Text = "Error: The data introduced is incorrect, check your credentials";
            }

        }
    }
}
