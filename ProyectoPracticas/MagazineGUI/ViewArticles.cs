
using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    public partial class ViewArticles : Form
    {
        string status;

        private IMagazineService service;
        public ViewArticles(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }


        public void LoadData()
        {
            ICollection<Paper> papers = service.GetAllPapers();
            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Paper p in papers)
            {
                //if it is not in a pending area in any area
                if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null)
                    status = "Published";
                if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea != null)
                    status = "To Publish";
                if (p.BelongingArea != null && p.EvaluationPendingArea != null && p.PublicationPendingArea == null)
                    status = "Evaluating";
                if (p.BelongingArea == null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null) 
                    status = "Rejected";
                bindinglist.Add(new
                {
                    Title = p.Title,
                    UploadDate = p.UploadDate,
                    Responsible = p.Responsible.Name,
                    Evaluation = status,
                    BelongingArea = p.BelongingArea.Name
                });
            }
            paperBindingSource.DataSource = bindinglist;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Form back = new MagazineServices(service);
            back.Show();
            this.Close();
        }

        private void filterApplied(object sender, EventArgs e)
        {
            ICollection<Paper> limitedlist = service.ListPapersByArea();

            BindingList<object> bindinglist = new BindingList<object>();

            if (filtercheckbox.Checked)
            {
                foreach (Paper p in limitedlist)
                {
                    if (p.Issue != null && p.Issue.Number.ToString() == filtertextbox.Text)
                    {
                        if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null)
                            status = "Published";
                        if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea != null)
                            status = "To Publish";
                        if (p.BelongingArea != null && p.EvaluationPendingArea != null && p.PublicationPendingArea == null)
                            status = "Evaluating";
                        if (p.BelongingArea == null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null)
                            status = "Rejected";
                        bindinglist.Add(new
                        {
                            Title = p.Title,
                            UploadDate = p.UploadDate,
                            Responsible = p.Responsible.Name,
                            Evaluation = status,
                            BelongingArea = p.BelongingArea.Name
                        });
                    }
                }
                paperBindingSource.DataSource = bindinglist;
            }
            else
            {
                foreach (Paper p in limitedlist)
                {
                    if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null)
                        status = "Published";
                    if (p.BelongingArea != null && p.EvaluationPendingArea == null && p.PublicationPendingArea != null)
                        status = "To Publish";
                    if (p.BelongingArea != null && p.EvaluationPendingArea != null && p.PublicationPendingArea == null)
                        status = "Evaluating";
                    if (p.BelongingArea == null && p.EvaluationPendingArea == null && p.PublicationPendingArea == null)
                        status = "Rejected";
                    bindinglist.Add(new
                    {
                        Title = p.Title,
                        UploadDate = p.UploadDate,
                        Responsible = p.Responsible.Name,
                        Evaluation = status,
                        BelongingArea = p.BelongingArea.Name
                    });
                }
                paperBindingSource.DataSource = bindinglist;
            }
        }
    }
}