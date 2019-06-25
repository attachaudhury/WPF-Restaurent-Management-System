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

namespace RIAB_Restaurent_Management_System.Views.staff
{
    /// <summary>
    /// Interaction logic for Window_AddStaffCategory.xaml
    /// </summary>
    public partial class Window_AddStaffCategory : Window
    {
        public Window_AddStaffCategory()
        {
            InitializeComponent();
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            tbl_StaffCategory cat = new tbl_StaffCategory();
            cat.Name = tb_Name.Text;
            StaffCategories.insert(cat);
            Close();
        }
    }
}
