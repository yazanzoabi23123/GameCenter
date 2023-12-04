using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace gameCenter.Projects.CarGame
{
    internal class PlayerCar : GameObject
    {
        public bool LeftKeyPressed { get; set; }
        public bool RightKeyPressed { get; set; }

        public PlayerCar(int x, int y, int speed, Image representation)
            : base(x, y, speed, representation)
        {
        }

        public override void Move()
        {
            if (LeftKeyPressed && X > 0)
            {
                X -= Speed;
            }

            if (RightKeyPressed && X < (Application.Current.MainWindow.Width - Representation.Width))
            {
                X += Speed;
            }

            Draw();
        }

    }
}
