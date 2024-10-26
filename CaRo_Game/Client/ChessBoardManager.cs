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
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Method
        public void DrawChessBoard()
        {
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i<Cons.Chess_Board_Width; i++)
            {
                for (int j = 0; j < Cons.Chess_Board_Height; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Width,
                        Height = Cons.Chess_Height,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y)
                    };

                    chessBoard.Controls.Add(btn);

                    oldBtn = btn;


                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.Chess_Height);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }
        #endregion


    }
}
