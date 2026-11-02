using System.Windows;

namespace MVVM.View
{
    public partial class Main : Window
    {
        public Main()
        {
            AutorizationWindow autorization = new AutorizationWindow();
            autorization.ShowDialog();

            if(autorization.DialogResult == true)
            {
                InitializeComponent();
            }
            else
            {
                Close();
            }
        }
    }
}
