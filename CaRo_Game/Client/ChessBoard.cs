using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChessBoard : Form
    {
        #region Properties
        ChessBoardManager Board;
        #endregion
        public ChessBoard()
        {
            InitializeComponent();

            Board = new ChessBoardManager(panel_Board);

            Board.DrawChessBoard();
        }

        
    }
}
