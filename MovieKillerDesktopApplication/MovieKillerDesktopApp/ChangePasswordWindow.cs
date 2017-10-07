using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieKillerDesktopApp
{
    public partial class ChangePasswordWindow : Form
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void btn_acceptChangePassword_Click(object sender, EventArgs e)
        {
            if(IsPasswordCorrect(tb_enterOldPassword.Text))
            {
                var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
                principalForm.PasswordToConnection = tb_enterNewPassword.Text;
                MessageBox.Show("Dokonano zmiany hasła!", "Komunikat");
            }
            else
            {
                MessageBox.Show("Podane hasło jest niewłaściwe", "Bład!");
            }
        }

        private bool IsPasswordCorrect(string oldPasswordGivenByUser)
        {
            var principalForm = Application.OpenForms.OfType<MainWindow>().Single();
            var correctPassword = principalForm.PasswordToConnection;

            if(oldPasswordGivenByUser == correctPassword)
            {
                return true;
            }
            return false;
        }

        private void btn_cancelChangePassword_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
