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
    public partial class Page1ViewModel : ObservableObject
    {
		private object _myView = new Page1View();
		public object MyView
		{
			get { return _myView; }
			set { SetProperty(ref _myView, value); }
		}


		[RelayCommand]
		private void Btn1()
		{
			MessageBox.Show("btn1");
			MyView = new Page2View();
		}






	}
}
