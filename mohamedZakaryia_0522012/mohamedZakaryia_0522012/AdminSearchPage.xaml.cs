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
    /// Interaction logic for AdminSearchPage.xaml
    /// </summary>
    public partial class AdminSearchPage : Page
    {
        faceprjEntities db = new faceprjEntities();
        public AdminSearchPage()
        {
            InitializeComponent();
           // dataGrid.ItemsSource = db.Users.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtPhone.Text != "")
            {
                dataGrid.ItemsSource = db.Users.Where(x=> x.City == txtPhone.Text).ToList();
            }
            else
            {
                MessageBox.Show("Enter!?");
            }
        }
    }
}
