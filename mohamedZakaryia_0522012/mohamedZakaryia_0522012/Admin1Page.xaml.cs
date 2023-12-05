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
    /// Interaction logic for Admin1Page.xaml
    /// </summary>
    public partial class Admin1Page : Page
    {
        faceprjEntities db = new faceprjEntities();
        public Admin1Page()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            try
            {
                if (txtID.Text != "")
                {
                    int id = int.Parse(txtID.Text);
                    admin = db.Admins.First(x => x.admin_ID == id && x.admin_USerName == txtName.Text);
                    DeleteAdminPage deleteAdmin = new DeleteAdminPage();
                    this.NavigationService.Navigate(deleteAdmin);
                }
                else
                {
                    MessageBox.Show("Enter!?");
                }
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
