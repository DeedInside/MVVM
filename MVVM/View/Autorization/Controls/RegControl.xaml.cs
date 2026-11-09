using MVVM.Data;
using MVVM.Models;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace MVVM.View.Controls
{
    public partial class RegControl : UserControl
    {
        public RegControl()
        {
            InitializeComponent();
            DataContext = this;
        }
        public event EventHandler? ButtonClicAuth;
        public string Login { get; set; } = "";
        public string OnePassword { get; set; } = "";
        public string TwoPassword { get; set; } = "";

        public RelayCommand RegCommand
        {
            get
            {
                return field ??
                  (field = new RelayCommand(obj =>
                  {
                      if(!string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(OnePassword) 
                      &&!string.IsNullOrWhiteSpace(TwoPassword))
                      {
                          if(OnePassword == TwoPassword)
                          {
                              User? user = LocalApplicationContext.Users.FirstOrDefault(q => q.Login == Login);
                              if(user == null)
                              {
                                  User regUser = new User()
                                  {
                                      Login = Login,
                                      Password = OnePassword, 
                                      Role = LocalApplicationContext.Roles[0]
                                  };

                                  LocalApplicationContext.Users.Add(regUser);
                                  ButtonClicAuth?.Invoke(this, EventArgs.Empty);
                              }
                              else
                              {
                                  MessageBox.Show("Логин занят");
                              }
                          }
                          else
                          {
                              MessageBox.Show("Пароли не совпадают");
                          }
                      }
                      else
                      {
                          MessageBox.Show("Заполните все поля");
                      }
                  }));
            }
        }

        public RelayCommand ExitCommand
        {
            get
            {
                return field ??
                  (field = new RelayCommand(obj =>
                  {
                      ButtonClicAuth?.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
    }
}
