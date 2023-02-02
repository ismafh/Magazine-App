
namespace MagazineGUI
{
    partial class ViewArticles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewArticles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belongingAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationPendingAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationPendingAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coAuthorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closebtn = new System.Windows.Forms.Button();
            this.filtercheckbox = new System.Windows.Forms.CheckBox();
            this.filtertextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.uploadDateDataGridViewTextBoxColumn,
            this.responsibleDataGridViewTextBoxColumn,
            this.belongingAreaDataGridViewTextBoxColumn,
            this.evaluationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paperBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // uploadDateDataGridViewTextBoxColumn
            // 
            this.uploadDateDataGridViewTextBoxColumn.DataPropertyName = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.HeaderText = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.Name = "uploadDateDataGridViewTextBoxColumn";
            // 
            // responsibleDataGridViewTextBoxColumn
            // 
            this.responsibleDataGridViewTextBoxColumn.DataPropertyName = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.HeaderText = "Responsible";
            this.responsibleDataGridViewTextBoxColumn.Name = "responsibleDataGridViewTextBoxColumn";
            // 
            // belongingAreaDataGridViewTextBoxColumn
            // 
            this.belongingAreaDataGridViewTextBoxColumn.DataPropertyName = "BelongingArea";
            this.belongingAreaDataGridViewTextBoxColumn.HeaderText = "BelongingArea";
            this.belongingAreaDataGridViewTextBoxColumn.Name = "belongingAreaDataGridViewTextBoxColumn";
            // 
            // evaluationDataGridViewTextBoxColumn
            // 
            this.evaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.Name = "evaluationDataGridViewTextBoxColumn";
            // 
            // paperBindingSource
            // 
            this.paperBindingSource.DataSource = typeof(Magazine.Entities.Paper);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // evaluationPendingAreaDataGridViewTextBoxColumn
            // 
            this.evaluationPendingAreaDataGridViewTextBoxColumn.Name = "evaluationPendingAreaDataGridViewTextBoxColumn";
            // 
            // publicationPendingAreaDataGridViewTextBoxColumn
            // 
            this.publicationPendingAreaDataGridViewTextBoxColumn.Name = "publicationPendingAreaDataGridViewTextBoxColumn";
            // 
            // issueDataGridViewTextBoxColumn
            // 
            this.issueDataGridViewTextBoxColumn.Name = "issueDataGridViewTextBoxColumn";
            // 
            // coAuthorsDataGridViewTextBoxColumn
            // 
            this.coAuthorsDataGridViewTextBoxColumn.Name = "coAuthorsDataGridViewTextBoxColumn";
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(623, 397);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(165, 41);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "Close viewer";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // filtercheckbox
            // 
            this.filtercheckbox.AutoSize = true;
            this.filtercheckbox.BackColor = System.Drawing.Color.Transparent;
            this.filtercheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filtercheckbox.Location = new System.Drawing.Point(120, 48);
            this.filtercheckbox.Name = "filtercheckbox";
            this.filtercheckbox.Size = new System.Drawing.Size(105, 17);
            this.filtercheckbox.TabIndex = 4;
            this.filtercheckbox.Text = "Filter by Issue Nº";
            this.filtercheckbox.UseVisualStyleBackColor = false;
            // 
            // filtertextbox
            // 
            this.filtertextbox.Location = new System.Drawing.Point(258, 48);
            this.filtertextbox.Name = "filtertextbox";
            this.filtertextbox.Size = new System.Drawing.Size(100, 20);
            this.filtertextbox.TabIndex = 5;
            this.filtertextbox.TextChanged += new System.EventHandler(this.filterApplied);
            // 
            // ViewArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtertextbox);
            this.Controls.Add(this.filtercheckbox);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewArticles";
            this.Text = "ViewArticles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paperBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn belongingAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coAuthorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationPendingAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationPendingAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.CheckBox filtercheckbox;
        private System.Windows.Forms.TextBox filtertextbox;
    }
}