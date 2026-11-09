using MVVM.Models;
using MVVM.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MVVM.View.Contorls
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();

            AdminContolVM contolVM = new AdminContolVM();
            DataContext = contolVM;
        }
    }
}
