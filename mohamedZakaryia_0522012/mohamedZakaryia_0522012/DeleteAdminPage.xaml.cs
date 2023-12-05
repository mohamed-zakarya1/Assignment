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
    /// Interaction logic for DeleteAdminPage.xaml
    /// </summary>
    public partial class DeleteAdminPage : Page
    {
        faceprjEntities db = new faceprjEntities();
        public DeleteAdminPage()
        {
            InitializeComponent();
            dataGrid.ItemsSource = db.Users.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text != "")
            {
                User user = new User();
                user = db.Users.First(x => x.phoneNum == txtPhone.Text);
                db.Users.Remove(user);
                db.SaveChanges();
                dataGrid.ItemsSource = db.Users.ToList();
            }
            else
            {
                MessageBox.Show("Enter!??");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            AdminSearchPage searchPage = new AdminSearchPage();
            this.NavigationService.Navigate(searchPage);
        }
    }
}
