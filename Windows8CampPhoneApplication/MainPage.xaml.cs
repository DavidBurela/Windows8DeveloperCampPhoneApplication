using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace Windows8CampPhoneApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/YourLastAboutDialog;component/AboutPage.xaml", UriKind.Relative));
        }

        private void XDDNTwitterHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://twitter.com/XDDN_AU");
        }

        private void XDDNMelbourneHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://www.meetup.com/Melbourne-XDDN/");
        }

        private void XDDNSydneyHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://www.meetup.com/Sydney-XDDN/");
        }

        private void XDDNPerthHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://www.meetup.com/Perth-XDDN/");
        }

        private void RegisterHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://www.lalaninja.com.au/2012/03/19/windows-8-developer-camps-australia/");
        }

        private void ConsumerPreviewHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://preview.windows.com");
        }

        private void DevCentreHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://msdn.microsoft.com/windows/apps");
        }

        private void OnlineSDKSamplesHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://code.msdn.microsoft.com/windowsapps/");
        }

        private void DownloadSDKSamplesHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToWebpage("http://code.msdn.microsoft.com/windowsapps/Windows-8-Modern-Style-App-Samples");
        }

        private void NavigateToWebpage(string url)
        {
            var wbt = new WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
    }
}