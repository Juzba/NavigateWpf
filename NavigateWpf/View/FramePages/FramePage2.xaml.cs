using NavigateWpf.ViewModel.FrameViewModel;
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

namespace NavigateWpf.View.FramePages
{
    /// <summary>
    /// Interakční logika pro FramePage2.xaml
    /// </summary>
    public partial class FramePage2 : Page
    {
        public FramePage2(FramePage2ViewModel framePage2ViewModel)
        {
            InitializeComponent();
            DataContext = framePage2ViewModel;
        }
    }
}
