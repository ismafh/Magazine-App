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
    public partial class SendPaper : Form
    {
        private IMagazineService service;
        public SendPaper(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            //estaria apagado hasta que no se seleccione el area
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            Paper p = new Paper
            {
                Title = namebox.Text,
                UploadDate = DateTime.Now,
                BelongingArea = service.FindAreaByName(areabox.Text),
                Responsible = service.UserLogged(),
            };

            //add ppl

            if (coauthors1_textbox1.Text != "" && coauthors1_textbox2.Text != "" && coauthors1_textbox3.Text != "")
            {
                Person persona = service.FindPersonById(coauthors1_textbox1.Text);
                if (persona == null)
                {
                    Person co1 = new Person
                    {
                        Id = coauthors1_textbox1.Text,
                        Name = coauthors1_textbox2.Text,
                        Surname = coauthors1_textbox3.Text,
                    };
                    p.addCoAuthor(co1);
                }
                else
                {
                    p.addCoAuthor(persona);
                }
            }
            if (coauthors2_textbox1.Text != "" && coauthors2_textbox2.Text != "" && coauthors2_textbox3.Text != "")
            {
                Person persona = service.FindPersonById(coauthors2_textbox1.Text);
                if (persona == null)
                {
                    Person co2 = new Person
                    {
                        Id = coauthors2_textbox1.Text,
                        Name = coauthors2_textbox2.Text,
                        Surname = coauthors2_textbox3.Text
                    };
                    p.addCoAuthor(co2);
                }
                else
                {
                    p.addCoAuthor(persona);
                }
            }
            if (coauthors3_textbox1.Text != "" && coauthors3_textbox2.Text != "" && coauthors3_textbox3.Text != "")
            {
                Person persona = service.FindPersonById(coauthors3_textbox1.Text);
                if (persona == null)
                {
                    Person co3 = new Person
                    {
                        Id = coauthors3_textbox1.Text,
                        Name = coauthors3_textbox2.Text,
                        Surname = coauthors3_textbox3.Text
                    };
                    p.addCoAuthor(co3);
                }
                else
                {
                    p.addCoAuthor(persona);
                }
            }

            service.AddPaper(p);
            Form back = new MagazineServices(service);
            back.Show();
            this.Close();

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Form back = new MagazineServices(service);
            back.Show();
            this.Close();
        }

        private void verify_button_Click(object sender, EventArgs e)
        {
            errorlabel.Text = "";
            try
            {
                if (areabox.Text != "")
                {
                    service.FindAreaByName(areabox.Text);
                    namebox.Enabled = true;
                    namebox.BackColor = Color.White;
                }
                else
                    errorlabel.Text = "Por favor, introduzca un área válida";
            }
            catch (Exception)
            {
                errorlabel.Text = "Error: area doesn't exist";
                namebox.Enabled = false;
                namebox.BackColor = Color.Gray;
            }
        }
    }
}
