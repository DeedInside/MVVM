using MVVM.Models;
using System.Windows.Controls;

namespace MVVM.View.Contorls.ListItems
{
    public partial class ItemProductControl : UserControl
    {
        public ItemProductControl(Product product)
        {
            InitializeComponent();
            DataContext = product;

            if (product.Discont >= 1)
            {
                product.Price = product.Price - (product.Discont / 100.0); 
            }
        }
    }
}
