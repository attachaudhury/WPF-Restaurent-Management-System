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
using RIAB_Restaurent_Management_System.Views.foodndeals;
using RIAB_Restaurent_Management_System.Views.finance;
using RIAB_Restaurent_Management_System.Views.kitchen;
using RIAB_Restaurent_Management_System.Views.sale;
using RIAB_Restaurent_Management_System.Views.order;
using RIAB_Restaurent_Management_System.Views.others;
using RIAB_Restaurent_Management_System.Views.person;
using BLL;
using BLL.DBOperations;
using RIAB_Restaurent_Management_System.Views.staff;
using RIAB_Restaurent_Management_System.Properties;
using DAL;
using System.ComponentModel;

namespace RIAB_Restaurent_Management_System.Views
{
    public partial class RMS : Window
    {
        tbl_Person loggininuser;

        public RMS()
        {
            
            InitializeComponent();
            loggininuser= Person.loggedinuser;
            if (loggininuser.Role == "admin")
            {
                showAdminMenu();
            }

        }
        private void showAdminMenu() {
            m_FoodsnDeals.Visibility = Visibility.Collapsed;

        }

        private void mi_AddNewCustomer(object sender, RoutedEventArgs e)
        {
            //new Window_AddNewStaff("customer").Show();
            new person.Add("customer").Show();
        }
        private void mi_LogOut(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
        private void mi_CloseApplication(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mi_ViewAllCustomers(object sender, RoutedEventArgs e)
        {
            new person.List("customer").Show();
        }

        private void mi_ManageFoodIemCategories(object sender, RoutedEventArgs e)
        {
            new Form_ManageFoodItemCatogories().Show();
        }

        private void mi_ManageFoodIems(object sender, RoutedEventArgs e)
        {
            new Form_ManageFoodItems().Show();
        }

        private void mi_ManageDeals(object sender, RoutedEventArgs e)
        {
            new Form_ManageDeals().Show();
        }

        private void mi_ManageKitchenCategories(object sender, RoutedEventArgs e)
        {
            new Form_ManageKitchenInventoryCategories().Show();
        }

        private void mi_ManageKitchenInventory(object sender, RoutedEventArgs e)
        {
            new Form_ManageKitchenInventory().Show();
        }

        private void mi_NewSale(object sender, RoutedEventArgs e)
        {
            new Window_NewSale().Show();
        }

  

        private void mi_DeliveryQueue(object sender, RoutedEventArgs e)
        {
            new Form_AllDeliveryQueues().Show();
        }

        private void mi_ManageExpenceTypes(object sender, RoutedEventArgs e)
        {
            new Form_ExpenceHeads().Show();
        }

        private void mi_ExpenceReport(object sender, RoutedEventArgs e)
        {
            new Form_ExpenceReport().Show();
        }
        
        private void btn_AllDelivery(object sender, RoutedEventArgs e)
        {
            new Form_AllDeliveryQueues().Show();
        }

        private void mi_AllSales(object sender, RoutedEventArgs e)
        {
            new Form_AllSales().Show();
        }

        private void btn_InstantInventoryManager(object sender, RoutedEventArgs e)
        {
            new Form_InstantKitchenInventoryManager().Show();
        }

        private void btn_AddExpence(object sender, RoutedEventArgs e)
        {
            new Form_AddNewExpence().Show();
        }

        private void mi_AboutSoftware(object sender, RoutedEventArgs e)
        {
            new From_AboutSoftware().Show();
        }

        private void mi_LinkKitchenInventory(object sender, RoutedEventArgs e)
        {
            new Form_LinkKitchenInventory().Show();
        }

        private void mi_CashInHand(object sender, RoutedEventArgs e)
        {
            new Form_CashInHand().Show();
        }

        private void mi_DoClosing(object sender, RoutedEventArgs e)
        {
            new Form_DoClosing().Show();
        }

        private void mi_Setting(object sender, RoutedEventArgs e)
        {
            new Window_Setting().Show();
        }

        private void mi_SendSMS(object sender, RoutedEventArgs e)
        {

        }

        private void mi_AddStaff(object sender, RoutedEventArgs e)
        {
            //new Window_AddNewStaff("staff").Show();
            new person.Add("staff").Show();
        }

        private void mi_AllStaff(object sender, RoutedEventArgs e)
        {
            //new Window_ViewAllStaff().Show();
            new person.List("staff").Show();
        }

        private void mi_FoodItemSalesReport(object sender, RoutedEventArgs e)
        {
            new Window_FoodItemSalesReport().Show();
        }

        private void mi_DeliveryBoysReport(object sender, RoutedEventArgs e)
        {
            new Window_DeliveryBoysReport().Show();
        }

        private void mi_AddFoodIem(object sender, RoutedEventArgs e)
        {
            new Form_AddNewFoodItem().Show();
        }

        private void mi_AddDeal(object sender, RoutedEventArgs e)
        {
            new Form_AddANewDeal().Show();
        }
        

        private void mi_SearchSaleByCustomer(object sender, RoutedEventArgs e)
        {
            new Form_FindSaleByCustomer().Show();
        }

        private void btn_Sale(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void btn_dg(object sender, RoutedEventArgs e)
        {
            new Form_AllDeliveryQueues().Show();
        }

        private void btn_Expence(object sender, RoutedEventArgs e)
        {
            new Form_AddNewExpence().Show();
        }

        private void btn_FoodItem(object sender, RoutedEventArgs e)
        {
            new Form_AddNewFoodItem().Show();
        }

        private void btn_Deal(object sender, RoutedEventArgs e)
        {
            new Form_AddANewDeal().Show();
        }

        private void btn_Customer(object sender, RoutedEventArgs e)
        {
            new person.Add("customer").Show();
        }

        private void mi_NewDepositHead(object sender, RoutedEventArgs e)
        {
            new Window_NewDepositHead().Show();
        }

        private void mi_NewDeposit(object sender, RoutedEventArgs e)
        {
            new Window_NewDeposit().Show();
        }

        private void mi_ViewDeposit(object sender, RoutedEventArgs e)
        {
            new Window_ViewDeposits().Show();
        }

        private void mi_DailySaleReport(object sender, RoutedEventArgs e)
        {
            new Window_DailySaleReport().Show();
        }

        private void mi_NewPurchaseOrder(object sender, RoutedEventArgs e)
        {
            new Window_NewPurchaseOrder().Show();
        }

        private void mi_ViewPurchaseOrder(object sender, RoutedEventArgs e)
        {
            new Window_ViewPurchaseOrders().Show();
        }

        private void mi_NewExpence(object sender, RoutedEventArgs e)
        {
            new Form_AddNewExpence().Show();
        }
    }
}
