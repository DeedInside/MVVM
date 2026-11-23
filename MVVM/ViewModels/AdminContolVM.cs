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
                      var currentWindow = Application.Current.Windows
                      .OfType<Window>()
                      .FirstOrDefault(w => w.IsActive)
                      ?? Application.Current.MainWindow;

                      currentWindow.Visibility = Visibility.Hidden;
                      var newWindow = (Window)Activator.CreateInstance(currentWindow.GetType());

                      newWindow.Show();
                      currentWindow.Close();
                  }));
            }
        }
    }
}
