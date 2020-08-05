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

namespace RIAB_Restaurent_Management_System.Views.product
{
    /// <summary>
    /// Interaction logic for ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        int cateroryid = 0;
        public ProductAdd()
        {
            InitializeComponent();
            initFormOperations();
        }
        private void btn_SaveFoodItem(object sender, RoutedEventArgs e)
        {
            tbl_FoodItem r = new tbl_FoodItem();
            r.Name = tb_FoodItemName.Text;
            r.SalePrice = Convert.ToInt32(tb_FoodSalePrice.Text);
            r.Category_Id = cateroryid;
            r.ManageInventory = cbx_ManageInventory.IsChecked.Value;
            FoodItem.insert(r);
            Close();
            new ProductAdd().Show();
        }

        
        void initFormOperations()
        {
            var categoriesList = FoodItemCategory.getAll();
            foreach (tbl_FoodItemCategory item1 in categoriesList)
            {
                
            }
        }
    }
}
