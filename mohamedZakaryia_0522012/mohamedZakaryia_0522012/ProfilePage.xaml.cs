using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        faceprjEntities db = new faceprjEntities();
        public ProfilePage(User user)
        {
            InitializeComponent();
            txtAge.Text = user.Age;
            txtCity.Text = user.City;
            txtGender.Text = user.Gender;
            txtName.Text = user.UserName;
            txtPass.Text = user.Pass;
            for (int i=0; i<txtPass.Text.Count(); i++)
            {
                txtPass.Text += "*";
            }
            txtPhone.Text = user.phoneNum;
           // dataGrid.ItemsSource = db.Users.Where(x => x.UserName == name).ToList();
        }
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginPage1 login = new LoginPage1();  
            this.NavigationService.Navigate(login);
        }
    }
}
