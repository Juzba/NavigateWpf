using NavigateWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigateWpf.View
{
    /// <summary>
    /// Interakční logika pro Page3View.xaml
    /// </summary>
    public partial class Page3View : UserControl
    {
        public Page3View(Page3ViewModel page3ViewModel)
        {
            InitializeComponent();
            DataContext = page3ViewModel;
        }
    }
}
