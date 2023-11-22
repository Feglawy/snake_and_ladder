namespace snake_and_ladder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BoardBox = new PictureBox();
            Roll_button = new Button();
            New_game_button = new Button();
            DiceBox = new PictureBox();
            panel1 = new Panel();
            Player2_loc_label = new Label();
            Player1_loc_label = new Label();
            label5 = new Label();
            label6 = new Label();
            Turn_Label = new Label();
            Player2_score = new Label();
            Player1_score = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Player1 = new PictureBox();
            Player2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BoardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiceBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2).BeginInit();
            SuspendLayout();
            // 
            // BoardBox
            // 
            BoardBox.BackColor = Color.White;
            BoardBox.BackgroundImageLayout = ImageLayout.Stretch;
            BoardBox.Image = Properties.Resources.board;
            BoardBox.Location = new Point(12, 12);
            BoardBox.Name = "BoardBox";
            BoardBox.Size = new Size(776, 741);
            BoardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BoardBox.TabIndex = 0;
            BoardBox.TabStop = false;
            // 
            // Roll_button
            // 
            Roll_button.Location = new Point(794, 497);
            Roll_button.Name = "Roll_button";
            Roll_button.Size = new Size(186, 79);
            Roll_button.TabIndex = 1;
            Roll_button.Text = "Roll the dice";
            Roll_button.UseVisualStyleBackColor = true;
            Roll_button.Click += Roll_button_Click;
            // 
            // New_game_button
            // 
            New_game_button.Location = new Point(798, 674);
            New_game_button.Name = "New_game_button";
            New_game_button.Size = new Size(186, 79);
            New_game_button.TabIndex = 2;
            New_game_button.Text = "New game";
            New_game_button.UseVisualStyleBackColor = true;
            New_game_button.Click += New_game_button_Click;
            // 
            // DiceBox
            // 
            DiceBox.Location = new Point(795, 328);
            DiceBox.Name = "DiceBox";
            DiceBox.Size = new Size(185, 163);
            DiceBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DiceBox.TabIndex = 3;
            DiceBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(Player2_loc_label);
            panel1.Controls.Add(Player1_loc_label);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Turn_Label);
            panel1.Controls.Add(Player2_score);
            panel1.Controls.Add(Player1_score);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(795, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 260);
            panel1.TabIndex = 5;
            // 
            // Player2_loc_label
            // 
            Player2_loc_label.AutoSize = true;
            Player2_loc_label.Location = new Point(141, 205);
            Player2_loc_label.Name = "Player2_loc_label";
            Player2_loc_label.Size = new Size(13, 15);
            Player2_loc_label.TabIndex = 9;
            Player2_loc_label.Text = "1";
            // 
            // Player1_loc_label
            // 
            Player1_loc_label.AutoSize = true;
            Player1_loc_label.Location = new Point(141, 178);
            Player1_loc_label.Name = "Player1_loc_label";
            Player1_loc_label.Size = new Size(13, 15);
            Player1_loc_label.TabIndex = 8;
            Player1_loc_label.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 205);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 7;
            label5.Text = "Player2 location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 178);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 6;
            label6.Text = "Player1 location";
            // 
            // Turn_Label
            // 
            Turn_Label.AutoSize = true;
            Turn_Label.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Turn_Label.Location = new Point(36, 146);
            Turn_Label.Name = "Turn_Label";
            Turn_Label.Size = new Size(110, 22);
            Turn_Label.TabIndex = 5;
            Turn_Label.Text = "Turn: player1";
            // 
            // Player2_score
            // 
            Player2_score.AutoSize = true;
            Player2_score.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Player2_score.Location = new Point(141, 112);
            Player2_score.Name = "Player2_score";
            Player2_score.Size = new Size(14, 16);
            Player2_score.TabIndex = 4;
            Player2_score.Text = "0";
            // 
            // Player1_score
            // 
            Player1_score.AutoSize = true;
            Player1_score.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Player1_score.Location = new Point(34, 112);
            Player1_score.Name = "Player1_score";
            Player1_score.Size = new Size(14, 16);
            Player1_score.TabIndex = 3;
            Player1_score.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 88);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 2;
            label3.Text = "Score";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Player2;
            pictureBox2.Location = new Point(111, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Player1;
            pictureBox1.Location = new Point(7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(794, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 6;
            label1.Text = "Player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(900, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 7;
            label2.Text = "Player 2";
            // 
            // Player1
            // 
            Player1.BackColor = Color.Transparent;
            Player1.BackgroundImageLayout = ImageLayout.Stretch;
            Player1.Image = Properties.Resources.Player1;
            Player1.Location = new Point(77, 665);
            Player1.Name = "Player1";
            Player1.Size = new Size(26, 52);
            Player1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1.TabIndex = 8;
            Player1.TabStop = false;
            // 
            // Player2
            // 
            Player2.BackColor = Color.Transparent;
            Player2.BackgroundImageLayout = ImageLayout.Stretch;
            Player2.Image = Properties.Resources.Player2;
            Player2.Location = new Point(43, 665);
            Player2.Name = "Player2";
            Player2.Size = new Size(28, 52);
            Player2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player2.TabIndex = 9;
            Player2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(992, 765);
            Controls.Add(Player1);
            Controls.Add(Player2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(DiceBox);
            Controls.Add(New_game_button);
            Controls.Add(Roll_button);
            Controls.Add(BoardBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Snake and ladder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BoardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiceBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoardBox;
        private Button Roll_button;
        private Button New_game_button;
        private PictureBox DiceBox;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label Turn_Label;
        private Label Player2_score;
        private Label Player1_score;
        private Label label3;
        private PictureBox Player1;
        private PictureBox Player2;
        private Label label5;
        private Label label6;
        private Label Player1_loc_label;
        private Label Player2_loc_label;
    }
}