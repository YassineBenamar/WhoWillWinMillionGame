using MyProject4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject4
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            Round.RoundNumber = 1;
            lblGameOver.Text = "You Lose";
            lblMoney.Text = "0 $";
            //MoneyFromLevel();
            QuestionFromLevel();
        }

        enum enLevel { Easy, Medium, Hard, VeryHard, Million };
        enum enCatgory { Sport, Health,Technology,Geography,History,Science}
        enum enWinner { Win,Lose};

        struct stRound
        {
            public string Question;
            public string Answer1;
            public string Answer2;
            public string Answer3;
            public string Answer4;
            public string Category;
            public byte RoundNumber;
            public string RoundMoney;
            public string RightAnswer;
            public byte InvisibleAnswer;
        }

        stRound Round;
        struct stGameStatus
        {
            public enWinner Winner;
        }

        stGameStatus GameStatus;

        Random rnd = new Random();
        private void button_Click(object sender, EventArgs e)
        {
            WinConditions((Button)sender);
            GameWinner();
            WinOrLose((Button)sender);
            VisibleAnswersButtons();
        }
      
        public void MoneyFromLevel()
        {
            switch (Round.RoundNumber)
            {
                case 1:
                    {
                        Round.RoundMoney = "200,000";
                        lbl200.BackColor = Color.Black;
                        break;
                    }

                case 2:
                    {
                        Round.RoundMoney = "400,000";
                        lbl400.BackColor = Color.Black;
                        break;
                    }

                case 3:
                    {
                        Round.RoundMoney = "600,000";
                        lbl600.BackColor = Color.Black;
                        break;
                    }

                case 4:
                    {
                        Round.RoundMoney = "800,000";
                        lbl800.BackColor = Color.Black;
                        break;
                    }

                case 5:
                    {
                        Round.RoundMoney = "1,000,000";
                        lbl1000.BackColor = Color.Black;
                        break;
                    }
            }
        }

        public void EasyQuestions()
        {
            int X = rnd.Next(1, 5);

            switch (X)
            {
                case 1:
                    {
                        Round.Question = "What vegetable is known to help you see in the dark?";
                        Round.Answer1 = "Tomatoes";
                        Round.Answer2 = "Carrot";
                        Round.Answer3 = "Cucumber";
                        Round.Answer4 = "Potatoes";
                        Round.Category = "Health";
                        Round.RightAnswer = "Carrot";
                        break;
                    }

                case 2:
                    {
                        Round.Question = "What sport does Cristiano Ronaldo play?";
                        Round.Answer1 = "FootBall";
                        Round.Answer2 = "BasketBall";
                        Round.Answer3 = "VolleyBall";
                        Round.Answer4 = "Tennis";
                        Round.Category = "Sport";
                        Round.RightAnswer = "FootBall";
                        break;
                    }

                case 3:
                    {
                        Round.Question = "Which country has a red flag with a star in the middle?";
                        Round.Answer1 = "Oman";
                        Round.Answer2 = "Senegeal";
                        Round.Answer3 = "North Korea";
                        Round.Answer4 = "Marocco";
                        Round.Category = "Geography";
                        Round.RightAnswer = "Marocco";
                        break;          
                    }
                case 4:
                    {
                        Round.Question = "What animal cannot stick out its tongue?";
                        Round.Answer1 = "Lion";
                        Round.Answer2 = "Crocodile";
                        Round.Answer3 = "Cat";
                        Round.Answer4 = "Dog";
                        Round.Category = "Science";
                        Round.RightAnswer = "Crocodile";
                        break;
                    }
            }
        }
        public void MediumQuestions()
        {
            int X = rnd.Next(1, 5);

            switch (X)
            {
                case 1:
                    {
                        Round.Question = "What is the world’s longest river called?";
                        Round.Answer1 = "Amazon";
                        Round.Answer2 = "Le Congo";
                        Round.Answer3 = "Nile";
                        Round.Answer4 = "Mississippi";
                        Round.Category = "Geogrphy";
                        Round.RightAnswer = "Nile";
                        break;
                    }

                case 2:
                    {
                        Round.Question = "How many days are in a leap year";
                        Round.Answer1 = "360";
                        Round.Answer2 = "363";
                        Round.Answer3 = "365";
                        Round.Answer4 = "366";
                        Round.Category = "Science";
                        Round.RightAnswer = "366";
                        break;
                    }

                case 3:
                    {
                        Round.Question = "What happened during the years 1939-1945?";
                        Round.Answer1 = "World War I";
                        Round.Answer2 = "World War II";
                        Round.Answer3 = "World War III";
                        Round.Answer4 = "Cold War";
                        Round.Category = "History";
                        Round.RightAnswer = "World War II";
                        break;
                    }

                case 4:
                    {
                        Round.Question = "Kung Fu was originated from which country?";
                        Round.Answer1 = "Japon";
                        Round.Answer2 = "Brazil";
                        Round.Answer3 = "China";
                        Round.Answer4 = "America";
                        Round.Category = "Sport";
                        Round.RightAnswer = "China";
                        break;
                    }
            }
        }
        public void HardQuestions()
        {
            int X = rnd.Next(1, 5);

            switch (X)
            {
                case 1:
                    {
                        Round.Question = "Which city hosted the Summer Olympics in 2012?";
                        Round.Answer1 = "Pekin";
                        Round.Answer2 = "NewYork";
                        Round.Answer3 = "Paris";
                        Round.Answer4 = "London";
                        Round.Category = "Sport";
                        Round.RightAnswer = "London";
                        break;
                    }

                case 2:
                    {
                        Round.Question = "What is the rarest blood type?";
                        Round.Answer1 = "A positive";
                        Round.Answer2 = "AB negative";
                        Round.Answer3 = "O positive";
                        Round.Answer4 = "A Negative";
                        Round.Category = "Science";
                        Round.RightAnswer = "AB negative";
                        break;
                    }

                case 3:
                    {
                        Round.Question = "In which ocean is the Bermuda Triangle located";
                        Round.Answer1 = "Indian";
                        Round.Answer2 = "Pacific";
                        Round.Answer3 = "Atlantic";
                        Round.Answer4 = "Arctic";
                        Round.Category = "Geography";
                        Round.RightAnswer = "Atlantic";
                        break;
                    }

                case 4:
                    {
                        Round.Question = "How many times has the Mona Lisa been stolen?";
                        Round.Answer1 = "One";
                        Round.Answer2 = "Two";
                        Round.Answer3 = "Three";
                        Round.Answer4 = "Four";
                        Round.Category = "History";
                        Round.RightAnswer = "One";
                        break;
                    }
            }


        }
        public void VeryHardQuestions()
        {
            int X = rnd.Next(1, 5);

            switch (X)
            {
                case 1:
                    {
                        Round.Question = "How many bones are there in the human body?";
                        Round.Answer1 = "200";
                        Round.Answer2 = "203";
                        Round.Answer3 = "206";
                        Round.Answer4 = "210";
                        Round.Category = "Science";
                        Round.RightAnswer = "206";
                        break;
                    }

                case 2:
                    {
                        Round.Question = "Which planet is closest to Earth?";
                        Round.Answer1 = "Jupiter";
                        Round.Answer2 = "Venus";
                        Round.Answer3 = "Mercure";
                        Round.Answer4 = "Neptune";
                        Round.Category = "Geography";
                        Round.RightAnswer = "Venus";
                        break;
                    }

                case 3:
                    {
                        Round.Question = "How many hearts does an octopus have?";
                        Round.Answer1 = "3";
                        Round.Answer2 = "4";
                        Round.Answer3 = "5";
                        Round.Answer4 = "6";
                        Round.Category = "Science";
                        Round.RightAnswer = "3";
                        break;
                    }

                case 4:
                    {
                        Round.Question = "In a website browser, what does “www” stand for?";
                        Round.Answer1 = "World Wide Web";
                        Round.Answer2 = "Web Wireless Wide";
                        Round.Answer3 = "World Width Web";
                        Round.Answer4 = "Word Wide Web";
                        Round.Category = "Technology";
                        Round.RightAnswer = "World Wide Web";
                        break;
                    }
            }
        }
        public void MillionQuestuions()
        {
            int X = rnd.Next(1, 5);

            switch (X)
            {
                case 1:
                    {
                        Round.Question = "What temperature (in Fahrenheit) does water freeze at?";
                        Round.Answer1 = "32 degree";
                        Round.Answer2 = "35 degree";
                        Round.Answer3 = "40 degree";
                        Round.Answer4 = "43 degree";
                        Round.Category = "Science";
                        Round.RightAnswer = "32 degree";
                        break;
                    }

                case 2:
                    {
                        Round.Question = "What language do Quebec people speak there?";
                        Round.Answer1 = "English";
                        Round.Answer2 = "Arabic";
                        Round.Answer3 = "French";
                        Round.Answer4 = "Spanish";
                        Round.Category = "Geography";
                        Round.RightAnswer = "French";
                        break;
                    }

                case 3:
                    {
                        Round.Question = "Who founded Microsoft?";
                        Round.Answer1 = "Mark Zuckerberg";
                        Round.Answer2 = "Steve Jobs";
                        Round.Answer3 = "Bill Gates";
                        Round.Answer4 = "Elon Mask";
                        Round.Category = "Technology";
                        Round.RightAnswer = "Bill Gates";
                        break;
                    }
                case 4:
                    {
                        Round.Question = "How many stars are there on the American flag?\r\n";
                        Round.Answer1 = "40";
                        Round.Answer2 = "44";
                        Round.Answer3 = "46";
                        Round.Answer4 = "50";
                        Round.Category = "Geography";
                        Round.RightAnswer = "50";
                        break;
                    }
            }
        }

        public void CategoryColor()
        {
            switch (Round.Category)
            {
                case "Sport":
                    {
                        lblCategory.BackColor = Color.Blue;
                        break;
                    }

                case "Health":
                    {
                        lblCategory.BackColor = Color.Red;
                        break;
                    }

                case "Technology":
                    {
                        lblCategory.BackColor = Color.DarkOrange;
                        break;
                    }

                case "Geography":
                    {
                        lblCategory.BackColor = Color.Black;
                        break;
                    }

                case "History":
                    {
                        lblCategory.BackColor = Color.Brown;
                        break;
                    }

                case "Science":
                    {
                        lblCategory.BackColor = Color.Green;
                        break;
                    }
            }
        }
        public void PlayGameRound()
        {
            lblQuestion.Text = Round.Question;
            btn1.Text = Round.Answer1;
            btn2.Text = Round.Answer2;
            btn3.Text = Round.Answer3;
            btn4.Text = Round.Answer4;
            lblCategory.Text = Round.Category;
            CategoryColor();
            Round.RoundNumber++;
        }

        public void QuestionFromLevel()
        {
            MoneyFromLevel();
            switch (Round.RoundNumber)
            {
                case 1:
                    {
                        EasyQuestions();
                        PlayGameRound();
                        break;
                    }

                case 2:
                    {
                        MediumQuestions();
                        PlayGameRound();
                        break;
                    }

                case 3:
                    {
                        HardQuestions();
                        PlayGameRound();
                        break;
                    }

                case 4:
                    {
                        VeryHardQuestions();
                        PlayGameRound();
                        break;
                    }

                case 5:
                    {
                        MillionQuestuions();
                        PlayGameRound();
                        break;
                    }

                default:
                    {
                        DisableAnswersButtons();
                        Form frm1 = new Million();
                        frm1.ShowDialog();
                        break;
                    }


            }
        }

        public void WinOrLose(Button btn)
        {
            Thread.Sleep(2000);

            if (btn.Text == Round.RightAnswer)
            {
                QuestionFromLevel();
            }
            else
            {
                DisableButtons();
                Form frm1 = new GameResult(lblGameOver.Text, lblMoney.Text);
                frm1.ShowDialog();
            }
        }
        public void WinConditions(Button btn)
        {
            if (btn.Text == Round.RightAnswer)
            {
                GameStatus.Winner = enWinner.Win;

            }
            else
                GameStatus.Winner = enWinner.Lose;
        }
        public void GameWinner()
        {
            if (GameStatus.Winner == enWinner.Lose)
            {

                lblGameOver.Text = "You Lose";
                lblMoney.Text = "0 $";
            }

            if (GameStatus.Winner==enWinner.Win)
            {
                
                lblGameOver.Text = "You Win";
                lblMoney.Text = Round.RoundMoney;
            }
        }

        public void ChangeBackColorButton(Button btn)
        {
            btn.BackColor = Color.Yellow;
            btn.ForeColor = Color.Black;
        }
        public void ReturnBackColorButton(Button btn)
        {
            btn.BackColor = Color.MidnightBlue;
            btn.ForeColor = Color.White;
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            ChangeBackColorButton(btn1);
        }
        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            ReturnBackColorButton(btn1);
        }
        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            ChangeBackColorButton(btn2);
        }
        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            ReturnBackColorButton(btn2);
        }
        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            ChangeBackColorButton(btn3);
        }
        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            ReturnBackColorButton(btn3);
        }
        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            ChangeBackColorButton(btn4);
        }
        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            ReturnBackColorButton(btn4);
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Form frm1 = new GameResult(lblGameOver.Text, lblMoney.Text);
            frm1.ShowDialog();
           
        }
        public void DeleteFalseAnswer()
        {
            int FalseButton = rnd.Next(1, 5);
            
            switch(FalseButton)
            {
                case 1:
                    {
                        if (btn1.Text != Round.RightAnswer &&
                            Round.InvisibleAnswer < 2 && btn1.Visible==true)
                        {
                            btn1.Visible = false;
                            Round.InvisibleAnswer++;
                        }
                        break;
                    }

                case 2:
                    {
                        if (btn2.Text != Round.RightAnswer &&
                            Round.InvisibleAnswer < 2 && btn2.Visible == true)
                        {
                            btn2.Visible = false;
                            Round.InvisibleAnswer++;
                        }
                        break;
                    }

                case 3:
                    {
                        if(btn3.Text!=Round.RightAnswer&&
                            Round.InvisibleAnswer<2&&btn3.Visible==true)
                        {
                            btn3.Visible = false;
                            Round.InvisibleAnswer++;
                        }
                        break;
                    }

                case 4:
                    {
                        if(btn4.Text!=Round.RightAnswer&&
                            Round.InvisibleAnswer<2&&btn4.Visible==true)
                        {
                            btn4.Visible = false;
                            Round.InvisibleAnswer++;
                            
                        }
                        break;
                    }
            }
        }
        private void btn50Div50_Click(object sender, EventArgs e)
        {

            while (Round.InvisibleAnswer != 2)
            {
                DeleteFalseAnswer();
            }
            btn50Div50.Enabled = false;
            btn50Div50.Image = Resources.Cross;
        }
        private void btnAnother_Click(object sender, EventArgs e)
        {
            Round.RoundNumber--;
            VisibleAnswersButtons();
            QuestionFromLevel();
            btnAnother.Enabled = false;
            btnAnother.Image = Resources.Cross;
        }

        public void VisibleAnswersButtons()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
        }
        public void DisableAnswersButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
        }
        public void DisableButtons()
        {
            DisableAnswersButtons();
            btn50Div50.Enabled = false;
            btnAnother.Enabled = false;
            btnSurrender.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
  

    }
