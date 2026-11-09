using MVVM.ViewModels;
using System.Windows.Controls;

namespace MVVM.View.Contorls
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            
            UsersControlVM controlVM = new UsersControlVM();
            DataContext = controlVM;
        }
    }
}
