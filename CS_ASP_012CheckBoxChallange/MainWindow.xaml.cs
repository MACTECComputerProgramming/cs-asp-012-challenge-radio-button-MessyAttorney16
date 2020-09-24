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
            }
            else if (penRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Pen, a bit more modern";
            }
            else if (phoneRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Phone, aren't you special";
            }
            else if (padRadioButton.IsChecked == true)
            {
                choiceLabel.Content = "Pad, you're really special";
            }
            else
            {
                choiceLabel.Content = "Choose one silly!";
            }
        }
    }
}
