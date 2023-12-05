using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ForgetPassPage.xaml
    /// </summary>
    public partial class ForgetPassPage : Page
    {
        faceprjEntities db = new faceprjEntities();
        public ForgetPassPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            try
            {
                if(txtPhone.Text!="" && txtNewPass.Text!="" && txtNewConf.Text != "")
                {
                    if (txtNewPass.Text.Length > 8 && Regex.IsMatch(txtNewPass.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+/*\|~`]).+$"))
                    {

                        if (txtNewPass.Text == txtNewConf.Text)
                        {
                            user = db.Users.First(x => x.phoneNum == txtPhone.Text);
                            user.Pass = txtNewPass.Text;
                            db.Users.AddOrUpdate(user);
                            db.SaveChanges();
                            LoginPage1 loginPage = new LoginPage1();
                            this.NavigationService.Navigate(loginPage);
                        }
                        else
                        {
                            MessageBox.Show("the pass != confpass");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Strong Pass");
                    }
                }
                else
                {
                    MessageBox.Show("Enter!?");
                }
            }
            catch 
            {
                MessageBox.Show("Not found!");
            }
        }
    }
}
