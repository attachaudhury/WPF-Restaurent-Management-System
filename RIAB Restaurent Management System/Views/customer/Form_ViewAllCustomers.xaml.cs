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
using Microsoft.Office.Interop.Excel;

namespace RIAB_Restaurent_Management_System.Views.customer
{
    /// <summary>
    /// Interaction logic for Form_ViewAllCustomers.xaml
    /// </summary>
    public partial class Form_ViewAllCustomers : System.Windows.Window
    {
        public Form_ViewAllCustomers()
        {
            InitializeComponent();
            initFormOperation();
        }
        void initFormOperation()
        {
            dg_AllCustomers.Items.Clear();
            foreach(tbl_Customer customer in Customer.getAll())
            {
                dg_AllCustomers.Items.Add(customer);
            }
        }

        private void btn_DeleteCustomer(object sender, RoutedEventArgs e)
        {
            if(dg_AllCustomers.SelectedItem != null){
                tbl_Customer customer = (tbl_Customer)dg_AllCustomers.SelectedItem;
                Customer.delete(customer);
                AutoClosingMessageBox.Show("Customer Deleted", "Success", 3000);
                initFormOperation();
            }
            else
            {
                AutoClosingMessageBox.Show("Please Select a Customer", "Failed", 3000);
            }
        }

        private void btn_EditCustomer(object sender, RoutedEventArgs e)
        {
            if (dg_AllCustomers.SelectedItem != null)
            {
                tbl_Customer c = (tbl_Customer)dg_AllCustomers.SelectedItem;
                new Form_EditCustomer(c.Id).Show();
            }
            else
            {
                AutoClosingMessageBox.Show("Please Select a Customer", "Failed", 3000);
            }
            
        }

        private void btn_Export(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Visible = true;
            Workbook workbook = ex.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < dg_AllCustomers.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true;
                sheet1.Columns[j + 1].ColumnWidth = 15;
                myRange.Value2 = dg_AllCustomers.Columns[j].Header;
            }
            for (int i = 0; i < dg_AllCustomers.Columns.Count; i++)
            {
                for (int j = 0; j < dg_AllCustomers.Items.Count; j++)
                {
                    TextBlock b = dg_AllCustomers.Columns[i].GetCellContent(dg_AllCustomers.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }

        private void btn_Import(object sender, RoutedEventArgs e)
        {

        }
    }
}
