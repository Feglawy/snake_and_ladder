using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using snake_and_ladder.Properties;

namespace Snake_and_ladders
{
    internal class logics
    {

        public static int Roll(PictureBox pbx)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);

            Image myImage = (Image)Resources.ResourceManager.GetObject(dice.ToString());
            pbx.Image = myImage;
            return dice;
        }

        public static async Task<Point> Go_to(PictureBox pbx, int new_loc, int animationDurationMs = 500)
        {
            Dictionary<int, Point> location = new Dictionary<int, Point>()
            {
                { 1, new Point(40, 660) },
                { 2, new Point(115, 660) },
                { 3, new Point(190, 660) },
                { 4, new Point(265, 660) },
                { 5, new Point(340, 660) },
                { 6, new Point(415, 660) },
                { 7, new Point(490, 660) },
                { 8, new Point(565, 660) },
                { 9, new Point(640, 660) },
                { 10, new Point(715, 660) },
                { 11, new Point(715, 590) },
                { 12, new Point(640, 590) },
                { 13, new Point(565, 590) },
                { 14, new Point(490, 590) },
                { 15, new Point(415, 590) },
                { 16, new Point(340, 590) },
                { 17, new Point(265, 590) },
                { 18, new Point(190, 590) },
                { 19, new Point(115, 590) },
                { 20, new Point(40, 590) },
                { 21, new Point(40, 520) },
                { 22, new Point(115, 520) },
                { 23, new Point(190, 520) },
                { 24, new Point(265, 520) },
                { 25, new Point(340, 520) },
                { 26, new Point(415, 520) },
                { 27, new Point(490, 520) },
                { 28, new Point(565, 520) },
                { 29, new Point(640, 520) },
                { 30, new Point(715, 520) },
                { 31, new Point(715, 450) },
                { 32, new Point(640, 450) },
                { 33, new Point(565, 450) },
                { 34, new Point(490, 450) },
                { 35, new Point(415, 450) },
                { 36, new Point(340, 450) },
                { 37, new Point(265, 450) },
                { 38, new Point(190, 450) },
                { 39, new Point(115, 450) },
                { 40, new Point(40, 450) },
                { 41, new Point(40, 380) },
                { 42, new Point(115, 380) },
                { 43, new Point(190, 380) },
                { 44, new Point(265, 380) },
                { 45, new Point(340, 380) },
                { 46, new Point(415, 380) },
                { 47, new Point(490, 380) },
                { 48, new Point(565, 380) },
                { 49, new Point(640, 380) },
                { 50, new Point(715, 380) },
                { 51, new Point(715, 310) },
                { 52, new Point(640, 310) },
                { 53, new Point(565, 310) },
                { 54, new Point(490, 310) },
                { 55, new Point(415, 310) },
                { 56, new Point(340, 310) },
                { 57, new Point(265, 310) },
                { 58, new Point(190, 310) },
                { 59, new Point(115, 310) },
                { 60, new Point(40, 310) },
                { 61, new Point(40, 240) },
                { 62, new Point(115, 240) },
                { 63, new Point(190, 240) },
                { 64, new Point(265, 240) },
                { 65, new Point(340, 240) },
                { 66, new Point(415, 240) },
                { 67, new Point(490, 240) },
                { 68, new Point(565, 240) },
                { 69, new Point(640, 240) },
                { 70, new Point(715, 240) },
                { 71, new Point(715, 170) },
                { 72, new Point(640, 170) },
                { 73, new Point(565, 170) },
                { 74, new Point(490, 170) },
                { 75, new Point(415, 170) },
                { 76, new Point(340, 170) },
                { 77, new Point(265, 170) },
                { 78, new Point(190, 170) },
                { 79, new Point(115, 170) },
                { 80, new Point(40, 170) },
                { 81, new Point(40, 100) },
                { 82, new Point(115, 100) },
                { 83, new Point(190, 100) },
                { 84, new Point(265, 100) },
                { 85, new Point(340, 100) },
                { 86, new Point(415, 100) },
                { 87, new Point(490, 100) },
                { 88, new Point(565, 100) },
                { 89, new Point(640, 100) },
                { 90, new Point(715, 100) },
                { 91, new Point(715, 30) },
                { 92, new Point(640, 30) },
                { 93, new Point(565, 30) },
                { 94, new Point(490, 30) },
                { 95, new Point(415, 30) },
                { 96, new Point(340, 30) },
                { 97, new Point(265, 30) },
                { 98, new Point(190, 30) },
                { 99, new Point(115, 30) },
                { 100, new Point(40, 30) },
            };

            Point targetLocation = location[new_loc];
            Point startingLocation = pbx.Location;

            double startX = startingLocation.X;
            double startY = startingLocation.Y;
            double targetX = targetLocation.X;
            double targetY = targetLocation.Y;

            double deltaX = targetX - startX;
            double deltaY = targetY - startY;

            double startTime = Environment.TickCount;
            while (true)
            {
                double elapsed = Environment.TickCount - startTime;
                double t = Math.Clamp(elapsed / animationDurationMs, 0, 1);

                int newX = (int)(startX + t * deltaX);
                int newY = (int)(startY + t * deltaY);

                pbx.Location = new Point(newX, newY);

                if (t >= 1)
                    break;

                await Task.Delay(15); // Adjust delay to control animation smoothness
            }
            if (new_loc != Check_ledder_or_snack(new_loc))
            {
                Go_to(pbx,Check_ledder_or_snack(new_loc));
            }
            return targetLocation;
        }

        public static int Check_ledder_or_snack(int player_loc)
        {
            //snakes
            Dictionary<int, int> snakes = new Dictionary<int, int>()
            {
                { 29, 9 },
                { 38, 15 },
                { 47, 5 },
                { 53, 33 },
                { 62, 37 },
                { 86, 54 },
                { 92, 70 },
                { 97, 25 },
            };

            //ladders
            Dictionary<int, int> ladders = new Dictionary<int, int>()
            {
                { 2, 23},
                { 8, 34 },
                { 20, 77},
                { 32, 68 },
                { 41, 79},
                { 74, 88 },
                { 82, 100},
                { 85, 95 },
            };


            int new_player_loc = player_loc;

            if (ladders.ContainsKey(player_loc))
            {
                new_player_loc = ladders[player_loc];
            }
            else if (snakes.ContainsKey(player_loc))
            {
                new_player_loc = snakes[player_loc];
            }

            return new_player_loc;
        }

        public static void New_game(PictureBox Player1, PictureBox Player2, int player1_loc, int player2_loc, Label Player1_score, Label Player2_score)
        {
            if (player1_loc == 100)
            {
                MessageBox.Show("Player1 won", "you won", MessageBoxButtons.OK);
                Player1_score.Text = Convert.ToString(Convert.ToInt32(Player1_score.Text) + 1);
            }
            else if (player2_loc == 100)
            {
                MessageBox.Show("Player2 won", "you won", MessageBoxButtons.OK);
                Player2_score.Text = Convert.ToString(Convert.ToInt32(Player2_score.Text) + 1);
            }

            logics.Go_to(Player1, 1);
            logics.Go_to(Player2, 1);
        }

        public static bool is_the_same_location(int player1_loc, int player2_loc)
        {
            if (player1_loc == player2_loc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void two_pieces(PictureBox player1, PictureBox player2, int player_loc)
        {
            int row = player_loc / 10;
            if (row % 2 == 0)
            {
                Point location = player1.Location;
                location.X += 30;
                player1.Location = location;
            }
            else
            {
                Point location = player1.Location;
                location.X -= 30;
                player1.Location = location;
            }
        }
    }
}