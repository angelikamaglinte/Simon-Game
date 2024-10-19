using static Assignment1_SimonGame.Form1;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Media;

namespace Assignment1_SimonGame
{
    public partial class Form1 : Form
    {
        int GameState = 1;
        List<int> SimonSays = new List<int>();
        int LastClickIndex = 0;
        int Score = 0;
        int CurrentIndex = 0;
        Random random = new Random();
        List<HighScore> HighScores = new List<HighScore>();

        SoundPlayer startSound = new SoundPlayer(Assignment1_SimonGame.Properties.Resources.start);
        SoundPlayer nextLevelSound = new SoundPlayer(Assignment1_SimonGame.Properties.Resources.next_level);
        SoundPlayer wrongMoveSound = new SoundPlayer(Assignment1_SimonGame.Properties.Resources.wrong_move);

        public Form1()
        {
            InitializeComponent();
            HighScores = new List<HighScore>();
            timerFlash.Interval = 500;
            timerFlash.Tick += new EventHandler(timerFlash_Tick);
        }

        public class HighScore
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }

            public HighScore(string name, int score)
            {
                PlayerName = name;
                Score = score;
            }
        }

        void ShowHighScores()
        {
            //string highScoreMessage = "High Scores:\n";
            //foreach (var highScore in HighScores)
            //{
            //    highScoreMessage += $"{highScore.PlayerName}: {highScore.Score}\n";
            //}
            //MessageBox.Show(highScoreMessage, "High Scores");

            // ************************** updated ShowHighScores **************************
            // clear the ListBox before adding new high scores
            listBoxHighScores.Items.Clear();


            string highScoreMessage = "High Scores:\n";
            foreach (var highScore in HighScores)
            {
                highScoreMessage += $"{highScore.PlayerName}: {highScore.Score}\n";
                listBoxHighScores.Items.Add($"{highScore.PlayerName}: {highScore.Score}");
            }

            // display the high scores in the MessageBox as well
            MessageBox.Show(highScoreMessage, "High Scores");
        }

        string PromptForPlayerName()
        {
            // updated PromptForPlayerName to include validation
            string playerName;
            do
            {
                playerName = Microsoft.VisualBasic.Interaction.InputBox("Please enter your name for the score board:", "New High Score");
                // trim to remove leading and trailing spaces on playerName
                playerName = playerName.Trim();

                if (string.IsNullOrEmpty(playerName))
                {
                    MessageBox.Show("Player name cannot be blank. Please enter a valid name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } while (string.IsNullOrEmpty(playerName)); // loop until the user inputs a valid name
            return playerName;
        }


        void ResetGame()
        {
            //// show game over message box here
            //MessageBox.Show("Oops, game over! Your final score is: " + Score);

            //GameState = 4;
            //timerAssign.Enabled = false;
            //btnStart.Enabled = false;
            //LastClickIndex = 0;
            //CurrentIndex = 0;
            //btnStart.Text = "Start Game";
            //UpdateScore(0);
            //Console.WriteLine("Lost game!");
            //SimonSays.Clear();
            //SetColor("All");
            //timerRead.Enabled = true;

            // ************************** updated ResetGame to include High Score **************************
            // show game over message box here
            MessageBox.Show("Oops, game over! Your final score is: " + Score);

            // check if the current score is a new high score
            if (HighScores.Count < 3 || Score > HighScores.Min(hs => hs.Score)) // Keep top 3 high scores
            {
                string playerName = PromptForPlayerName();
                HighScores.Add(new HighScore(playerName, Score));

                // sort the list by score in descending order and keep only top 5
                HighScores = HighScores.OrderByDescending(hs => hs.Score).Take(3).ToList();
            }

            GameState = 4;
            timerAssign.Enabled = false;
            btnStart.Enabled = false;
            LastClickIndex = 0;
            CurrentIndex = 0;
            btnStart.Text = "Start Game";
            UpdateScore(0);
            Console.WriteLine("Lost game!");
            SimonSays.Clear();
            SetColor("All");
            timerRead.Enabled = true;

            // show high scores
            ShowHighScores();
        }

        void SetColor(string Color)
        {
            Console.WriteLine(Color);
            pictureBoxGame.Image = (Image)Assignment1_SimonGame.Properties.Resources.ResourceManager.GetObject(Color + "_Simon");
        }

        int RandomColorGenerator()
        {
            return random.Next(0, 4);
        }

        void AssignRead()
        {
            CurrentIndex = 0;
            SimonSays.Add(RandomColorGenerator());
            Console.WriteLine("Colors:");
            timerAssign.Enabled = true;
        }

        void UpdateScore(int NewScore)
        {
            Score = NewScore;
            lblScore.Text = "Score: " + Score.ToString();
        }

        void CheckResponse(int id)
        {
            if (SimonSays.Count > 0)
            {
                if (SimonSays.ElementAt(LastClickIndex) == id)
                {
                    LastClickIndex++;
                    if (LastClickIndex == SimonSays.Count)
                    {
                        nextLevelSound.Play();
                        LastClickIndex = 0;
                        UpdateScore(Score + 1);
                        Console.WriteLine("Win!");
                        GameState = 2;
                        AssignRead();
                    }
                }
                else
                {
                    wrongMoveSound.Play();
                    ResetGame();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (GameState == 1)
            {
                startSound.Play();
                GameState = 2;
                btnStart.Text = "Stop Game";
                AssignRead();
            }
            else if (GameState == 4)
            {

            }
            else
            {
                ResetGame();
            }
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            // Reset the game panel to default (off) state
            pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;
            timerFlash.Enabled = false; // Stop flashing, go back to assigning
            CurrentIndex++;
            timerAssign.Enabled = true; // Continue to the next color
        }

        private void timerAssign_Tick(object sender, EventArgs e)
        {
            pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;
            if (CurrentIndex == SimonSays.Count)
            {
                pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;
                CurrentIndex = 0;
                timerAssign.Enabled = false;
                GameState = 3;
            }
            else
            {
                switch (SimonSays.ElementAt(CurrentIndex))
                {
                    case 0:
                        SetColor("Green");
                        break;
                    case 1:
                        SetColor("Red");
                        break;
                    case 2:
                        SetColor("Yellow");
                        break;
                    case 3:
                        SetColor("Blue");
                        break;
                }
                //CurrentIndex++;
                timerAssign.Enabled = false; // Pause assigning to let the color flash
                timerFlash.Enabled = true;   // Start flashing timer
            }
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;
            GameState = 1;
            btnStart.Enabled = true;
            timerRead.Enabled = false;
        }

        private void pictureBoxGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameState == 3)
            {
                timerRead.Enabled = false;
                pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;

                Point relativePoint = e.Location; // set the mouse event's location, which is relative to pictureBoxGame instead
                Console.WriteLine(relativePoint.ToString());

                Console.WriteLine($"Mouse Clicked at: X = {relativePoint.X}, Y = {relativePoint.Y}");

                // top-left quadrant (green)
                if (relativePoint.X >= 0 && relativePoint.X < (701 / 2) && relativePoint.Y >= 0 && relativePoint.Y < (620 / 2))
                {
                    SetColor("Green");
                    CheckResponse(0); // green color id
                }
                // top-right quadrant (red)
                else if (relativePoint.X >= (701 / 2) && relativePoint.X <= 701 && relativePoint.Y >= 0 && relativePoint.Y < (620 / 2))
                {
                    SetColor("Red");
                    CheckResponse(1); // red color id
                }
                // bottom-left quadrant (blue)
                else if (relativePoint.X >= 0 && relativePoint.X < (701 / 2) && relativePoint.Y >= (620 / 2) && relativePoint.Y <= 620)
                {
                    SetColor("Blue");
                    CheckResponse(3); // blue color id
                }
                // bottom-right quadrant (yellow)
                else if (relativePoint.X >= (701 / 2) && relativePoint.X <= 701 && relativePoint.Y >= (620 / 2) && relativePoint.Y <= 620)
                {
                    SetColor("Yellow");
                    CheckResponse(2); // yellow color id
                }
            }
        }

        private void pictureBoxGame_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(GameState == 4))
            {
                pictureBoxGame.Image = Assignment1_SimonGame.Properties.Resources.Simon;
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.ShowDialog();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
