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
        /// Show four maxwell the cat when the button menu is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowWindowAt(0, 0); 
            ShowWindowAt(SystemParameters.WorkArea.Width, 0); 
            ShowWindowAt(0, SystemParameters.WorkArea.Height); 
            ShowWindowAt(SystemParameters.WorkArea.Width, SystemParameters.WorkArea.Height); 
        }

        /// <summary>
        /// Show the maxwell the cat with a given cordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void ShowWindowAt(double x, double y)
        {
            MaxwellCat cat = new MaxwellCat();
            cat.Left = x;
            cat.Top = y;
            cat.Show();
        }
    }
}