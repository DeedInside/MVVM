using MVVM.Data;
using MVVM.Models;
using System.Windows;
using System.Windows.Controls;

namespace MVVM.View.Controls
{
    public partial class AutorizationrControl : UserControl
    {
        public event EventHandler? ButtonClicReg;
        public event EventHandler? ButtonClickAuth;
        public User AuthUser { get; set; } = null;
        public string Login { get; set; } = "3";
        public string Password { get; set; } = "3";
        public AutorizationrControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private RelayCommand autCommand;
        public RelayCommand AutCommand
        {
            get
            {
                return autCommand ??
                  (autCommand = new RelayCommand(obj =>
                  {
                      if (!string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password))
                      {
                          User? user = LocalApplicationContext.Users.FirstOrDefault(
                              q => q.Login == Login && q.Password == Password);

                          if(user != null)
                          {
                              AuthUser = user;
                              ButtonClickAuth(this, EventArgs.Empty);
                          }
                          else
                          {
                              MessageBox.Show("Польватель не найден");
                          }
                      }
                      else
                      {
                        MessageBox.Show("Заполните все поля");
                      }
                     
                  }));
            }
        }
        private RelayCommand regCommand;
        public RelayCommand RegCommand
        {
            get
            {
                return regCommand ??
                  (regCommand = new RelayCommand(obj =>
                  {
                      ButtonClicReg?.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
        private RelayCommand exitCommand;
        public RelayCommand ExitCommand
        {
            get
            {
                return exitCommand ??
                  (exitCommand = new RelayCommand(obj =>
                  {
                      //TODO выход
                      MessageBox.Show("выход");
                  }));
            }
        }
    }
}
