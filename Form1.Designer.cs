namespace CsharpApi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbdate = new System.Windows.Forms.TextBox();
            this.txtbplace = new System.Windows.Forms.TextBox();
            this.txtschool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 465);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(25, 21);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1086, 346);
            this.txtOutput.TabIndex = 4;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGet.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(330, 391);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(484, 57);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtschool);
            this.groupBox2.Controls.Add(this.txtbplace);
            this.groupBox2.Controls.Add(this.txtbdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnPost);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1127, 286);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPost.Location = new System.Drawing.Point(330, 214);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(484, 57);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 148);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 97);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(399, 35);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 45);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(399, 37);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(603, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbdate
            // 
            this.txtbdate.Location = new System.Drawing.Point(689, 45);
            this.txtbdate.Multiline = true;
            this.txtbdate.Name = "txtbdate";
            this.txtbdate.Size = new System.Drawing.Size(399, 34);
            this.txtbdate.TabIndex = 8;
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(689, 94);
            this.txtbplace.Multiline = true;
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(399, 39);
            this.txtbplace.TabIndex = 9;
            // 
            // txtschool
            // 
            this.txtschool.Location = new System.Drawing.Point(689, 148);
            this.txtschool.Multiline = true;
            this.txtschool.Name = "txtschool";
            this.txtschool.Size = new System.Drawing.Size(399, 31);
            this.txtschool.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(597, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthplace:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(609, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "School:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1165, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#-MYSQL API Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtschool;
        private System.Windows.Forms.TextBox txtbplace;
        private System.Windows.Forms.TextBox txtbdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

