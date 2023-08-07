using Snake_and_ladders;

namespace snake_and_ladder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Player1.Parent = BoardBox;
            Player2.Parent = BoardBox;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public int player1_loc = 1, player2_loc = 1;
        public bool turn = true;

        private void Roll_button_Click(object sender, EventArgs e)
        {
            int dice_value = logics.Roll(DiceBox);
            if (turn)
            {
                Turn_Label.Text = "Turn: Player2";
                int corrent_loc = player1_loc;
                player1_loc += dice_value;

                //-----------------------------
                //to make the players not be > 100
                if (player1_loc > 100)
                {
                    player1_loc -= dice_value;
                }
                //-----------------------------

                logics.Go_to(Player1, player1_loc);
                player1_loc = logics.Check_ledder_or_snack(player1_loc);
            }
            else
            {
                Turn_Label.Text = "Turn: Player1";
                int corrent_loc = player2_loc;
                player2_loc += dice_value;

                //-----------------------------
                //to make the players not be > 100
                if (player2_loc > 100)
                {
                    player2_loc -= dice_value;
                }
                //-----------------------------
                logics.Go_to(Player2, player2_loc);
                player2_loc = logics.Check_ledder_or_snack(player2_loc);
            }
            turn ^= true;


            //-------------------------------------------------------------------------------------------------------------------------------------------------------
            //newgame
            if (player1_loc == 100 || player2_loc == 100)
            {
                logics.New_game(Player1, Player2, player1_loc, player2_loc, Player1_score, Player2_score);
                player1_loc = 1;
                Player1_loc_label.Text = "1";
                player2_loc = 1;
                Player2_loc_label.Text = "1";
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            Player1_loc_label.Text = player1_loc.ToString();
            Player2_loc_label.Text = player2_loc.ToString();

            if (logics.is_the_same_location(player1_loc, player2_loc))
            {
                logics.two_pieces(Player1, Player2, player1_loc);
            }

        }

        private void New_game_button_Click(object sender, EventArgs e)
        {
            logics.New_game(Player1, Player2, player1_loc, player2_loc, Player1_score, Player2_score);
            player1_loc = 1;
            player2_loc = 1;
            turn = true;

            logics.two_pieces(Player1, Player2, player1_loc);

        }
    }
}