using BLL.DBOperations;
using DAL;
using RIAB_Restaurent_Management_System.bll;
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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
            var db = new RMSDBEntities();

        }
        private void btn_Save(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == "")
            {
                BLL.AutoClosingMessageBox.Show("Please enter name", "Failed", 3000);
                return;
            }
            tbl_Customer person = new tbl_Customer();
            person.Name = tb_Name.Text;
            try
            {
                person.Address = tb_Address.Text;
                person.PhoneNo = tb_Phone.Text;

            }
            catch { }
            var db = new RMSDBEntities();
            db.tbl_Customer.Add(person);
            db.SaveChanges();
            Close();
        }
    }
}
