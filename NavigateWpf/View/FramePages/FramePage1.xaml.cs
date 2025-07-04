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
    /// Interakční logika pro FramePage1.xaml
    /// </summary>
    public partial class FramePage1 : Page
    {
        public FramePage1(FramePage1ViewModel framePage1ViewModel)
        {
            InitializeComponent();
            DataContext = framePage1ViewModel;
        }
    }
}
