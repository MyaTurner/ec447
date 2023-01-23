using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    internal class GameEngine
    {
        public bool computerTurn = false;
        public bool computerWon = false;
        public bool gameOver = false;
        public bool playerWon = false;
        public bool draw = false;
        private bool win = false;

        //dimensions
        private const float lineLength = 80;
        private const float block = lineLength / 3;

        public enum CellSelection { N, O, X };
        public CellSelection[,] grid = new
        CellSelection[3, 3];
        private string errorMessage = "Bad move!";
        private string playerWinsMessage = "You win! Press New in the menu to play again.";
        private string drawMessage = "There is a draw! Press New in the menu to play again.";
        private string playerLosesMessage = "You lose! Press New in the menu to play again.";


        private int[] getRandomCoordinate()
        {
            int[] coordinates = new int[2];
            Random random = new Random();
            coordinates[0] = random.Next(0, 3);
            coordinates[1] = random.Next(0, 3);
            return coordinates;
        }
      
        // Computer moves, computer plays with Os
        public void computerMove()
        {
            GameEngine.CellSelection[,] copy = grid.Clone() as GameEngine.CellSelection[,];

            // Block a winning move
            for (int i= 0; i< 3; i++)
            {
                for (int j= 0; j< 3; j++)
                {

                    copy[i,j] = GameEngine.CellSelection.X;
                    if (getWinner(GameEngine.CellSelection.X))
                    {
                        grid[i, j] = CellSelection.O;
                        return;

                    }

                }
            }

            // Make a winning move
            for (int i= 0; i< 3; i++)
            {
                for (int j= 0; j< 3; j++)
                {
                    copy[i, j] = GameEngine.CellSelection.O;
                    if (getWinner(GameEngine.CellSelection.O))
                    {
                        grid[i, j] = CellSelection.O;
                        return;

                    }
                }
            }
            // Get random coordinate 
            int[] coordinates = getRandomCoordinate();
            int x= coordinates[0];
            int y= coordinates[1];

            // Make a move
            while (grid[x,y]!= GameEngine.CellSelection.N)
            {
                coordinates = getRandomCoordinate();
                x= coordinates[0];
                y= coordinates[1];
            }


            grid[x, y] = GameEngine.CellSelection.O;
            computerTurn = false;
            // Check if game ended.
            endGame();

        }

        
        private bool isBoardFilled()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (grid[i, j] == GameEngine.CellSelection.N)
                    {
                        return false;
                    }
            return true;
    }
        private bool getWinner(GameEngine.CellSelection player)
        {
            // Using containers to keep track of wins
            int[] rowTracker = new int[3];
            int[] colTracker = new int[3];
            int[] diagonalTracker = new int[3];
            int[] oppDiagonalTracker = new int[3];

            for(int i = 0; i < 3; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    if(grid[i, j] == player)
                    {
                        rowTracker[i] += 1;
                        colTracker[j] += 1;

                        if(i == j)
                        {
                            diagonalTracker[i] += 1;
                        }

                        if(i + j + 1 == 3)
                        {
                            oppDiagonalTracker[i] += 1;
                        }

                        // Check for wins across columns
                        if (colTracker[j] == 3)
                        {
                            return true;
                        }
                    }

                    // Check for wins across rows
                    if (rowTracker[i] == 3)
                    {
                        return true;
                    }

                }
            }

            int sumDiagonalElements = 0;
            int sumOppDiagonalElements = 0;

            for(int i = 0; i < 3; ++i)
            {
                sumDiagonalElements+= diagonalTracker[i];
                sumOppDiagonalElements+= oppDiagonalTracker[i];

            }

            if(sumDiagonalElements == 3)
            {
                return true;
            }

            if(sumOppDiagonalElements == 3)
            {
                return true;
            }

            return false;
        }


        // Check to see if game has ended
        private void endGame()
        {
           
            // Check if player won
            if (getWinner(GameEngine.CellSelection.X))
            {
                MessageBox.Show(playerWinsMessage);
                this.gameOver = true;
            }// Check if computer won
            else if (getWinner(GameEngine.CellSelection.O))
            {
                MessageBox.Show(playerLosesMessage);
                this.gameOver = true;
            }
            else if (isBoardFilled())
            {
                MessageBox.Show(drawMessage);
                this.gameOver = true;
            }

        }

        public void playerMove(MouseEventArgs e, PointF[] p)
        {
            if (!gameOver && !computerTurn)
            {
                if (p[0].X < 0 || p[0].Y < 0) return;
                int i = (int)(p[0].X / block);
                int j = (int)(p[0].Y / block);
                if (i > 2 || j > 2) return;
                if (e.Button == MouseButtons.Middle)
                    grid[i, j] = GameEngine.CellSelection.N;

                //only allow setting empty cells
                if (grid[i, j] == GameEngine.CellSelection.N)
                {

                    if (e.Button == MouseButtons.Left)
                    {
                        grid[i, j] = GameEngine.CellSelection.X;
                        // Check to see if the game has ended
                        endGame();

                        // Let the computer go next by setting a varible
                        computerTurn = true;
                        computerMove();


                    }
                       
                }
                // Player made a bad move
                else
                {
                    MessageBox.Show(errorMessage);
                }
              
            }
        }


    }
}
