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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new();
        int TenthOfSecondsElapsed;
        int MatchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;

            SetUpGame();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            TenthOfSecondsElapsed++;
            TimerTextBlock.Text = (TenthOfSecondsElapsed / 10F).ToString("0.0s");
            //if(MatchesFound == 8)
            //{
            //    timer.Stop();
            //    TimerTextBlock.Text += " - Play again?";
            //}
        }

        private void SetUpGame()
        {
            TenthOfSecondsElapsed = 0;
            MatchesFound = 0;

            List<string> AnimalEmoji = new ()
            {
                "😁","😁",
                "😊","😊",
                "😂","😂",
                "😍","😍",
                "😎","😎",
                "😵‍💫","😵‍💫",
                "💖","💖",
                "🙌","🙌"

            };

            Random Random = new();

            foreach (TextBlock TextBlock in MainGrid.Children.OfType<TextBlock>())
            {
                if(TextBlock.Name != "TimerTextBlock")
                {
                    int Index = Random.Next(AnimalEmoji.Count);
                    string NextEmoji = AnimalEmoji[Index];
                    TextBlock.Visibility = Visibility.Visible;
                    TextBlock.Text = NextEmoji;
                    AnimalEmoji.RemoveAt(Index);
                }

            }

            timer.Start();
        }

        TextBlock LastTextBlockChecked;
        bool FindingMatch = false;

        private void TextBlock_MouseDown(object Sender, MouseButtonEventArgs E)
        {
            TextBlock? TBlock = Sender as TextBlock;

            if(FindingMatch == false)
            {
                TBlock.Visibility = Visibility.Hidden;
                LastTextBlockChecked = TBlock;
                FindingMatch = true;
            }
            else if (TBlock.Text == LastTextBlockChecked.Text)
            {
                MatchesFound++;
                TBlock.Visibility = Visibility.Hidden;
                FindingMatch = false;

            }
            else
            {
                LastTextBlockChecked.Visibility = Visibility.Visible;
                FindingMatch= false;    
            }

            if(MatchesFound == 8)
            {
                timer.Stop();
                TimerTextBlock.Text = "Game Over in " + TimerTextBlock.Text + ". You did it 🙌";
                RestartButton.Content = "Start";
            }

        }

        private void RestartButton_MouseDown(object Sender, RoutedEventArgs E)
        {
            RestartButton.Content = "Restart";
            SetUpGame();
        }
    }
}
