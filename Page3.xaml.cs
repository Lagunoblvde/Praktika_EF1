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

namespace Praktika1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private UNLV_IncEntities2 context = new UNLV_IncEntities2();
        public Page3()
        {
            InitializeComponent();
            Orders_Table.ItemsSource = context.Orders.ToList();

        }

        private void OrdersAdd_btn_Click(object sender, RoutedEventArgs e)
        {
            Orders name = new Orders();
            name.ID_Client = Convert.ToInt32(IDClient_tbx.Text);
            name.ID_Good = Convert.ToInt32(IDGood_tbx.Text);
            name.Quantity = Convert.ToInt32(Quantity_tbx.Text);
            name.OrderDate = Convert.ToDateTime(OrderDate_tbx.Text);
            context.Orders.Add(name);
            context.SaveChanges();
            Orders_Table.ItemsSource = context.Orders.ToList();
        }

        private void OrdersUp_btn_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void OrdersDel_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Orders_Table.SelectedItem != null)
            {
                context.Orders.Remove(Orders_Table.SelectedItem as Orders);
                context.SaveChanges();
                Orders_Table.ItemsSource = context.Orders.ToList();
            }
        }
    }
}
