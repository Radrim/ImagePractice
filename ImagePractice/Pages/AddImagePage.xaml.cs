using ImagePractice.ADOApp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AddImagePage.xaml
    /// </summary>
    public partial class AddImagePage : Page
    {
        public byte[] ImageMat { get; set; }

        public AddImagePage()
        {
            InitializeComponent();
        }

        private void ImageSelectionButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var btnSelect = sender as Button;
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() != null)
                {
                    ImageMat = File.ReadAllBytes(dialog.FileName);
                    btnSelect.Background = Brushes.Green;
                }
            }
            catch
            {
                MessageBox.Show("Только фото!", "Ошибка");
            }

        }

        private void SaveMaterialClick(object sender, RoutedEventArgs e)
        {
            Material material = new Material
            {
                Title = tbTitle.Text,
                Info = tbInfo.Text,
                ByteImage = ImageMat
            };

            App.Connection.Material.Add(material);
            App.Connection.SaveChanges();
        }

        private void GoToImageGalleryPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ImageGalleryPage());
        }
    }
}
