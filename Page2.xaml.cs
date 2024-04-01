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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private UNLV_IncEntities2 context = new UNLV_IncEntities2();
        public Page2()
        {
            InitializeComponent();
            Goods_Table.ItemsSource = context.Goods.ToList();

        }

        private void GoodAdd_btn_Click(object sender, RoutedEventArgs e)
        {
            Goods name = new Goods();
            name.NameGood = NameG_tbx.Text;
            name.GoodNumber = Convert.ToInt32(GoodN_tbx.Text);
            name.GoodCost = Convert.ToDecimal(GoodC_tbx.Text);
            name.GoodNalichie = Convert.ToInt32(GoodNal_tbx.Text);
            context.Goods.Add(name);
            context.SaveChanges();
            Goods_Table.ItemsSource = context.Goods.ToList();
        }

        private void GoodUp_btn_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void GoodDel_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Goods_Table.SelectedItem != null)
            {
                context.Goods.Remove(Goods_Table.SelectedItem as Goods);
                context.SaveChanges();
                Goods_Table.ItemsSource = context.Goods.ToList();
            }
        }
    }
}
