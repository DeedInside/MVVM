using MVVM.View.Controls;
using System.Windows.Controls;

namespace MVVM.ViewModels
{
    public class AtorizationWinVM
    {
        public UserControl SelectControl { get; set; }
        public AtorizationWinVM(string windows = "aut")
        {
            if(windows == "aut")
            {
                AutorizationrControl autorizationr = new AutorizationrControl();
                SelectControl = autorizationr;
            }
            else if(windows == "reg")
            {
                RegControl regControl = new RegControl();
                SelectControl = regControl;
            }
            else
            {
                throw new Exception("Неверный параметр");
            }
        }

    }
}
