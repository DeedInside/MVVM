using MVVM.Models;
using MVVM.ViewModels;
using System.Windows;

namespace MVVM.View
{
    public partial class AutorizationWindow : Window
    {
        public User AuthUser { get; set; }
        public AutorizationWindow()
        {
            InitializeComponent();
            
            AtorizationWinVM atorization = new();
            atorization.ButtonClicAuth += EventAuthtUser;
            DataContext = atorization;           
        }
        private void EventAuthtUser(object? sender, EventArgs e)
        {
            if(sender is AtorizationWinVM auto)
            {
                AuthUser = auto.AuthUser;
                DialogResult = true;
            }
        }
    }
}
