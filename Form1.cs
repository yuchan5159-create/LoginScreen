namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string inputID = txtID.Text.Trim();
           string inputPW = txtpw.Text.Trim();

        
            if (inputID  == "admin" && inputPW == "superman")
            {
                MessageBox.Show("로그인 성공!", "알림");
            }
            else
            {
                MessageBox.Show("아이디 또는 패스워드가 틀렸습니다.");
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtpw_Enter(object sender, EventArgs e)
        {
            if (txtpw.Text == "Password")
            {
                txtpw.Text = "";
                txtpw.ForeColor = Color.Black;
                txtpw.UseSystemPasswordChar = true;
            }
        }

        private void txtpw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpw.Text))
            {
                txtpw.UseSystemPasswordChar = false;
                txtpw.Text = "Password";
                txtpw.ForeColor = Color.Silver;
            }
        }
    }
}
