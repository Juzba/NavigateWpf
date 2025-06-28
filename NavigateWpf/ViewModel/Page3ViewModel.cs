using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NavigateWpf.ViewModel
{
    public class Page3ViewModel : ObservableObject
    {
        public Page3ViewModel()
        {
            PageForward = new RelayCommand(PageFrw);  
            PageBackward = new RelayCommand(PageBck);  
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
            MessageBox.Show("PageForward");
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
            MessageBox.Show("PageBackward");
        }

    }
}
