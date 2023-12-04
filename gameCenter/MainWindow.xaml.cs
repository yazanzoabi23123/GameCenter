using gameCenter.Projects;
using gameCenter.Projects.CarGame;
using gameCenter.Projects.CurrencyConvertor;
using gameCenter.Projects.GameTicTacToe;
using gameCenter.Projects.PacMan;
using gameCenter.Projects.Project1;
using gameCenter.Projects.TodoList;
using gameCenter.Projects.TodoList.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;


namespace gameCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Project1 project1 = new Project1();
        public MainWindow()
        {

            InitializeComponent();
            DispatcherTimer clock = new()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            clock.Tick += Tick!;
            clock.Start();


        }
        private void Tick(object sender, EventArgs e)
        {
            DateLabel.Content = DateTime.UtcNow.ToString("dddd dd MMMM yyyy HH:mm:ss");
        }
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (sender as Image)!;
            image.Opacity = 0.7;
            GameText.Content = (image.Name) switch
            {
                "Image1" => "a User Management System",
                "Image2" => "To Do List",
                "Image3" => "Currency Converter",
                "Image4" => "Tec Tac Toe",
                "Image5" => "Pac Man",
                "Image6" => "Car Game",
                _ => "please pick a game"
            };
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image)!.Opacity = 1;
            GameText.Content = "please pick a game";
        }

        private void Image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Project1 project1 = new();
            Hide();
            project1.ShowDialog();
            Show();
        }
        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TodoList todoListProject = new();
            Hide();
            todoListProject.ShowDialog();
            Show();
        }
        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CurrencyConvertorView currencyConvertorView = new();
            Hide();
            currencyConvertorView.ShowDialog();
            Show();
        }
        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TicTacToe tictactoe = new();
            Hide();
            tictactoe.ShowDialog();
            Show();
        }
        private void Image5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PacManGame pacMan = new();
            Hide();
            pacMan.ShowDialog();
            Show();
        }
        private void Image6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CarGameView carGame = new();
            Hide();
            carGame.ShowDialog();
            Show();
        }
        private void OnImage1Click(object sender, MouseButtonEventArgs e)

        {

            Project1 project1 = new();

            ProjectPresentationPage presentetion = new();

            presentetion.OnStart("To-Do List", "" +

                "s simply dummy text of the printing and typesetting industry. " +

                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +

                "when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +

                "It has survived not only five centuries, but also the leap into electronic typesetting, " +

                "remaining essentially unchanged. " +

                "It was popularised in the 1960s with the release of Letraset sheets containing Lorem " +

                "Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker " +

                "including versions of Lorem Ipsum.", Image1.Source, project1);

        }

        private void OnImage2Click(object sender, MouseButtonEventArgs e)

        {

            Project1 project1 = new();

            ProjectPresentationPage presentetion = new();

            presentetion.OnStart(

                "PacMan", "" +

                "this is pucman",

                Image2.Source,

                project1

            );

        }


    }
}
