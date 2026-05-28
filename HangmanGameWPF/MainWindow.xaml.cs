using System.Windows;
using System.Windows.Input;

namespace HangmanGameWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string name = SessionManager.FullName?.ToUpper() ?? "JUGADOR";

            TxtWelcome.Text = $"> BIENVENIDO, {name}!";
            TxtTitleBar.Text = $"[ HANGMAN GAME  v1.0 ]  --  JUGADOR: {name}";
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            => DragMove();

        private void BtnClose_Click(object sender, RoutedEventArgs e)
            => Close();

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
            => WindowState = WindowState.Minimized;

        private void BtnGameList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnScore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFriends_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnLeaderboard_Click(object sender, RoutedEventArgs e)
        {

        }
            

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            SessionManager.Logout();
            new LoginWindow().Show();
            Close();
        }
    }
}
