/*Program id : Form1.cs
  
Purpose : Inclass 5

Revision History :
           Mehangee Vihol | 26 July 2024 created */

using inclass_05;

namespace inclass_005
{
    public partial class Form1 : Form
    {
        private UserManager _userManager;
        public Form1()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void btnGetnewid_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxId.Text = _userManager.GetNewId().ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBoxId.Text);
                string username = txtBoxUsername.Text;
                string password = txtBoxPassword.Text;
                DateTime dateCreated = dtp.Value;

                var user = new User(id, username, password, dateCreated);
                _userManager.AddNewUser(user);

                MessageBox.Show("User added successfully!");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        private void ShowError(string message)
        {
            lblError.Text = message;
        }
    }
}
