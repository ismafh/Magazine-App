namespace MagazineGUI
{
    partial class MagazineAppSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineAppSignup));
            this.cancelbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.surnamebox = new System.Windows.Forms.TextBox();
            this.interestbox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.errorlabel = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(681, 398);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(337, 309);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(111, 49);
            this.nextbtn.TabIndex = 3;
            this.nextbtn.Text = "Registrarse";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.AutoSize = true;
            this.usernamebox.BackColor = System.Drawing.Color.Transparent;
            this.usernamebox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamebox.Location = new System.Drawing.Point(261, 222);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(43, 13);
            this.usernamebox.TabIndex = 4;
            this.usernamebox.Text = "Usuario";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordlabel.Location = new System.Drawing.Point(261, 252);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(61, 13);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(436, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordbox.Location = new System.Drawing.Point(436, 249);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(100, 20);
            this.passwordbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(261, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(261, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(261, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Áreas de interes";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emaillabel.Location = new System.Drawing.Point(261, 192);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(94, 13);
            this.emaillabel.TabIndex = 12;
            this.emaillabel.Text = "Correo Electrónico";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(307, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Deseo recibir alertas por e-mail";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.Info;
            this.namebox.Location = new System.Drawing.Point(436, 99);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 20);
            this.namebox.TabIndex = 14;
            // 
            // surnamebox
            // 
            this.surnamebox.BackColor = System.Drawing.SystemColors.Info;
            this.surnamebox.Location = new System.Drawing.Point(436, 129);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(100, 20);
            this.surnamebox.TabIndex = 15;
            // 
            // interestbox
            // 
            this.interestbox.BackColor = System.Drawing.SystemColors.Info;
            this.interestbox.Location = new System.Drawing.Point(436, 159);
            this.interestbox.Name = "interestbox";
            this.interestbox.Size = new System.Drawing.Size(100, 20);
            this.interestbox.TabIndex = 16;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.SystemColors.Info;
            this.emailbox.Location = new System.Drawing.Point(436, 189);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(100, 20);
            this.emailbox.TabIndex = 17;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(264, 76);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 13);
            this.errorlabel.TabIndex = 18;
            // 
            // idbox
            // 
            this.idbox.BackColor = System.Drawing.SystemColors.Info;
            this.idbox.Location = new System.Drawing.Point(436, 69);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 19;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.Transparent;
            this.idlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idlabel.Location = new System.Drawing.Point(261, 72);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 20;
            this.idlabel.Text = "ID";
            // 
            // MagazineAppSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.interestbox);
            this.Controls.Add(this.surnamebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.cancelbtn);
            this.Name = "MagazineAppSignup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Label usernamebox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox surnamebox;
        private System.Windows.Forms.TextBox interestbox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label idlabel;
    }
}