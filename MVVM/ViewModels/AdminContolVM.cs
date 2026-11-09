using MVVM.Models;
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
                      MessageBox.Show("выход");
                      // ButtonClicReg?.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
    }
}
