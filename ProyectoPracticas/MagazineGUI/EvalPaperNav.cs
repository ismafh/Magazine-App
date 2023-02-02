using Magazine.Entities;
using Magazine.Persistence;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazineGUI
{
    public partial class EvalPaperNav : Form
    {
        private Paper temp;

        private IMagazineService service;
        public EvalPaperNav(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            Area user = service.UserLogged().Area;
            ICollection<Paper> papers = user.getEval();

            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Paper p in papers)
            {
                bindinglist.Add(new
                {
                    Name = p.Title,
                    Author = p.Responsible.Name,
                    UploadDate = p.UploadDate
                });
            }
            areaBindingSource.DataSource = bindinglist;
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (temp == null)
                return;
            else
            {
                service.EvaluatePaper(temp, acceptbox.Checked, textBox1.Text);
                textBox1.Clear();
                temp = null;
                label5.Text = "Choose and Article";

                LoadData();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Form back = new MagazineServices(service);
            back.Show();
            this.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string value = "";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    value = row.Cells[0].Value.ToString();
                }
                temp = service.FindPaperByName(value);
                label5.Text = "Evaulating " + value;
                textBox1.Clear();
            }
        }
    }
}
