using System;

using HelloUWP.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace HelloUWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageDialog myDlg = new MessageDialog("안녕하세요");
            myDlg.Commands.Add(new UICommand("OK"));
            myDlg.Commands.Add(new UICommand("안녕"));
            myDlg.Commands.Add(new UICommand("HI"));
            await myDlg.ShowAsync();
        }
    }
}
;
