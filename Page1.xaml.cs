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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private UNLV_IncEntities2 context = new UNLV_IncEntities2();
        public Page1()
        {
            InitializeComponent();
            Clients_Table.ItemsSource = context.Clients.ToList();
        }

        private void Insert_btn_Click(object sender, RoutedEventArgs e)
        {
            Clients name = new Clients();
            name.FirstNameClient = FirstN_tbx.Text;
            name.SurNameClient = SurN_tbx.Text;
            name.MiddleNameClient = MiddleN_tbx.Text;
            name.PasportSeriya = Convert.ToInt32(PasSer_tbx.Text);
            name.PasportNumber = Convert.ToInt32(PasN_tbx.Text);
            context.Clients.Add(name);
            context.SaveChanges();
            Clients_Table.ItemsSource = context.Clients.ToList();

        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Clients_Table.SelectedItem != null)
            {
                context.Clients.Remove(Clients_Table.SelectedItem as Clients);
                context.SaveChanges();
                Clients_Table.ItemsSource = context.Clients.ToList();
            }
        }
    }
}
