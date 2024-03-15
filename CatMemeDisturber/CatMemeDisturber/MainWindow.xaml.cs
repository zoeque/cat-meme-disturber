using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CatMemeDisturber
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

        /// <summary>
        /// The button activity when the happy cat button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HappyCat_Button_Click(object sender, RoutedEventArgs e)
        {
            HappyCat cat = new HappyCat();
            cat.Show();
        }

        /// <summary>
        /// The button activity when the goat button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goat_Button_Click(object sender, RoutedEventArgs e)
        {
            Goat goat = new Goat();
            goat.Show();
        }

        /// <summary>
        /// Show the happy cat when the button menu is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HappyCat cat = new HappyCat();
            cat.Show();
        }
    }
}