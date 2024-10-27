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

            Board = new ChessBoardManager(panel_Board, FullName, Avatar_Player);
            Board.EndedGame += ChessBoard_EndedGame;
            Board.PlayerMarked += ChessBoard_PlayerMarked;

            PrcBCoolDown.Step = Cons.Cool_Down_Step;
            PrcBCoolDown.Maximum = Cons.Cool_Down_Time;
            PrcBCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.Cool_Down_Interval;

            newGame();

        }

        #region
        void endGame()
        {
            tmCoolDown.Stop();
            panel_Board.Enabled = false;
            MessageBox.Show("kết thúc!!!");
        }

        private void ChessBoard_PlayerMarked(object? sender, EventArgs e)
        {
            tmCoolDown.Start();
            PrcBCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            endGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            PrcBCoolDown.PerformStep();

            if (PrcBCoolDown.Value >= PrcBCoolDown.Maximum)
            {
                endGame();
            }
        }

        void newGame()
        {
            PrcBCoolDown.Value = 0;
            tmCoolDown.Stop();
            Board.DrawChessBoard();

        }

        void Chat()
        {

        }

        void Quit()
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chat();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void ChessBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;

        }

        #endregion
    }
}
