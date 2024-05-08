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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        systemtestEntities1 db = new systemtestEntities1();
        public Page1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Admin1 admin1 = new Admin1();
            admin1 = db.Admin1.FirstOrDefault(x=> x.User_Name == textboxU.Text);
            if (admin1 != null && admin1.password1 == passU.Password)
            {
                Page2 page2 = new Page2();
                this.NavigationService.Navigate(page2);
            }
        }
    }
}
