using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private UNLV_IncEntities2 context = new UNLV_IncEntities2();

        public Page4()
        {
            InitializeComponent();
            GoodTeg_Table.ItemsSource = context.GoodTeg.ToList();
        }

        private void GoodsTegAdd_btn_Click(object sender, RoutedEventArgs e)
        {
            GoodTeg name = new GoodTeg();
            name.GoodTeg1 = GoodsTeg_Tbx.Text;
            context.GoodTeg.Add(name);
            context.SaveChanges();
            GoodTeg_Table.ItemsSource = context.GoodTeg.ToList();
        }

        private void GoodsTegUp_btn_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void GoodsTegDel_btn_Click(object sender, RoutedEventArgs e)
        {
            if (GoodTeg_Table.SelectedItem != null)
            {
                context.GoodTeg.Remove(GoodTeg_Table.SelectedItem as GoodTeg);
                context.SaveChanges();
                GoodTeg_Table.ItemsSource = context.GoodTeg.ToList();
            }
        }
    }
}
