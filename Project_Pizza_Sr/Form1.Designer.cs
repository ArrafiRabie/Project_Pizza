namespace Project_Pizza_Sr
{
    partial class Login_Page
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
            this.LB_Title_Forme_Login = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Passworde = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_Passworde = new System.Windows.Forms.Label();
            this.BT_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Title_Forme_Login
            // 
            this.LB_Title_Forme_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Title_Forme_Login.AutoSize = true;
            this.LB_Title_Forme_Login.BackColor = System.Drawing.Color.Transparent;
            this.LB_Title_Forme_Login.Font = new System.Drawing.Font("Forte", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title_Forme_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LB_Title_Forme_Login.Location = new System.Drawing.Point(199, 37);
            this.LB_Title_Forme_Login.Name = "LB_Title_Forme_Login";
            this.LB_Title_Forme_Login.Size = new System.Drawing.Size(774, 105);
            this.LB_Title_Forme_Login.TabIndex = 0;
            this.LB_Title_Forme_Login.Text = "Make Your Pizza";
            // 
            // TB_Email
            // 
            this.TB_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Email.Location = new System.Drawing.Point(387, 210);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(329, 20);
            this.TB_Email.TabIndex = 1;
            this.TB_Email.Tag = "RabieArrafi@gmail.com";
            // 
            // TB_Passworde
            // 
            this.TB_Passworde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Passworde.Location = new System.Drawing.Point(387, 264);
            this.TB_Passworde.Name = "TB_Passworde";
            this.TB_Passworde.Size = new System.Drawing.Size(329, 20);
            this.TB_Passworde.TabIndex = 2;
            // 
            // LB_Email
            // 
            this.LB_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Email.AutoSize = true;
            this.LB_Email.BackColor = System.Drawing.Color.Transparent;
            this.LB_Email.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LB_Email.Location = new System.Drawing.Point(162, 210);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(215, 22);
            this.LB_Email.TabIndex = 3;
            this.LB_Email.Text = "Please Enter Email";
            // 
            // LB_Passworde
            // 
            this.LB_Passworde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Passworde.AutoSize = true;
            this.LB_Passworde.BackColor = System.Drawing.Color.Transparent;
            this.LB_Passworde.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Passworde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LB_Passworde.Location = new System.Drawing.Point(108, 262);
            this.LB_Passworde.Name = "LB_Passworde";
            this.LB_Passworde.Size = new System.Drawing.Size(269, 22);
            this.LB_Passworde.TabIndex = 4;
            this.LB_Passworde.Tag = "7991";
            this.LB_Passworde.Text = "Please Enter Passworde";
            // 
            // BT_Login
            // 
            this.BT_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BT_Login.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Login.Location = new System.Drawing.Point(424, 299);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(207, 29);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "Enter";
            this.BT_Login.UseVisualStyleBackColor = false;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pizza_Sr.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 602);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.LB_Passworde);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.TB_Passworde);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.LB_Title_Forme_Login);
            this.Name = "Login_Page";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Forme_Login;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Passworde;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_Passworde;
        private System.Windows.Forms.Button BT_Login;
    }
}

