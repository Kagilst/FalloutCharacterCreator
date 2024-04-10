using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FallloutCharacterCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Uri> backgroundImages = new List<Uri>();
        private DispatcherTimer timer = new DispatcherTimer();
        private int currentBackgroundIndex = 0;


        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increment the index and update the background
            currentBackgroundIndex = (currentBackgroundIndex + 1) % backgroundImages.Count;
            UpdateBackground();
        }

        private void UpdateBackground()
        {
            if (backgroundImages.Count > 0)
            {
                Uri backgroundImageUri = backgroundImages[currentBackgroundIndex];
                ImageBrush newImageBrush = new ImageBrush(new BitmapImage(backgroundImageUri));

                // Create a DoubleAnimation to change the opacity over 1 second
                DoubleAnimation animation = new DoubleAnimation
                {
                    From = 0,
                    To = 1,
                    Duration = TimeSpan.FromSeconds(2)
                };

                // Apply the animation to the opacity property of the ImageBrush
                newImageBrush.BeginAnimation(ImageBrush.OpacityProperty, animation);

                // Set the background of the outer grid (this refers to MainWindow's Grid)
                gridMain.Background = newImageBrush;

                // Set a callback to change the image after the animation completes
                animation.Completed += (sender, e) =>
                {
                    // Increment the index and update the background
                    currentBackgroundIndex = (currentBackgroundIndex + 1) % backgroundImages.Count;
                    UpdateBackground();
                };
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            backgroundImages.Add(new Uri("pack://application:,,,/backgrounds/falloutOneBackground.jpg"));
            backgroundImages.Add(new Uri("pack://application:,,,/backgrounds/falloutTwoBackground.jpg"));
            backgroundImages.Add(new Uri("pack://application:,,,/backgrounds/falloutThreeBackground.jpg"));
            backgroundImages.Add(new Uri("pack://application:,,,/backgrounds/falloutNVBackground.jpg"));
            backgroundImages.Add(new Uri("pack://application:,,,/backgrounds/falloutFourBackground.jpg"));

            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateBackground();

        }

        private void fallout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void falloutTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void falloutThree_Click(object sender, RoutedEventArgs e)
        {
            FalloutThree falloutThreePage = new FalloutThree();
            this.Content = falloutThreePage;
        }

        private void falloutNV_Click(object sender, RoutedEventArgs e)
        {

        }

        private void falloutFour_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}