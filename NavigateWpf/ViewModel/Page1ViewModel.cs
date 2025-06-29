using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NavigateWpf.Services;
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
        private readonly Navigation _navigation;
        public Page1ViewModel(Navigation navigation)
        {
            _navigation = navigation;
            PageForward = new RelayCommand(PageFrw);
            PageBackward = new RelayCommand(PageBck);
        }

        public IRelayCommand PageForward { get; }
        private void PageFrw()
        {
            _navigation.NavigateTo();
        }

        public IRelayCommand PageBackward { get; }
        private void PageBck()
        {
            _navigation.NavigateTo();
        }

    }
}
