using MVVM.Models;
using MVVM.View.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MVVM.ViewModels
{
    public class AtorizationWinVM: INotifyPropertyChanged
    {
        public User AuthUser { get; set; }
        public event EventHandler? ButtonClicAuth;
        private UserControl selectControl;
        public UserControl SelectControl 
        {
            get => selectControl;
            set
            {
                selectControl = value;
                OnPropertyChanged("SelectControl");
            }
        }
        public AtorizationWinVM(string windows = "aut")
        {
            if(windows == "aut")
            {
                AutorizationrControl autorizationr = new AutorizationrControl();
                autorizationr.ButtonClicReg += SwapControl;
                autorizationr.ButtonClickAuth += EventAuthtUser;
                SelectControl = autorizationr;
            }
            else if(windows == "reg")
            {
                RegControl regControl = new RegControl();
                regControl.ButtonClicAuth += SwapControl;
                SelectControl = regControl;
            }
            else
            {
                throw new Exception("Неверный параметр");
            }
        }
        private void EventAuthtUser(object? sender, EventArgs e)
        {
            if(sender is AutorizationrControl auth)
            {
                auth.ButtonClickAuth -= SwapControl;
                AuthUser = auth.AuthUser;
                ButtonClicAuth?.Invoke(this, EventArgs.Empty);
            }
        }
        private void SwapControl(object? sender, EventArgs e)
        {
            if(sender is AutorizationrControl auth)
            {
                auth.ButtonClicReg -= SwapControl;
                RegControl regControl = new RegControl();
                regControl.ButtonClicAuth += SwapControl;
                SelectControl = regControl;
            }
            else if(sender is RegControl regControl)
            {
                regControl.ButtonClicAuth -= SwapControl;
                AutorizationrControl autorizationr = new AutorizationrControl();
                autorizationr.ButtonClicReg += SwapControl;
                autorizationr.ButtonClickAuth += EventAuthtUser;
                SelectControl = autorizationr;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
