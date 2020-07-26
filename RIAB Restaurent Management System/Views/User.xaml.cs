using BLL;
using RIAB_Restaurent_Management_System.Views.finance;
using RIAB_Restaurent_Management_System.Views.others;
using RIAB_Restaurent_Management_System.Views.sale;
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
using System.Windows.Shapes;

namespace RIAB_Restaurent_Management_System.Views
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
            lbl_Title.Content = MyPrinterSetting.Title;
        }

        private void btn_Sale(object sender, RoutedEventArgs e)
        {
            new Window_NewSale().Show();
        }

        private void btn_dg(object sender, RoutedEventArgs e)
        {
            new Form_AllDeliveryQueues().Show();
        }

        private void btn_Customer(object sender, RoutedEventArgs e)
        {
            //new Form_AddNewCustomer().Show();
        }

        private void mi_AddNewCustomer(object sender, RoutedEventArgs e)
        {
            //new Form_AddNewCustomer().Show();
        }

        private void mi_NewSale(object sender, RoutedEventArgs e)
        {
            new Window_NewSale().Show();
        }

        private void mi_DeliveryQueue(object sender, RoutedEventArgs e)
        {
            new Form_AllDeliveryQueues().Show();
        }

        private void mi_AboutSoftware(object sender, RoutedEventArgs e)
        {
            new From_AboutSoftware().Show();
        }

        private void mi_LogOut(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mi_DoClosing(object sender, RoutedEventArgs e)
        {
            new Form_DoClosing().Show();
        }

        private void mi_NewDepost(object sender, RoutedEventArgs e)
        {
            new Window_NewDeposit().Show();
        }
    }
}
