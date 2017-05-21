using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace displayingCard
{
    public partial class GameWindow : Form
    {
        Graphics myGraphics;
        Card myCard;
        Card tmpCard; // Needed for card comparison
        Deck myDeck;
        Player myOnePlayer;
        Player myTwoPlayer;
        Game myGame;
        private int condition = 0; // Controls what cards are compared


        public GameWindow(string plyOneNme, string plyTwoNme, string theState)
        //  Constructor
        {
            InitializeComponent();

            myGraphics = tablePictureBox.CreateGraphics();
            myDeck = new Deck(myGraphics);
            if (theState == "onePlyGme")
            {
                myOnePlayer = new Player(plyOneNme);
                myGame = new Game(myDeck, myOnePlayer, theState);
            }
            else if (theState == "twoPlyGme")
            {
                myOnePlayer = new Player(plyOneNme);
                myTwoPlayer = new Player(plyTwoNme);
                myGame = new Game(myDeck, myOnePlayer, myTwoPlayer, theState);
            }

        }
        public GameWindow(string plyOneNme, string theState) : this(plyOneNme, "", theState) { }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            if (myGame.State == "onePlyGme")
            {
                plyOneNmeLbl.Text = myOnePlayer.Name;

                // Turn update
                plyOneCntLbl.Text = myOnePlayer.Count.ToString();

                // Score update
                plyOneScrLbl.Text = myOnePlayer.Score.ToString();

                // Player two disabled
                turnLbl.Hide();
                plyOneCntLbl.Hide();
                plyTwoScrLbl.Hide();
                plyTwoCntLbl.Hide();
                plyTwoNmeLbl.Hide();
            }



            if (myGame.State == "twoPlyGme")
            {
                plyOneNmeLbl.Text = myOnePlayer.Name;
                plyTwoNmeLbl.Text = myTwoPlayer.Name;

                // Turn update
                plyOneCntLbl.Text = myOnePlayer.Count.ToString();
                plyTwoCntLbl.Text = myTwoPlayer.Count.ToString();

                // Score update
                plyOneScrLbl.Text = myOnePlayer.Score.ToString();
                plyTwoScrLbl.Text = myTwoPlayer.Score.ToString();
            }
        }

        private void tablePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = 0;
            for (int i = 0; i < myDeck.Card.Length; i++)
            {
                myCard = myDeck.Card[i];
                if (myCard.MySpace.Contains(e.Location) && myCard.Rm != false) // Prevents previous cards from being clicked again
                {
                    myCard.flip();
                    myCard.display();
                    if (condition % 2 != 0) // Only happens on the second card click
                    {
                        Thread.Sleep(500);
                    }
                    index = 1; // Prevents non-card clicked errors
                    i = 51; // Breaks out of the loop

                }
            }

            if (condition % 2 != 1 && index == 1)
            {
                tmpCard = myCard; // Holds the first card flipped, waiting for comparison on the second card flip.
                condition++;

            }
            else if (index == 1)
            {
                myGame.compare(tmpCard, myCard); // Compares the card
                condition++;

                if (myGame.Count == 26) // Only true if all 52 cards have been matched
                {
                    this.Hide();
                    if (myGame.State == "onePlyGme")
                    {
                        timer1.Stop();
                        HighScores hsw = new HighScores("endGame");
                        hsw.plyName = myOnePlayer.Name;
                        hsw.Hour = myOnePlayer.Hour;
                        hsw.Min = myOnePlayer.Min;
                        hsw.Sec = myOnePlayer.Sec;
                        // Sends all player information to the highscore window for comparison.

                        hsw.ShowDialog();
                        this.Close();

                    }
                    else if (myGame.State == "twoPlyGme")
                    {
                        WinWindow ww = new WinWindow();

                        if (myOnePlayer.Score > myTwoPlayer.Score)
                        {
                            ww.WinnerName = myOnePlayer.Name;
                            ww.Winner = "p1";
                        }
                        else if (myOnePlayer.Score < myTwoPlayer.Score)
                        {
                            ww.WinnerName = myTwoPlayer.Name;
                            ww.Winner = "p2";
                        }
                        else
                        {
                            ww.Winner = "draw";
                        }

                        ww.ShowDialog();
                        this.Close();
                    }
                }
                // Turn update
                plyOneCntLbl.Text = myOnePlayer.Count.ToString();
                if (myGame.State == "twoPlyGme")
                {
                    plyTwoCntLbl.Text = myTwoPlayer.Count.ToString();
                }

                // Score update
                plyOneScrLbl.Text = myOnePlayer.Score.ToString();
                if (myGame.State == "twoPlyGme")
                {
                    plyTwoScrLbl.Text = myTwoPlayer.Score.ToString();
                }
            }
        }




        //   GAME WINDOW - TOPBAR MENU   //
        private void displayCardsToolStripMenuItem_Click(object sender, EventArgs e)
        //   Displays the cards on the screen after a new game has been called
        {
            switch (myGame.State)
            {
                case "onePlyGme":

                    myDeck.shuffle();
                    myDeck.placePosition();
                    myDeck.displayAllCards();

                    displayCardsToolStripMenuItem.Enabled = false;

                    //plyOneNmeLbl.Text = myOnePlayer.Name;

                    //// Turn update
                    //plyOneCntLbl.Text = myOnePlayer.Count.ToString();

                    //// Score update
                    //plyOneScrLbl.Text = myOnePlayer.Score.ToString();

                    //// Player two disabled
                    //plyTwoScrLbl.Enabled = false;
                    //plyTwoCntLbl.Enabled = false;
                    //plyTwoNmeLbl.Enabled = false;

                    timer1.Start();

                    break;

                case "twoPlyGme":

                    myDeck.shuffle();
                    myDeck.placePosition();
                    myDeck.displayAllCards();

                    displayCardsToolStripMenuItem.Enabled = false;

                    //plyOneNmeLbl.Text = myOnePlayer.Name;
                    //plyTwoNmeLbl.Text = myTwoPlayer.Name;

                    //// Turn update
                    //plyOneCntLbl.Text = myOnePlayer.Count.ToString();
                    //plyTwoCntLbl.Text = myTwoPlayer.Count.ToString();

                    //// Score update
                    //plyOneScrLbl.Text = myOnePlayer.Score.ToString();
                    //plyTwoScrLbl.Text = myTwoPlayer.Score.ToString();

                    break;

                //case "savedGame":

                //    break;

                default:
                    break;
            }
        }


        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        //   Starts a new game
        {
            StartWindow sw = new StartWindow();
            this.Hide();
            sw.ShowDialog();
        }


        private void pauseToolStripMenuItem_Click_1(object sender, EventArgs e)
        //   Pauses the game
        {
            timer1.Stop();
            PauseWindow pw = new PauseWindow();
            pw.ShowDialog();
            if (myOnePlayer.Sec != 0)
            {
                timer1.Start();
            }
        }


        private void gameRulesToolStripMenuItem_Click_1(object sender, EventArgs e)
        //   How to play window
        {
            timer1.Stop();
            HelpWindow hw = new HelpWindow();
            hw.ShowDialog();
            if (myOnePlayer.Sec != 0)
            {
                timer1.Start();
            }
        }


        private void hightScoreMenu_Click_1(object sender, EventArgs e)
        //   Displays highscore window
        {
            timer1.Stop();
            HighScores hsw = new HighScores();
            hsw.ShowDialog();
            if (myOnePlayer.Sec != 0)
            {
                timer1.Start();
            }
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        //   Displays exit window
        {
            timer1.Stop();
            ExitWindow ew = new ExitWindow();
            ew.ShowDialog();
            if (myOnePlayer.Sec != 0)
            {
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        //   Stopwatch engine
        {
            if (myGame.State == "onePlyGme")
            {
                timerLbl.Text = myOnePlayer.Timer;
                myOnePlayer.timer();
            }
        }
    }


    class Card
    {
        private bool rm = true;

        private int rank;
        private string suit;
        private Graphics cardTable; //      This is the image

        private int xPosition; //           X position of the card
        private int yPosition; //           Y position of the card
        private int width = 70; //          Width of the card
        private int height = 100; //        Height of the card
        private int widthPadding = 20; //   Space inbetween the cards
        private int heightPadding = 15; //  Space above the cards

        private bool faceUp = false; //             Determains card face up or face down

        public Card(Graphics cardTable, int rank, string suit)
        //    Constructor
        {
            this.cardTable = cardTable;
            this.rank = rank;
            this.suit = suit;
        }

        //    Getters and Setters
        public bool Rm
        {
            get
            {
                return rm;
            }
            set
            {
                this.rm = value;
            }
        }
        public int Rank
        {
            get
            {
                return rank;
            }
        }
        public string Suit
        {
            get
            {
                return suit;
            }
        }
        public Rectangle MySpace
        {
            get
            {
                return new Rectangle(XPosition, YPosition, Width, Height);
            }
        }//    Returns a rectangle shape to be used in the display method
        public int XPosition
        {
            get
            {
                return xPosition;
            }
            set
            {
                this.xPosition = value;
            }
        }
        public int YPosition
        {
            get
            {
                return yPosition;
            }
            set
            {
                this.yPosition = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public int WidthPadding
        {
            get
            {
                return widthPadding;
            }
        }
        public int HeigthPadding
        {
            get
            {
                return heightPadding;
            }
        }
        public bool FaceUp
        {
            get
            {
                return faceUp;
            }
            set
            {
                this.faceUp = value;
            }
        }

        public void flip()
        {
            this.faceUp = !faceUp;
        }

        public void display()
        //    Displays the image on the screen
        {
            if (faceUp)
            {
                cardTable.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(suit + rank), xPosition, yPosition, width, height); //    Retrieving the image, x-position, y-position, width, heigth)
            }
            else
            {
                cardTable.DrawImage((Image)Properties.Resources.CardBack, xPosition, yPosition, width, height);
            }
        }
    }



    class Deck
    {

        private Graphics myGraphics;
        private Card[] cards;
        int topCard = 51;

        public Deck(Graphics graphic)
        //  Constructor
        {
            this.myGraphics = graphic;
            this.cards = new Card[52];
            int i = 0;

            foreach (int aRank in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 })
            {
                foreach (string aSuit in new string[] { "hearts", "diamonds", "clubs", "spades" })
                {
                    cards[i++] = new Card(graphic, aRank, aSuit);
                }
            }
        }

        public Card[] Card
        {
            get
            {
                return cards;
            }
        }

        public int TopCard
        {
            get
            {
                return topCard;
            }
            set
            {
                this.topCard = value;
            }
        }

        public void add(Card aCard)
        //  Adds cards to deck
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null)
                {
                    cards[i] = aCard;
                    return;
                }
            }
        }

        public void shuffle()
        //  Shuffles deck
        {
            Random rnd = new Random();
            int count = 10000;
            int index = 0;

            while (index < count)
            {
                int tempCard = rnd.Next(51);

                Card aCard = cards[tempCard];

                cards[tempCard] = cards[0];

                cards[0] = aCard;
                index++;
            }
        }

        public void placePosition()
        //  Sets card position
        {
            //x and y position of the cards
            int x = -60;
            int y = -80;
            int cardSpan = 13;
            for (int i = 0; i < cards.Length; i++)
            {
                if (i % cardSpan != 0) //Sets the number of cards on a row
                {
                    x += cards[i].Width + cards[i].WidthPadding;
                    cards[i].XPosition = x;
                    cards[i].YPosition = y;
                }
                else
                {
                    //x = cards[i].Width + cards[i].WidthPadding; 
                    x = 30;
                    y += cards[i].Height + cards[i].HeigthPadding;
                    cards[i].YPosition = y;
                    cards[i].XPosition = x;
                }
            }
        }

        public void faceReset()
        //  Flips all cards face down.
        {
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].FaceUp = false;
            }
        }

        public void topCardReset()
        //  Resets the topCard if the newGameBtn is pressed during a current game
        {
            if (TopCard == -1)
            {
                topCard = 51;
            }
        }

        public Card serve()
        //  Places a card on the table.
        {
            if (topCard != -1)
            {
                return cards[topCard--];
            }
            else
            {
                return null; //Unsure what to return. I could return a default card with 
            }

        }

        public void displayAllCards()
        //  Repaints the entire screen with matched pairs removed
        {
            myGraphics.FillRectangle(Brushes.White, 0, 0, 5000, 5000);
            for (int i = 0; i < cards.Length; i++)
            {
                Card servedCard = serve();
                if (servedCard.Rm != false)
                {
                    servedCard.display();
                }
            }
        }
    }



    class Player
    {

        private string name;
        private int score;
        private int count;
        private int hour, min, sec, ms;

        public Player(string aName, int aHour, int aMin, int aSec)
        //  Constructor
        {
            this.name = aName;
            this.score = 0;
            this.count = 5;
            this.hour = aHour;
            this.min = aMin;
            this.sec = aSec;
            this.ms = 0;
        }
        public Player(string aName) : this(aName, 0, 0, 0) { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                this.score = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                this.count = value;
            }
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                this.hour = value;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                this.min = value;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                this.sec = value;
            }
        }
        public string Timer
        {
            get
            {
                return hour + " : " + min + " : " + sec + " : " + ms.ToString();
            }
        }

        public void timer()
        //  Stopwatch engine
        {
            ms++;
            if (ms > 9)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }
            if (sec > 60)
            {
                min++;
                sec = 0;
            }
            if (min > 60)
            {
                hour++;
                min = 0;
            }
        }

        public void timerReset()
        {
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
        }
    }



    class Game
    {
        Deck myDeck;
        Player myOnePlayer;
        Player myTwoPlayer;

        private string state;
        private int count;
        private string playerTurn = "playerOne";

        public Game(Deck aDeck, Player newPlyOne, Player newPlyTwo, string aState)
        {
            this.myDeck = aDeck;
            this.myOnePlayer = newPlyOne;
            this.myTwoPlayer = newPlyTwo;
            this.state = aState;
            count = 0;
        }
        public Game(Deck aDeck, Player newPlyOne, string aState) : this(aDeck, newPlyOne, null, aState) { }

        public string State
        {
            get
            {
                return state;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                this.count = value;
            }
        }

        public void compare(Card firstCard, Card secondCard)
        //   Compares two cards and determines whether they are suitable for pairing.
        {
            if (firstCard.Rank == secondCard.Rank && firstCard.Suit == secondCard.Suit) // If the user has flipped one card twice
            {
                return;
            }
            else
            {
                if (firstCard.Rank == secondCard.Rank) // Match 
                {
                    if (playerTurn == "playerOne")
                    {
                        myOnePlayer.Score++;
                    }
                    else if (playerTurn == "playerTwo")
                    {
                        myTwoPlayer.Score++;
                    }

                    if (state == "twoPlyGme")
                    {
                        p1MoveTracker();
                        p2MoveTracker();
                    }

                    firstCard.Rm = false;
                    secondCard.Rm = false;

                    myDeck.topCardReset();
                    myDeck.displayAllCards();

                    
                    count++;

                }
                else // Not a match
                {
                    if (state == "twoPlyGme")
                    {
                        p1MoveTracker();
                        p2MoveTracker();
                    }

                    firstCard.flip();
                    firstCard.display();

                    secondCard.flip();
                    secondCard.display();
                }
            }
        }

        public void p1MoveTracker()
        {
            if (myOnePlayer.Count != 0)
            {
                myOnePlayer.Count--;
                if (myOnePlayer.Count == 0)
                {
                    myTwoPlayer.Count = 6;
                    playerTurn = "playerTwo";
                }
            }
        }

        public void p2MoveTracker()
        {
            if (myOnePlayer.Count == 0)
            {
                myTwoPlayer.Count--;
                if (myTwoPlayer.Count == 0)
                {
                    myOnePlayer.Count = 5;
                    playerTurn = "playerOne";
                }
            }
        }
    }
}
