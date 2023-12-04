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

namespace tik_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 

          private char _currentPlayer = 'X';
         private char[,] _board = new char[3, 3];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if the btn content is empty -> show the X or O in the button && update the matrix
            Button btn = (Button)sender;
            if (btn.Content == null)
            {
                btn.Content = _currentPlayer;
                int row = Grid.GetRow(btn);
                int col = Grid.GetColumn(btn);
                _board[row, col] = _currentPlayer;

                //change the player from 1 to 2 or vice versa
                _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';

                if (CheckForWin())
                {
                    MessageBox.Show($"{_currentPlayer} wins!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetGame();
                }
                else
                {
                    if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetGame();
                    }

                }
            }
        }
        private bool CheckForWin()
        {
            return false;
        }
        private bool IsBoardFull()
        {
            return false;

        }

        private void ResetGame()
        {
            _currentPlayer = 'X';
            _board = new char[3, 3];
            foreach (Button button in MainGrid.Children)
            {
                button.Content = null;
            }
        }
    }
}
