using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayingCard
{
    public partial class  HighScores : Form
    {

        HighScore[] scoreArray = new HighScore[10];

        private string name;
        private int hour, min, sec;
        private string state;

        public string plyName
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



        private string path = "highScores.txt";

        public HighScores(string aState)
        {
            InitializeComponent();
            readFromFile();

            this.state = aState;
        }

        public HighScores() : this("") { }

        private void HighScores_Load(object sender, EventArgs e)
        {
            if (state == "endGame")
            {
                HighScore nhs = new HighScore(this.name, this.hour, this.min, this.sec);
                playerAdd(nhs);
                writeToFile();
                update();
                returnHS.Enabled = false;
            }
            else
            {
                ng.Enabled = false;
                update();
            }
        }

        private void ng_Click(object sender, EventArgs e)
        {
            StartWindow sw = new StartWindow();
            this.Hide();
            sw.ShowDialog();
            this.Close();
        }

        private void returnHS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class HighScore
        {
            private string name;
            private int hour, min, sec;

            public HighScore(string aName, int aHour, int aMin, int aSec)
            {
                this.name = aName;
                this.hour = aHour;
                this.min = aMin;
                this.sec = aSec;
            }

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
                    return hour + " : " + min + " : " + sec.ToString();
                }
            }
        }

        public void playerAdd(HighScore aHighscore)
        {
            playerSort();

            bool added = false;

            for (int i = 0; i < scoreArray.Length; i++)
            {
                if (scoreArray[i] == null)
                {
                    scoreArray[i] = aHighscore;
                    added = true;
                    i = 10;
                }
            }
            if (added != true)
            {
                if (aHighscore.Hour < scoreArray[9].Hour)
                {
                    scoreArray[9] = aHighscore;
                    playerSort();
                }
                else if (aHighscore.Hour == scoreArray[9].Hour)
                {
                    if (aHighscore.Min < scoreArray[9].Min)
                    {
                        scoreArray[9] = aHighscore;
                        playerSort();
                    }
                    else if (aHighscore.Min == scoreArray[9].Min)
                    {
                        if (aHighscore.Sec < scoreArray[9].Sec)
                        {
                            scoreArray[9] = aHighscore;
                            playerSort();
                        }
                    }
                }
            }
        }

        public void playerSort()
        {
            bool state = true;

            while (state)
            {
                int condition = 0;
                for (int i = 0; i < scoreArray.Length - 1; i++)
                {
                    if (scoreArray[i] != null)
                    {
                        if (scoreArray[i + 1] != null)
                        {
                            if (scoreArray[i].Hour > scoreArray[i + 1].Hour)
                            {
                                condition = sortEngine(i);
                            }
                            else if (scoreArray[i].Min > scoreArray[i + 1].Min)
                            {
                                condition = sortEngine(i);
                            }
                            else if (scoreArray[i].Sec > scoreArray[i + 1].Sec)
                            {
                                condition = sortEngine(i);
                            }
                        }
                    }
                }
                if (condition == 0)
                {
                    state = false;
                }
            }
        }
        
        public int sortEngine(int i)
        {
            HighScore tmpPlayer = scoreArray[i];
            scoreArray[i] = scoreArray[i + 1];
            scoreArray[i + 1] = tmpPlayer;
            return 1;
        }

        public void writeToFile()
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < scoreArray.Length; i++)
            {
                if (scoreArray[i] != null)
                {
                    sw.WriteLine(scoreArray[i].Name);
                    sw.WriteLine(scoreArray[i].Hour);
                    sw.WriteLine(scoreArray[i].Min);
                    sw.WriteLine(scoreArray[i].Sec);
                }
                else
                {
                    i = 10;
                }
            }
            sw.Close();
        }

        public void readFromFile()
        {
            string[] lines = File.ReadAllLines(path);
            int n = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                scoreArray[n++] = new HighScore(lines[i++], Int32.Parse(lines[i++]), Int32.Parse(lines[i++]), Int32.Parse(lines[i]));
            }
        }

        public void update()
        {
            int i = 0;
            if (scoreArray[i++] != null)
            {
                highScore1.Text = scoreArray[0].Name + " - " + scoreArray[0].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore2.Text = scoreArray[1].Name + " - " + scoreArray[1].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore3.Text = scoreArray[2].Name + " - " + scoreArray[2].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore4.Text = scoreArray[3].Name + " - " + scoreArray[3].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore5.Text = scoreArray[4].Name + " - " + scoreArray[4].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore6.Text = scoreArray[5].Name + " - " + scoreArray[5].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore7.Text = scoreArray[6].Name + " - " + scoreArray[6].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore8.Text = scoreArray[7].Name + " - " + scoreArray[7].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore9.Text = scoreArray[8].Name + " - " + scoreArray[8].Timer;
            }
            if (scoreArray[i++] != null)
            {
                highScore10.Text = scoreArray[9].Name + " - " + scoreArray[9].Timer;
            }
        }
    }
}
