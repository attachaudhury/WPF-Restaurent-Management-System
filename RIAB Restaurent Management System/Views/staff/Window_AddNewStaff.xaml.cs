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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RIAB_Restaurent_Management_System.Views.staff
{
    /// <summary>
    /// Interaction logic for Window_AddNewStaff.xaml
    /// </summary>
    public partial class Window_AddNewStaff : Window
    {
        public Window_AddNewStaff(string roletype)
        {
            InitializeComponent();
            //foreach (tbl_StaffCategory item in StaffCategories.getAll())
            //{
            //    cb_Role.ItemsSource = StaffCategories.getAll();
            //    cb_Role.DisplayMemberPath = "Name";
            //    cb_Role.SelectedValuePath = "Id";
            //}

            var roles = new string[] {"admin" ,"user","customer"};
            if (roletype == "staff"){
                roles = new string[] { "admin", "user" };
            }
            else if (roletype == "customer")
            {
                roles = new string[] { "customer"};
            }
            cb_Role.ItemsSource = roles;
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == "")
            {
                return;
            }
            if (cb_Role.SelectedValue == null)
            {
                return;
            }
            tbl_Person staff = new tbl_Person();
            staff.Name = tb_Name.Text;
            staff.Role = (string)cb_Role.SelectedValue;
            try
            {
                staff.Address = tb_Address.Text;
                staff.Phone = tb_Phone.Text;
                staff.UserName = tb_UserName.Text;
                staff.Password = tb_Password.Text;
                
            } catch { }
            Console.WriteLine(staff.Role);
            //Person.insert(staff);
        
            //Close();
            new Window_ViewAllStaff().Show();
        }
    }
}
