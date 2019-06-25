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
using BLL;
using BLL.DBOperations;
using DAL;

namespace RIAB_Restaurent_Management_System.Views.customer
{
    /// <summary>
    /// Interaction logic for Form_EditCustomer.xaml
    /// </summary>
    public partial class Form_EditCustomer : Window
    {
        tbl_Customer customer;
        public Form_EditCustomer(int id)
        {
            InitializeComponent();
             customer = Customer.getById(id);
             initFormOperations();
        }
        void initFormOperations()
        {
            tb_Name.Text = customer.Name;
            tb_PhoneNo.Text = customer.PhoneNo;
            tb_Address.Text = customer.Address;
            
        }

        private void btn_UpdateCustomer(object sender, RoutedEventArgs e)
        {
            customer.Name = tb_Name.Text;
            customer.PhoneNo = tb_PhoneNo.Text;
            customer.Address = tb_Address.Text;
            Customer.update(customer);
            AutoClosingMessageBox.Show("Success", "Customer Updated", 2000);
            new Form_ViewAllCustomers().Show();
            Close();
        }

    }
}
