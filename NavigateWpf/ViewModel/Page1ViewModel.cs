using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NavigateWpf.ViewModel
{
    public class Page1ViewModel : ObservableObject
    {
        public Page1ViewModel()
        {
            PageForward = new RelayCommand(PageFrw);
            PageBackward = new RelayCommand(PageBck);
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
        }

    }
}
