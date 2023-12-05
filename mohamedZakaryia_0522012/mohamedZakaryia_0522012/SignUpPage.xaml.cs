using System;
using System.Collections.Generic;
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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        faceprjEntities db = new faceprjEntities();
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
        
            if(txtAge.Text!=""&& txtPass.Text != "" && txtPhone.Text != "" && txtUSer.Text != "" && combo.Text != "")
            {
                if(txtPass.Text.Length>8 && Regex.IsMatch(txtPass.Text , @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+/*\|~`]).+$"))
                {
                    if (txtPhone.Text.Length >= 11)
                    {
                        user.Age = txtAge.Text;
                        user.Pass = txtPass.Text;
                        user.UserName = txtUSer.Text;
                        var city = combo.SelectedItem.ToString().Split(':').Last().Trim();
                        user.City = city;
                        user.phoneNum = txtPhone.Text;
                        if ((bool)rdFemale.IsChecked)
                        {
                            var gender = rdFemale.ToString();
                            user.Gender = gender;
                        }
                        else
                        {
                            var gender1 = rdMale.ToString();
                            user.Gender =gender1;
                        }
                        db.Users.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Enter phonenumber >= 11");
                    }
                }
                else
                {
                    MessageBox.Show("enter strong Password");
                }
            }
            else
            {
                MessageBox.Show("enter!?");
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginPage1 log = new LoginPage1();
            this.NavigationService.Navigate(log);
        }
    }
}
