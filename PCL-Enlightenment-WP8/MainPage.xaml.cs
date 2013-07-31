using System.Windows;
using Common;
using Microsoft.Phone.Controls;

namespace PCL_Enlightenment_WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            new GoogleLauncherTask().Show();
        }
    }
}