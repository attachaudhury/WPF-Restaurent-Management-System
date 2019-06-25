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
        public Window_AddNewStaff()
        {
            InitializeComponent();
            foreach (tbl_StaffCategory item in StaffCategories.getAll())
            {
                cb_Cat.ItemsSource = StaffCategories.getAll();
                cb_Cat.DisplayMemberPath = "Name";
                cb_Cat.SelectedValuePath = "Id";
            }
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == "")
            {
                return;
            }
            if (cb_Cat.SelectedValue == null)
            {
                return;
            }
            tbl_Staff staff = new tbl_Staff();
            staff.Name = tb_Name.Text;
            staff.StaffCategory_Id = (int)cb_Cat.SelectedValue;
            staff.Salary = Convert.ToInt32(tb_Salary.Text);
            try
            {
                staff.Address = tb_Address.Text;
                staff.CNIC = tb_CNIC.Text;
                staff.Comment = tb_Comment.Text;
                staff.JoiningDate = dp_JoiningDate.SelectedDate;
                staff.LeavingDate = dp_LeavingDate.SelectedDate;
                staff.PhoneNo = tb_Phone.Text;
                staff.UserName = tb_UserName.Text;
                staff.Password = tb_Password.Text;
                staff.DutyStart = Convert.ToInt32(tb_DutyStart.Text);
                staff.DutyEnd = Convert.ToInt32(tb_DutyStart.Text);      
                
            } catch { }
            
            Staff.insert(staff);
        
            Close();
            new Window_ViewAllStaff().Show();
        }
    }
}
