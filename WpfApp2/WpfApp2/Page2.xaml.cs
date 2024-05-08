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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        systemtestEntities1 db = new systemtestEntities1();
        public Page2()
        {
            InitializeComponent();
             
        }

        private void search1_Click(object sender, RoutedEventArgs e)
        {
            employee employee = new employee();
            int v = int.Parse(idt.Text);
            datagrid.ItemsSource = db.employees.Where(x => x.id == v).ToList();
        }
    }
}
