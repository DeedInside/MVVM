using MVVM.ViewModels;
using System.Windows;

namespace MVVM.View
{
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
            
            AtorizationWinVM atorization = new();
            DataContext = atorization;
        }
    }
}
