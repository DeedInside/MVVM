using MVVM.ViewModels;
using System.Net.Http.Headers;
using System.Windows.Controls;
using System.Xml;

namespace MVVM.View.Contorls
{
    public partial class MenegerControl : UserControl
    {
        public MenegerControl()
        {
            InitializeComponent();
            
            MenegerControlVM controlVM = new MenegerControlVM();
            DataContext = controlVM;
        }
    }
}
