namespace MagazineGUI
{
    partial class MagazineServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineServices));
            this.logoutbtn = new System.Windows.Forms.Button();
            this.sendpaperbtn = new System.Windows.Forms.Button();
            this.evaluatebtn = new System.Windows.Forms.Button();
            this.compileissuebtn = new System.Windows.Forms.Button();
            this.viewerbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(707, 398);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // sendpaperbtn
            // 
            this.sendpaperbtn.Location = new System.Drawing.Point(29, 75);
            this.sendpaperbtn.Name = "sendpaperbtn";
            this.sendpaperbtn.Size = new System.Drawing.Size(138, 30);
            this.sendpaperbtn.TabIndex = 1;
            this.sendpaperbtn.Text = "Submit paper";
            this.sendpaperbtn.UseVisualStyleBackColor = true;
            this.sendpaperbtn.Click += new System.EventHandler(this.sendpaperbtn_Click);
            // 
            // evaluatebtn
            // 
            this.evaluatebtn.Location = new System.Drawing.Point(29, 341);
            this.evaluatebtn.Name = "evaluatebtn";
            this.evaluatebtn.Size = new System.Drawing.Size(138, 34);
            this.evaluatebtn.TabIndex = 2;
            this.evaluatebtn.Text = "Evaluate paper";
            this.evaluatebtn.UseVisualStyleBackColor = true;
            this.evaluatebtn.Click += new System.EventHandler(this.evaluatebtn_Click);
            // 
            // compileissuebtn
            // 
            this.compileissuebtn.Location = new System.Drawing.Point(29, 154);
            this.compileissuebtn.Name = "compileissuebtn";
            this.compileissuebtn.Size = new System.Drawing.Size(138, 32);
            this.compileissuebtn.TabIndex = 3;
            this.compileissuebtn.Text = "Compile issue";
            this.compileissuebtn.UseVisualStyleBackColor = true;
            this.compileissuebtn.Click += new System.EventHandler(this.compileissuebtn_Click);
            // 
            // viewerbtn
            // 
            this.viewerbtn.Location = new System.Drawing.Point(29, 248);
            this.viewerbtn.Name = "viewerbtn";
            this.viewerbtn.Size = new System.Drawing.Size(138, 33);
            this.viewerbtn.TabIndex = 4;
            this.viewerbtn.Text = "See All Articles";
            this.viewerbtn.UseVisualStyleBackColor = true;
            this.viewerbtn.Click += new System.EventHandler(this.viewerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(187, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para subir algun tipo de revista, periodico, etc.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(187, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confeccionar un ejemplar\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(187, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ver todos los articulos existentes\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(187, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Para subir algun tipo de revista, periodico, etc.\r\n";
            // 
            // MagazineServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewerbtn);
            this.Controls.Add(this.compileissuebtn);
            this.Controls.Add(this.evaluatebtn);
            this.Controls.Add(this.sendpaperbtn);
            this.Controls.Add(this.logoutbtn);
            this.Name = "MagazineServices";
            this.Text = "MagazineServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button sendpaperbtn;
        private System.Windows.Forms.Button evaluatebtn;
        private System.Windows.Forms.Button compileissuebtn;
        private System.Windows.Forms.Button viewerbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}