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
using System.Windows.Threading;

namespace gameCenter.Projects.CarGame
{
    /// <summary>
    /// Interaction logic for CarGameView.xaml
    /// </summary>
    public partial class CarGameView : Window
    {
        private PlayerCar playerCar;
        private List<Obstacle> obstacles;
        private Random random;
        int score = 0;
        public MediaState LoadedBehavior { get; set; }

        public CarGameView()
        {
            InitializeComponent();
            playerCar = new PlayerCar(200, 300, 20, playerCarImage);
            obstacles = new List<Obstacle>();
            random = new Random();
            MediaElement backgroundVideo = new MediaElement();
            backgroundVideo.LoadedBehavior = MediaState.Manual; 
            backgroundVideo.Source = new Uri("D://C#//gameCenter//Projects//CarGame/Car Driving.mp4", UriKind.Relative);
            backgroundVideo.Play();
            backgroundVideo.IsMuted = true;
            DispatcherTimer gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.Left:
                    playerCar.LeftKeyPressed = true;
                    break;
                case Key.Right:
                    playerCar.RightKeyPressed = true;
                    break;
            }
        }

        protected override void OnPreviewKeyUp(KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.Left:
                    playerCar.LeftKeyPressed = false;
                    break;
                case Key.Right:
                    playerCar.RightKeyPressed = false;
                    break;
            }
        }
        private void GameLoop(object sender, EventArgs e)
        {
            playerCar.Move();
            txtScore.Content = "Score: " + score;


            if (random.Next(0, 50) == 1)
            {
                Image obstacleImage = new Image();
                obstacleImage.Source = new BitmapImage(new Uri("D://C#//gameCenter//Projects//CarGame/Bomb.png"));
                obstacleImage.Width = 50;
                obstacleImage.Height = 50;
                Obstacle obstacle = new Obstacle(random.Next(0, (int)Width), 0, 2, obstacleImage);
                obstacles.Add(obstacle);
                gameCanvas.Children.Add(obstacleImage);
            }

            double collisionBuffer = 5;

            foreach (var obstacle in obstacles)
            {
                obstacle.Move();
                if (playerCar.Representation.Margin.Left + playerCar.Representation.Width - collisionBuffer >= obstacle.Representation.Margin.Left + collisionBuffer
                    && playerCar.Representation.Margin.Left + collisionBuffer <= obstacle.Representation.Margin.Left + obstacle.Representation.Width - collisionBuffer
                    && playerCar.Representation.Margin.Top + collisionBuffer <= obstacle.Representation.Margin.Top + obstacle.Representation.Height - collisionBuffer
                    && playerCar.Representation.Margin.Top + playerCar.Representation.Height - collisionBuffer >= obstacle.Representation.Margin.Top + collisionBuffer)
                {
                    // End the game
                    MessageBox.Show("Game over , you lost");
                    (sender as DispatcherTimer).Stop();
                    break;
                }
                if (obstacle.Y == 450)
                {
                    score++;
                    if (score == 6)
                    {
                        MessageBox.Show("You win , you survived all the bombs");

                        (sender as DispatcherTimer).Stop();
                        break;
                    }
                }
            }
        }

        }
}
