using MVVM.Models;
using MVVM.View.Contorls;
using System.Windows.Controls;

namespace MVVM.ViewModels
{
    public class MainVM
    {
        public UserControl SelectControl { get; set; }
        public MainVM(User user)
        {
            if(user.Role.Name == "user")
            {
                UsersControl control = new UsersControl();
                SelectControl = control;
            }
            else if (user.Role.Name == "meneger")
            {
                MenegerControl control = new MenegerControl();
                SelectControl = control;
            }
            else if (user.Role.Name == "admin")
            {
                AdminControl control = new AdminControl();
                SelectControl = control;
            }
        }
    }
}
