namespace MagazineGUI
{
    partial class CompileIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompileIssue));
            this.label2 = new System.Windows.Forms.Label();
            this.areabox = new System.Windows.Forms.ComboBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data1_Tit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data1_Aut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data1_Dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.data2_Tit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2_Aut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2_Dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.changebtn = new System.Windows.Forms.Button();
            this.frompublishbtn = new System.Windows.Forms.Button();
            this.topublishbtn = new System.Windows.Forms.Button();
            this.sendbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(76, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Viewing area:";
            // 
            // areabox
            // 
            this.areabox.FormattingEnabled = true;
            this.areabox.Location = new System.Drawing.Point(78, 258);
            this.areabox.Margin = new System.Windows.Forms.Padding(2);
            this.areabox.Name = "areabox";
            this.areabox.Size = new System.Drawing.Size(92, 21);
            this.areabox.TabIndex = 5;
            this.areabox.SelectedIndexChanged += new System.EventHandler(this.areabox_SelectedIndexChanged);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(12, 382);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Cancelar";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data1_Tit,
            this.data1_Aut,
            this.data1_Dat});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(329, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // data1_Tit
            // 
            this.data1_Tit.DataPropertyName = "data1_Title";
            this.data1_Tit.HeaderText = "Title";
            this.data1_Tit.Name = "data1_Tit";
            this.data1_Tit.ReadOnly = true;
            this.data1_Tit.Width = 120;
            // 
            // data1_Aut
            // 
            this.data1_Aut.DataPropertyName = "data1_Author";
            this.data1_Aut.HeaderText = "Author";
            this.data1_Aut.Name = "data1_Aut";
            this.data1_Aut.ReadOnly = true;
            this.data1_Aut.Width = 110;
            // 
            // data1_Dat
            // 
            this.data1_Dat.DataPropertyName = "data1_Date";
            this.data1_Dat.HeaderText = "Date";
            this.data1_Dat.Name = "data1_Dat";
            this.data1_Dat.ReadOnly = true;
            this.data1_Dat.Width = 110;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data2_Tit,
            this.data2_Aut,
            this.data2_Dat});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(329, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(383, 150);
            this.dataGridView2.TabIndex = 8;
            // 
            // data2_Tit
            // 
            this.data2_Tit.DataPropertyName = "data2_Title";
            this.data2_Tit.HeaderText = "Title";
            this.data2_Tit.Name = "data2_Tit";
            this.data2_Tit.ReadOnly = true;
            this.data2_Tit.Width = 120;
            // 
            // data2_Aut
            // 
            this.data2_Aut.DataPropertyName = "data2_Author";
            this.data2_Aut.HeaderText = "Author";
            this.data2_Aut.Name = "data2_Aut";
            this.data2_Aut.ReadOnly = true;
            this.data2_Aut.Width = 110;
            // 
            // data2_Dat
            // 
            this.data2_Dat.DataPropertyName = "data2_Date";
            this.data2_Dat.HeaderText = "Date";
            this.data2_Dat.Name = "data2_Dat";
            this.data2_Dat.ReadOnly = true;
            this.data2_Dat.Width = 110;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.datelabel.Location = new System.Drawing.Point(79, 102);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(70, 13);
            this.datelabel.TabIndex = 10;
            this.datelabel.Text = "Upload Date:";
            // 
            // changebtn
            // 
            this.changebtn.Location = new System.Drawing.Point(79, 156);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(75, 23);
            this.changebtn.TabIndex = 11;
            this.changebtn.Text = "Change";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // frompublishbtn
            // 
            this.frompublishbtn.Location = new System.Drawing.Point(485, 199);
            this.frompublishbtn.Name = "frompublishbtn";
            this.frompublishbtn.Size = new System.Drawing.Size(80, 23);
            this.frompublishbtn.TabIndex = 12;
            this.frompublishbtn.Text = "remove";
            this.frompublishbtn.UseVisualStyleBackColor = true;
            this.frompublishbtn.Click += new System.EventHandler(this.frompublishbtn_Click);
            // 
            // topublishbtn
            // 
            this.topublishbtn.Location = new System.Drawing.Point(355, 199);
            this.topublishbtn.Name = "topublishbtn";
            this.topublishbtn.Size = new System.Drawing.Size(75, 23);
            this.topublishbtn.TabIndex = 13;
            this.topublishbtn.Text = "add";
            this.topublishbtn.UseVisualStyleBackColor = true;
            this.topublishbtn.Click += new System.EventHandler(this.topublishbtn_Click);
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(115, 382);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 14;
            this.sendbtn.Text = "Compile Issue";
            this.sendbtn.UseVisualStyleBackColor = true;
            // 
            // CompileIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 417);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.topublishbtn);
            this.Controls.Add(this.frompublishbtn);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.areabox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompileIssue";
            this.Text = "CompileIssue";
            this.Load += new System.EventHandler(this.CompileIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox areabox;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn papersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationPendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationPendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.Button frompublishbtn;
        private System.Windows.Forms.Button topublishbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1_Tit;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1_Aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1_Dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn data2_Tit;
        private System.Windows.Forms.DataGridViewTextBoxColumn data2_Aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn data2_Dat;
        private System.Windows.Forms.Button sendbtn;
    }
}