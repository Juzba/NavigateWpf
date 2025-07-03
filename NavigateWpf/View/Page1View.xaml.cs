using NavigateWpf.ViewModel;
using System.Windows.Controls;

namespace NavigateWpf.View
{
    /// <summary>
    /// Interakční logika pro Page1View.xaml
    /// </summary>
    public partial class Page1View : UserControl
    {
        public Page1View(Page1ViewModel page1ViewModel)
        {
            InitializeComponent();
            DataContext = page1ViewModel;
        }
    }
}
