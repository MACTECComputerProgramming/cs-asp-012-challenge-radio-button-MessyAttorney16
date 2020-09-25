using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

namespace CS_ASP_012CheckBoxChallange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            choiceLabel.Content = " ";
            if (pencilRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Pencil, very classic choice";
                pencilImage.Opacity = 100;
                penImage.Opacity = 0;
                phoneImage.Opacity = 0;
                padImage.Opacity = 0;
            }
            else if (penRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Pen, a bit more modern";
                pencilImage.Opacity = 0;
                penImage.Opacity = 100;
                phoneImage.Opacity = 0;
                padImage.Opacity = 0;
            }
            else if (phoneRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Phone, aren't you special";
                pencilImage.Opacity = 0;
                penImage.Opacity = 0;
                phoneImage.Opacity = 100;
                padImage.Opacity = 0;
            }
            else if (padRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Pad, you're really special";
                pencilImage.Opacity = 0;
                penImage.Opacity = 0;
                phoneImage.Opacity = 0;
                padImage.Opacity = 100;
            }
            else
            {
                choiceLabel.Content = "Choose one silly!";
                pencilImage.Opacity = 0;
                penImage.Opacity = 0;
                phoneImage.Opacity = 0;
                padImage.Opacity = 0;
            }
        }
    }
}
