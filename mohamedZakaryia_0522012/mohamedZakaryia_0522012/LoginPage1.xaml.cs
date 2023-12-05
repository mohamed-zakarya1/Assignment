using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mohamedZakaryia_0522012
{
    /// <summary>
    /// Interaction logic for LoginPage1.xaml
    /// </summary>
    public partial class LoginPage1 : Page
    {
        faceprjEntities db = new faceprjEntities();
        public LoginPage1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage upPage = new SignUpPage();
            this.NavigationService.Navigate(upPage);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            try
            {
                if (txtPass.Text != "" && txtUSer.Text != "")
                {
                   var user1 =  user = db.Users.First(x => x.UserName == txtUSer.Text && x.Pass == txtPass.Text);
                    ProfilePage profilePage = new ProfilePage(user1);
                    this.NavigationService.Navigate(profilePage);
                }
                else
                {
                    MessageBox.Show("Enter!??");
                }
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btnForgetPass_Click(object sender, RoutedEventArgs e)
        {
            ForgetPassPage passPage = new ForgetPassPage();
            this.NavigationService.Navigate(passPage);
        }

        private void txtUSer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Admin1Page admin1 = new Admin1Page();
            this.NavigationService.Navigate(admin1);
        }
    }
}
