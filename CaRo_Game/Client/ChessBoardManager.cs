using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ChessBoardManager
    {
        #region Properties 
        private Panel chessBoard;

        public Panel ChessBoard { get => chessBoard; set => chessBoard=value; }

        private List<Player> player;

        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer=value; }
        

        private TextBox playerName;

        public TextBox PlayerName { get => playerName; set => playerName=value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark=value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix=value; }

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;
        public Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine=value; }

        #endregion


        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.chessBoard = chessBoard;
            this.playerName = playerName;
            this.playerMark = mark;
            this.player = new List<Player>() 
            { 
                new Player("player 1", Image.FromFile(Application.StartupPath + "\\Sources\\O_image.jpg")),
                new Player("player 2", Image.FromFile(Application.StartupPath + "\\Sources\\X_image.png"))
            };

        }
        #endregion

        #region Method
        public void DrawChessBoard()
        {

            chessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            PlayTimeLine = new Stack<PlayInfo>();
            currentPlayer = 0;

            changePlayer();

            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i<Cons.Chess_Board_Height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.Chess_Board_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Width,
                        Height = Cons.Chess_Height,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString(),
                    };

                    btn.Click += btn_Click;

                    chessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldBtn = btn;


                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.Chess_Height);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;
            Mark(btn);

            playTimeLine.Push(new PlayInfo(getChessPoint(btn), CurrentPlayer));

            currentPlayer = currentPlayer == 1 ? 0 : 1;

            changePlayer();

            if (playerMarked != null)
            {
                playerMarked(this, new EventArgs());
            }

            if(isEndGame(btn))
            {
                endGame();
            }

            
        }

        public void endGame()
        {
            if(endedGame != null)
            {
                endedGame(this, new EventArgs());
            }
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndForwarDiagonal(btn) || isEndReverseDiagonal(btn);
        }

        public bool Undo()
        {
            if (playTimeLine.Count <= 0 )
            {
                return false;
            }
            PlayInfo oldPoint = playTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;

            

            if(playTimeLine.Count <= 0)
            {
                currentPlayer = 0;
            } else
            {
                oldPoint = playTimeLine.Peek();
                currentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }

            changePlayer();
            return true;
        }

        private Point getChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = getChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X+1; i < Cons.Chess_Board_Width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }


            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.Chess_Board_Height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }


            return countTop + countBottom == 5;
        }

        private bool isEndForwarDiagonal(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for(int i = 1; i <= Cons.Chess_Board_Width - point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_Board_Height || point.X + i >= Cons.Chess_Board_Width)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }


            return countTop + countBottom == 5;
        }

        private bool isEndReverseDiagonal(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X + i > Cons.Chess_Board_Width)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.Chess_Board_Width - point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_Board_Height || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }


            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = player[currentPlayer].Mark;
        }

        private void changePlayer()
        {
            PlayerName.Text = player[currentPlayer].Name;

            playerMark.Image = player[currentPlayer].Mark;
        }
        #endregion


    }
}
