namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblAppname = new Label();
            txtID = new TextBox();
            txtpw = new TextBox();
            btnLogin = new Button();
            lblerrormsg = new Label();
            SuspendLayout();
            // 
            // LblAppname
            // 
            LblAppname.AutoSize = true;
            LblAppname.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAppname.Location = new Point(187, 12);
            LblAppname.Name = "LblAppname";
            LblAppname.Size = new Size(361, 159);
            LblAppname.TabIndex = 0;
            LblAppname.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(197, 174);
            txtID.Name = "txtID";
            txtID.Size = new Size(340, 43);
            txtID.TabIndex = 2;
            txtID.Text = "ID";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtpw
            // 
            txtpw.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpw.ForeColor = Color.Silver;
            txtpw.Location = new Point(197, 242);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(340, 43);
            txtpw.TabIndex = 3;
            txtpw.Text = "Password";
            txtpw.TextChanged += textBox2_TextChanged;
            txtpw.Enter += txtpw_Enter;
            txtpw.KeyDown += txtpw_KeyDown;
            txtpw.Leave += txtpw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(264, 341);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(206, 82);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // lblerrormsg
            // 
            lblerrormsg.AutoSize = true;
            lblerrormsg.ForeColor = Color.Red;
            lblerrormsg.Location = new Point(252, 302);
            lblerrormsg.Name = "lblerrormsg";
            lblerrormsg.Size = new Size(285, 20);
            lblerrormsg.TabIndex = 4;
            lblerrormsg.Text = "*아이디 또는 패스워드가 잘못되었습니다.";
            lblerrormsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblerrormsg);
            Controls.Add(btnLogin);
            Controls.Add(txtpw);
            Controls.Add(txtID);
            Controls.Add(LblAppname);
            Name = "Form1";
            Text = "3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAppname;
        private TextBox txtID;
        private TextBox txtpw;
        private Button btnLogin;
        private Label lblerrormsg;
    }
}
