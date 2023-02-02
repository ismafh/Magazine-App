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
    public partial class MagazineAppLogin : Form
    {
        private IMagazineService service;
        public MagazineAppLogin(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            passwordbox.UseSystemPasswordChar = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            try
            {
                service.Login(usernamebox.Text, passwordbox.Text);
                Form services = new MagazineServices(service);
                services.Show();
                this.Close();
            }
            catch(ServiceException)
            {
                errorlabel.Text = "Error: no se encuentra una cuenta con estos credenciales";
            }
            catch (Exception)
            {
                errorlabel.Text = "Error: no se encuentra una cuenta con estos credenciales";
            }
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
