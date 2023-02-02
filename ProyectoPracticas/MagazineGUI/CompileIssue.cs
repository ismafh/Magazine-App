using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Persistence;
using Magazine.Services;

namespace MagazineGUI
{
    public partial class CompileIssue : Form
    {
        Issue current;
        String date;
        Area area;
        Magazine.Entities.Magazine mag;

        private IMagazineService service;
        public CompileIssue(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            mag = service.GetAllMagazines().First();
            current = mag.LastIssueNotPublished();
            date = DateTime.Now.ToString();
            datelabel.Text = "Upload Date: " + date;
        }

        private void CompileIssue_Load(object sender, EventArgs e)
        {
            ICollection<Area> areas = mag.Areas;
            if (areas != null)
                foreach (Area a in areas)
                {
                    areabox.Items.Add(a.Name);
                }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Form back = new MagazineServices(service);
            back.Show();
            this.Close();
        }

        private void areabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            make_tableno();
            make_tableyes();

        }
        private void make_tableno()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string name = (string)areabox.SelectedItem;
            area = service.FindAreaByName(name);

            ICollection<Paper> toPublish = area.PublicationPending;


            BindingList<object> bindinglist1 = new BindingList<object>();

            foreach (Paper p in toPublish)
            {

                bindinglist1.Add(new
                {
                    data1_Title = p.Title,
                    data1_Author = p.Responsible.Name,
                    data1_Date = p.UploadDate,
                });

            }
            bindingSource1.DataSource = bindinglist1;
            dataGridView1.ClearSelection();
        }

        private void make_tableyes()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            string nombre = (string)areabox.SelectedItem;
            area = service.FindAreaByName(nombre);

            ICollection<Paper> PapersInIssue = current.PublishedPapers;
            BindingList<object> bindinglist2 = new BindingList<object>();

            foreach (Paper pp in PapersInIssue)
            {
                bindinglist2.Add(new
                {
                    data2_Title = pp.Title,
                    data2_Author = pp.Responsible.Name,
                    data2_Date = pp.UploadDate,
                });
            }
            bindingSource2.DataSource = bindinglist2;
            dataGridView2.ClearSelection();
        }
        private void changebtn_Click(object sender, EventArgs e)
        {
            current.PublicationDate = dateTimePicker1.Value;
            date = current.PublicationDate.ToString();
            datelabel.Text = "Upload Date: " + date;
        }

        private void topublishbtn_Click(object sender, EventArgs e)
        {
            //add
            Paper p = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                p = service.FindPaperByName(row.Cells[0].Value.ToString());
                service.addPublish(current, area, p);
            }
            make_tableno();
            make_tableyes();
        }

        private void frompublishbtn_Click(object sender, EventArgs e)
        {
            Paper p = null;
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                p = service.FindPaperByName(row.Cells[0].Value.ToString());
                current.PublishedPapers.Remove(p);
                area.PublicationPending.Add(p); 
                
            }
            make_tableno();
            make_tableyes();
        }
    }
}