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
            Login = new Label();
            txtID = new TextBox();
            txtpw = new TextBox();
            LogB = new Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(286, 54);
            Login.Name = "Login";
            Login.Size = new Size(143, 62);
            Login.TabIndex = 0;
            Login.Text = "Login";
            // 
            // txtID
            // 
            txtID.Location = new Point(286, 144);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtpw
            // 
            txtpw.Location = new Point(286, 208);
            txtpw.Name = "txtpw";
            txtpw.PlaceholderText = "Password";
            txtpw.Size = new Size(125, 27);
            txtpw.TabIndex = 2;
            txtpw.TextChanged += textBox2_TextChanged;
            // 
            // LogB
            // 
            LogB.BackColor = SystemColors.ActiveCaption;
            LogB.Location = new Point(301, 331);
            LogB.Name = "LogB";
            LogB.Size = new Size(94, 29);
            LogB.TabIndex = 3;
            LogB.Text = "로그인";
            LogB.UseVisualStyleBackColor = false;
            LogB.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogB);
            Controls.Add(txtpw);
            Controls.Add(txtID);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private TextBox txtID;
        private TextBox txtpw;
        private Button LogB;
    }
}
