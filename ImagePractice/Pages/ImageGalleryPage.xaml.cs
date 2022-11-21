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

namespace ImagePractice.Pages
{
    /// <summary>
    /// Interaction logic for ImageGalleryPage.xaml
    /// </summary>
    public partial class ImageGalleryPage : Page
    {
        public ImageGalleryPage()
        {
            InitializeComponent();
            listImages.ItemsSource = App.Connection.Material.ToList();
        }

        private void GoToImageAddPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ImageGalleryPage());
        }
    }
}
