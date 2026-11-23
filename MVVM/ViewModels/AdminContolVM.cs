using MVVM.Data;
using MVVM.Models;
using MVVM.View;
using MVVM.View.Contorls.ListItems;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MVVM.ViewModels
{
    public class AdminContolVM
    {
        public ObservableCollection<UserControl> ListItemProduct { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public AdminContolVM()
        {
            Products = LocalApplicationContext.Products;
            ListItemProduct = InitItemProduct(Products);
        }

        private ObservableCollection<UserControl> InitItemProduct(ObservableCollection<Product> products)
        {
            ObservableCollection<UserControl> result = new ();

            foreach (var product in products)
            {
                result.Add(new ItemProductControl(product));
            }

            return result;
        }
        public RelayCommand ExitAuthCommand
        {
            get
            {
                return field ??
                  (field = new RelayCommand(obj =>
                  {
                      var currentWindow = Application.Current.Windows
                        .OfType<Window>()
                        .FirstOrDefault(w => w.IsActive)
                        ?? Application.Current.MainWindow;
                      try
                      {

                          currentWindow.Visibility = Visibility.Hidden;
                          var newWindow = (Window)Activator.CreateInstance(currentWindow.GetType());

                          newWindow.Show();
                          currentWindow.Close();
                      }
                      catch
                      {
                          currentWindow.Close();
                      }
                  }));
            }
        }
        public RelayCommand AddCommand
        {
            get
            {
                return field ??
                  (field = new RelayCommand(obj =>
                  {
                      LocalApplicationContext.Products.Add
                      (
                          new Product() { Id = 3, Count = 5, Description = "description 3", Discont = 5, Name = "name 3", Price = 1000, ImagePath = "Source/Images/default.png" }
                      );

                      ListItemProduct = InitItemProduct(Products);
                  }));
            }
        }
    }
}
