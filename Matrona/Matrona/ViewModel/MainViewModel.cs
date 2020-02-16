using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Matrona.View;
using Xamarin.Forms;

namespace Matrona.ViewModel
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			OpenNewsCommand = new Command(OpenNewsPage);
			OpenHelpCommand = new Command(OpenHelpPage);
			OpenTableCommand = new Command(OpenTablePage);
			OpenTempleCommand = new Command(OpenTemplePage);
			OpenContactsCommand = new Command(OpenContactsPage);
			OpenPersonCommand = new Command(OpenPersonPage);
			OpenMatronaMCommand = new Command(OpenMatronaMPage);
		}

		#region Prop
		public ICommand OpenNewsCommand
		{
			get;
		}

		public ICommand OpenHelpCommand
		{
			get;
		}

		public ICommand OpenTableCommand
		{
			get;
		}

		public ICommand OpenTempleCommand
		{
			get;
		}

		public ICommand OpenContactsCommand
		{
			get;
		}

		public ICommand OpenPersonCommand
		{
			get;
		}

		public ICommand OpenMatronaMCommand
		{
			get;
		}
		#endregion

		private void OpenNewsPage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new News());
			(Application.Current.MainPage as MasterDetailPage).IsPresented = false;
		}

		private void OpenHelpPage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new Help());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}

		private void OpenMatronaMPage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new MatronaM());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}

		private void OpenPersonPage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new Person());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}

		private void OpenContactsPage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new Contact());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}

		private void OpenTemplePage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new TheTemple());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}

		private void OpenTablePage()
		{
			(Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new Table());
			( Application.Current.MainPage as MasterDetailPage ).IsPresented = false;
		}
	}
}
