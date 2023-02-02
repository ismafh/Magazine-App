namespace MagazineGUI
{
    partial class SendPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendPaper));
            this.selectorlabel = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.errorlabel = new System.Windows.Forms.Label();
            this.subbtn = new System.Windows.Forms.Button();
            this.areabox = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.verify_button = new System.Windows.Forms.Button();
            this.coauthors_label = new System.Windows.Forms.Label();
            this.coauthors1_textbox1 = new System.Windows.Forms.TextBox();
            this.coauthor2_label = new System.Windows.Forms.Label();
            this.coauthor_label2 = new System.Windows.Forms.Label();
            this.coauthors3_textbox1 = new System.Windows.Forms.TextBox();
            this.coauthors2_textbox1 = new System.Windows.Forms.TextBox();
            this.coauthors1_textbox2 = new System.Windows.Forms.TextBox();
            this.coauthors1_textbox3 = new System.Windows.Forms.TextBox();
            this.coauthors2_textbox2 = new System.Windows.Forms.TextBox();
            this.coauthors2_textbox3 = new System.Windows.Forms.TextBox();
            this.coauthors3_textbox2 = new System.Windows.Forms.TextBox();
            this.coauthors3_textbox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectorlabel
            // 
            this.selectorlabel.AutoSize = true;
            this.selectorlabel.BackColor = System.Drawing.Color.Transparent;
            this.selectorlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectorlabel.Location = new System.Drawing.Point(271, 109);
            this.selectorlabel.Name = "selectorlabel";
            this.selectorlabel.Size = new System.Drawing.Size(100, 13);
            this.selectorlabel.TabIndex = 0;
            this.selectorlabel.Text = "Seleccione un Área";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.Gray;
            this.namebox.Enabled = false;
            this.namebox.Location = new System.Drawing.Point(412, 308);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(121, 20);
            this.namebox.TabIndex = 2;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.namelabel.Location = new System.Drawing.Point(271, 311);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(101, 13);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Nombre del Artículo";
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(280, 363);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 13);
            this.errorlabel.TabIndex = 4;
            // 
            // subbtn
            // 
            this.subbtn.Location = new System.Drawing.Point(280, 405);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(75, 23);
            this.subbtn.TabIndex = 5;
            this.subbtn.Text = "Enviar";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // areabox
            // 
            this.areabox.Location = new System.Drawing.Point(412, 106);
            this.areabox.Name = "areabox";
            this.areabox.Size = new System.Drawing.Size(121, 20);
            this.areabox.TabIndex = 6;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(455, 405);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // verify_button
            // 
            this.verify_button.Location = new System.Drawing.Point(571, 104);
            this.verify_button.Name = "verify_button";
            this.verify_button.Size = new System.Drawing.Size(75, 23);
            this.verify_button.TabIndex = 8;
            this.verify_button.Text = "Verificar";
            this.verify_button.UseVisualStyleBackColor = true;
            this.verify_button.Click += new System.EventHandler(this.verify_button_Click);
            // 
            // coauthors_label
            // 
            this.coauthors_label.AutoSize = true;
            this.coauthors_label.BackColor = System.Drawing.Color.Transparent;
            this.coauthors_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coauthors_label.Location = new System.Drawing.Point(171, 203);
            this.coauthors_label.Name = "coauthors_label";
            this.coauthors_label.Size = new System.Drawing.Size(56, 13);
            this.coauthors_label.TabIndex = 9;
            this.coauthors_label.Text = "Co-autor 1";
            // 
            // coauthors1_textbox1
            // 
            this.coauthors1_textbox1.Location = new System.Drawing.Point(309, 203);
            this.coauthors1_textbox1.Name = "coauthors1_textbox1";
            this.coauthors1_textbox1.Size = new System.Drawing.Size(118, 20);
            this.coauthors1_textbox1.TabIndex = 10;
            // 
            // coauthor2_label
            // 
            this.coauthor2_label.AutoSize = true;
            this.coauthor2_label.BackColor = System.Drawing.Color.Transparent;
            this.coauthor2_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coauthor2_label.Location = new System.Drawing.Point(171, 232);
            this.coauthor2_label.Name = "coauthor2_label";
            this.coauthor2_label.Size = new System.Drawing.Size(56, 13);
            this.coauthor2_label.TabIndex = 11;
            this.coauthor2_label.Text = "Co-autor 2";
            // 
            // coauthor_label2
            // 
            this.coauthor_label2.AutoSize = true;
            this.coauthor_label2.BackColor = System.Drawing.Color.Transparent;
            this.coauthor_label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coauthor_label2.Location = new System.Drawing.Point(171, 261);
            this.coauthor_label2.Name = "coauthor_label2";
            this.coauthor_label2.Size = new System.Drawing.Size(56, 13);
            this.coauthor_label2.TabIndex = 12;
            this.coauthor_label2.Text = "Co-autor 3";
            // 
            // coauthors3_textbox1
            // 
            this.coauthors3_textbox1.Location = new System.Drawing.Point(309, 261);
            this.coauthors3_textbox1.Name = "coauthors3_textbox1";
            this.coauthors3_textbox1.Size = new System.Drawing.Size(118, 20);
            this.coauthors3_textbox1.TabIndex = 15;
            // 
            // coauthors2_textbox1
            // 
            this.coauthors2_textbox1.Location = new System.Drawing.Point(309, 232);
            this.coauthors2_textbox1.Name = "coauthors2_textbox1";
            this.coauthors2_textbox1.Size = new System.Drawing.Size(118, 20);
            this.coauthors2_textbox1.TabIndex = 16;
            // 
            // coauthors1_textbox2
            // 
            this.coauthors1_textbox2.Location = new System.Drawing.Point(447, 203);
            this.coauthors1_textbox2.Name = "coauthors1_textbox2";
            this.coauthors1_textbox2.Size = new System.Drawing.Size(100, 20);
            this.coauthors1_textbox2.TabIndex = 17;
            // 
            // coauthors1_textbox3
            // 
            this.coauthors1_textbox3.Location = new System.Drawing.Point(571, 203);
            this.coauthors1_textbox3.Name = "coauthors1_textbox3";
            this.coauthors1_textbox3.Size = new System.Drawing.Size(100, 20);
            this.coauthors1_textbox3.TabIndex = 18;
            // 
            // coauthors2_textbox2
            // 
            this.coauthors2_textbox2.Location = new System.Drawing.Point(447, 231);
            this.coauthors2_textbox2.Name = "coauthors2_textbox2";
            this.coauthors2_textbox2.Size = new System.Drawing.Size(100, 20);
            this.coauthors2_textbox2.TabIndex = 19;
            // 
            // coauthors2_textbox3
            // 
            this.coauthors2_textbox3.Location = new System.Drawing.Point(571, 231);
            this.coauthors2_textbox3.Name = "coauthors2_textbox3";
            this.coauthors2_textbox3.Size = new System.Drawing.Size(100, 20);
            this.coauthors2_textbox3.TabIndex = 20;
            // 
            // coauthors3_textbox2
            // 
            this.coauthors3_textbox2.Location = new System.Drawing.Point(447, 260);
            this.coauthors3_textbox2.Name = "coauthors3_textbox2";
            this.coauthors3_textbox2.Size = new System.Drawing.Size(100, 20);
            this.coauthors3_textbox2.TabIndex = 21;
            // 
            // coauthors3_textbox3
            // 
            this.coauthors3_textbox3.Location = new System.Drawing.Point(571, 259);
            this.coauthors3_textbox3.Name = "coauthors3_textbox3";
            this.coauthors3_textbox3.Size = new System.Drawing.Size(100, 20);
            this.coauthors3_textbox3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(324, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(455, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(591, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellidos";
            // 
            // SendPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coauthors3_textbox3);
            this.Controls.Add(this.coauthors3_textbox2);
            this.Controls.Add(this.coauthors2_textbox3);
            this.Controls.Add(this.coauthors2_textbox2);
            this.Controls.Add(this.coauthors1_textbox3);
            this.Controls.Add(this.coauthors1_textbox2);
            this.Controls.Add(this.coauthors2_textbox1);
            this.Controls.Add(this.coauthors3_textbox1);
            this.Controls.Add(this.coauthor_label2);
            this.Controls.Add(this.coauthor2_label);
            this.Controls.Add(this.coauthors1_textbox1);
            this.Controls.Add(this.coauthors_label);
            this.Controls.Add(this.verify_button);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.areabox);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.selectorlabel);
            this.Name = "SendPaper";
            this.Text = "SendPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectorlabel;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.TextBox areabox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button verify_button;
        private System.Windows.Forms.Label coauthors_label;
        private System.Windows.Forms.TextBox coauthors1_textbox1;
        private System.Windows.Forms.Label coauthor2_label;
        private System.Windows.Forms.Label coauthor_label2;
        private System.Windows.Forms.TextBox coauthors3_textbox1;
        private System.Windows.Forms.TextBox coauthors2_textbox1;
        private System.Windows.Forms.TextBox coauthors1_textbox2;
        private System.Windows.Forms.TextBox coauthors1_textbox3;
        private System.Windows.Forms.TextBox coauthors2_textbox2;
        private System.Windows.Forms.TextBox coauthors2_textbox3;
        private System.Windows.Forms.TextBox coauthors3_textbox2;
        private System.Windows.Forms.TextBox coauthors3_textbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}