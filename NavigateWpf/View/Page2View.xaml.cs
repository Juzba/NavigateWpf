using NavigateWpf.View.FramePages;
using NavigateWpf.ViewModel;
using System.Windows.Controls;

namespace NavigateWpf.View
{
    /// <summary>
    /// Interakční logika pro Page2View.xaml
    /// </summary>
    public partial class Page2View : UserControl
    {
        public Page2View(Page2ViewModel page2ViewModel)
        {
            InitializeComponent();
            DataContext = page2ViewModel;
        }
    }
}
