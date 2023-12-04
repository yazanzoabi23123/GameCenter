using gameCenter.Projects.GameTicTacToe.Models;
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
using System.Windows.Shapes;

namespace gameCenter.Projects.GameTicTacToe
{
    /// <summary>
    /// Interaction logic for TicTacToe.xaml
    /// </summary>
    public partial class TicTacToe : Window
    {
        TikTacToeModel GameModel;

        public TicTacToe()
        {
            InitializeComponent();
            GameModel = new TikTacToeModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button != null && string.IsNullOrEmpty(button.Content as string))
            {
                button.Content = GameModel.CurrentPlayer.ToString();
                int row = Grid.GetRow(button);
                int column = Grid.GetColumn(button);
                GameModel.GameBoard[row, column] = GameModel.CurrentPlayer;

                if (GameModel.CheckForWin())
                {
                    MessageBox.Show($"{GameModel.CurrentPlayer} wins!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetGame();
                }
                else
                {
                    if (GameModel.IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetGame();
                    }
                    else
                    {
                        GameModel.ToggleCurrentPlayer();
                    }
                }
            }
        }
        private void ResetGame()
        {
            GameModel = new TikTacToeModel();

            // Clear the game board
            foreach (Button button in MainGrid.Children)
            {
                button.Content = "";
            }
        }
    }
}
