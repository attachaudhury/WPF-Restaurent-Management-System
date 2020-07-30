﻿using BLL.DBOperations;
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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        tbl_Person loggedinperson;
        public Add(string roletype)
        {
            InitializeComponent();
            loggedinperson = Person.loggedinuser;
            var roles = new string[] { "admin", "user", "customer" };
            if (roletype == "staff")
            {
                roles = new string[] { "admin", "user" };
            }
            else if (roletype == "customer")
            {
                roles = new string[] { "customer" };
            }
            cb_Role.ItemsSource = roles;
        }
        private void btn_Save(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == "")
            {
                BLL.AutoClosingMessageBox.Show("Please enter name", "Failed", 3000);
                return;
            }
            if (cb_Role.SelectedValue == null)
            {
                BLL.AutoClosingMessageBox.Show("Please select role", "Failed", 3000);
                return;
            }
            if ((string)cb_Role.SelectedValue == "admin" || (string)cb_Role.SelectedValue == "user") {
                if (tb_UserName.Text == "" || tb_Password.Text=="") {
                    BLL.AutoClosingMessageBox.Show("Enter Username or password", "Failed", 3000);
                    return;
                }
            }
            tbl_Person person = new tbl_Person();
            person.Name = tb_Name.Text;
            person.Role = (string)cb_Role.SelectedValue;
            try
            {
                person.Address = tb_Address.Text;
                person.Phone = tb_Phone.Text;
                person.UserName = tb_UserName.Text;
                person.Password = tb_Password.Text;

            }
            catch { }
            Person.insert(person);
            Close();
            new List("staff").Show();
        }
    }
}