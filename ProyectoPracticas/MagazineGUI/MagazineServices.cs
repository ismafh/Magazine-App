using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;

namespace MagazineGUI
{
    public partial class MagazineServices : Form
    {
        private IMagazineService service;
        public MagazineServices(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            service.Logout();
            this.Close();
        }

        private void sendpaperbtn_Click(object sender, EventArgs e)
        {
            Form sendPaper = new SendPaper(service);
            sendPaper.Show();
            this.Close();
        }

        private void evaluatebtn_Click(object sender, EventArgs e)
        {
            Form evaluatePaper = new EvalPaperNav(service);
            evaluatePaper.Show();
            this.Close();
        }

        private void compileissuebtn_Click(object sender, EventArgs e)
        {
            Form compileIssue = new CompileIssue(service);
            compileIssue.Show();
            this.Close();
        }

        private void viewerbtn_Click(object sender, EventArgs e)
        {
            Form viewer = new ViewArticles(service);
            viewer.Show();
            this.Close();

        }
    }
}
