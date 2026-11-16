using MVVM.Models;
using MVVM.View;
using System.Windows;

namespace MVVM.ViewModels
{
    public class AdminContolVM
    {
        public AdminContolVM()
        {

        }

        public RelayCommand ExitAuthCommand
        {
            get
            {
                return field ??
                  (field = new RelayCommand(obj =>
                  {
                      Application.Current.MainWindow.Visibility = Visibility.Hidden;
                      
                      Main newMainWindow = new Main();
                      newMainWindow.Show();

                      Application.Current.MainWindow.Close();
                  }));
            }
        }
    }
}
