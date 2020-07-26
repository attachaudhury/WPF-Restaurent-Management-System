using BLL.DBOperations;
using DAL;
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

namespace RIAB_Restaurent_Management_System.Views.person
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List(string roletype)
        {
            InitializeComponent();
            dg_AllStaff.ItemsSource = Staff.getAll();
        }
        private void btn_Delete(object sender, RoutedEventArgs e)
        {
            if (dg_AllStaff.SelectedItem != null)
            {
                tbl_Staff staff = (tbl_Staff)dg_AllStaff.SelectedItem;
                Staff.delete(staff);
                dg_AllStaff.ItemsSource = null;
                dg_AllStaff.ItemsSource = Staff.getAll();
            }
        }
    }
}
