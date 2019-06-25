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
using DAL;
using BLL;
using BLL.DBOperations;

namespace RIAB_Restaurent_Management_System.Views.customer
{
    /// <summary>
    /// Interaction logic for Form_AddNewCustomer.xaml
    /// </summary>
    public partial class Form_AddNewCustomer : Window
    {
        public Form_AddNewCustomer()
        {
            InitializeComponent();
        }

        private void btn_AddCustomer(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text != "" || tb_PhoneNo.Text != "")
            {
                tbl_Customer oldCustomer = Customer.getByPhoneNumber(tb_PhoneNo.Text);
                if (oldCustomer != null)
                {
                    AutoClosingMessageBox.Show("Customer Alredy exists", "Alert", 3000);
                    return;
                }
                tbl_Customer customer = new tbl_Customer();
                customer.Name = tb_Name.Text;
                customer.PhoneNo = tb_PhoneNo.Text;
                customer.Address = tb_Address.Text;
                Customer.insert(customer);
                AutoClosingMessageBox.Show("Success", "Customer Added", 3000);
                tb_Name.Text = "";
                tb_PhoneNo.Text = "";
                tb_Address.Text = "";
                Close();
                new Form_ViewAllCustomers().Show();
            }
            else 
            {
                AutoClosingMessageBox.Show("Success", "Customer Added", 3000);
            }

            
        }
    }
}
