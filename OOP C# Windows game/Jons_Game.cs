using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexGame_3._0
{
    public partial class Jons_Game : Form
    {
        private const int ROWS = 6; // grid rows
        private const int COLS = 10; // grid columns
        private const int TILESIZE = 40; // tile radius to vertex iin pixels
        private List<HexTile> hexTiles = new List<HexTile>(); // list to store hextiles
        private HexTile nextTile;
        private bool isRedTurn = true; //use to switch players
        public int redScore = 0;
        public int blueScore = 0;
        public Label redScoreLabel;
        public Label blueScoreLabel;
        // offset lists to ID neighbors of clicked tiles
        // different offsets dependent on odd/even Y (row) values
        private static readonly (int, int)[] evenYoffsets = new (int, int)[]
        {
            (1,0), //right
            (-1,0), // left
            (0,1), //bottom right
            (-1,1), //bottom left
            (0,-1), //top right
            (-1,-1) //top left
        };

        private static readonly (int, int)[] oddYoffsets = new (int, int)[]
        {
            (1,0), //right
            (-1,0), // left
            (1,1), //bottom right
            (0,1), //bottom left
            (1,-1), //top right
            (0,-1) //top left
        };

        public Jons_Game() // constructor
        {
            InitializeComponent();
            InitializeNextTile();
        }
               
        private void Jons_Game_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Jons_Game_Load called"); // temp test method check
            InitializeGrid(); // initialize a new grid and game when form loaded
        }

        private void InitializeGrid()
        {
            // define offset values for positioning tiles in staggered grid
            int initXcoord = (int)(this.ClientSize.Width * .18); //start 1/4 width from left
            int initYcoord = (int)(this.ClientSize.Height * .1); // start 1/4 height down from top
            float xOffset = TILESIZE * 1.7f ;
            float yOffset = TILESIZE *1.5f;

            // loop through rows & columns to generate tiles
            for (int row = 0; row < ROWS; row++) 
            {
                for (int col = 0; col < COLS; col++)
                {
                    // calculate position of each tile with staggered columns for even rows
                    int xPos = initXcoord + (int)(col * xOffset);
                    int yPos = initYcoord + (int)(row * yOffset);
                    
                    //offset odd rows
                    if(row%2 != 0)
                    {
                        xPos += (int)(TILESIZE * .866f);
                    }

                    // create new tile instance
                    HexTile hexTile = new HexTile(col, row)
                    {
                        X = xPos,
                        Y = yPos,
                        tileColor = Color.Teal,
                        selectable = true,
                        value = 0,
              
                    };
                    // Set the position of the label to match tile location
                    //hexTile.DisplayLabel.Location = new Point(xPos, yPos);

                    // Add the label to the form controls
                    this.Controls.Add(hexTile.DisplayLabel);
                    hexTiles.Add(hexTile); // add new tiles to the hex tile list
                }
            }
        }

        private void InitializeNextTile()
        {
            if (nextTile != null && nextTile.DisplayLabel != null)
            {
                Controls.Remove(nextTile.DisplayLabel);
            }

            int nextTileX =this.ClientSize.Width/2;
            int nextTileY = (int)(this.ClientSize.Height * .65);
            nextTile = new HexTile(0, 0)
            {
                X = nextTileX,
                Y = nextTileY,
                tileColor = isRedTurn ? Color.Red : Color.Blue,
                value = new Random().Next(1, 21),
                selectable = false
            };

            // update nextTile display
            nextTile.DisplayLabel.Visible = false;
            nextTile.DisplayLabel.Location = new Point(nextTileX -TILESIZE/2, nextTileY-TILESIZE/2);
            //nextTile.DisplayLabel.Size = new Size(TILESIZE, TILESIZE);
            nextTile.DisplayLabel.Text = nextTile.value.ToString();
            //nextTile.DisplayLabel.BackColor = nextTile.tileColor;

            // font style
            nextTile.DisplayLabel.Font = new Font("Arial", 20);
            nextTile.DisplayLabel.ForeColor = Color.White;

            this.Controls.Add(nextTile.DisplayLabel);
        }
        //methods to display rules
        private void InstructionButton_Click(object sender, EventArgs e)
        {
            this.InstructionsText.Visible = true;
            this.InstructionButton.Visible = false;
            this.BackButton.Visible = true;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.InstructionsText.Visible = false;
            this.InstructionButton.Visible= true;
            this.BackButton.Visible= false;
        }
        private List<HexTile> GetNeighbors (HexTile tile)
        {            
            List<HexTile> neighbors = new List<HexTile>();
            if (tile.GridY % 2 == 0)
            {
                foreach (var (dx, dy) in evenYoffsets)
                {
                    int neighborX = tile.GridX + dx;
                    int neighborY = tile.GridY + dy;

                    // check if neighbor tile on grid
                    if (neighborX >= 0 && neighborX < COLS && neighborY >= 0 && neighborY < ROWS)
                    {
                        HexTile neighbor = hexTiles.FirstOrDefault(t => t.GridX == neighborX && t.GridY == neighborY);
                        if (neighbor != null)
                        {
                            neighbors.Add(neighbor);
                        }
                    }
                }
  
            }
            else
            {
                foreach (var (dx, dy) in oddYoffsets)
                {
                    int neighborX = tile.GridX + dx;
                    int neighborY = tile.GridY + dy;

                    // check if neighbor tile on grid
                    if (neighborX >= 0 && neighborX < COLS && neighborY >= 0 && neighborY < ROWS)
                    {
                        HexTile neighbor = hexTiles.FirstOrDefault(t => t.GridX == neighborX && t.GridY == neighborY);
                        if (neighbor != null)
                        {
                            neighbors.Add(neighbor);
                        }
                    }
                }
            }
                         
         
            return neighbors;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // draw the grid
            foreach (var tile in hexTiles)
            {
                //calculate center of hex based on X & Y
                int centerX = tile.X;
                int centerY = tile.Y;

                // draw hexagon at calculated position
                DrawHexagon(g, centerX, centerY, TILESIZE, tile.tileColor, tile.value); // pass in tile attributes
            }
            //draw the next tile below grid
            DrawHexagon(g, nextTile.X, nextTile.Y, TILESIZE, nextTile.tileColor, nextTile.value);
        }
                   
        private void DrawHexagon(Graphics g, int centerX, int centerY, int size, Color tileColor, int value)
        {
            // Calculate the six points of the hexagon
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i + Math.PI / 6;
                points[i] = new Point(
                    centerX + (int)(size * Math.Cos(angle)),
                    centerY + (int)(size * Math.Sin(angle))
                );
            }

            // Draw the hexagon using the calculated points
            g.FillPolygon(new SolidBrush(tileColor), points); // Fill hexagon with  color
            g.DrawPolygon(Pens.Black, points); // Draw the outline in black

            if (value >0)
            {
                using (Font font = new Font("Arial", 20))
                {
                    string valueText = value.ToString();
                    SizeF textSize = g.MeasureString(valueText, font);
                    // draw text centered in hexagon
                    g.DrawString(valueText, font, Brushes.White, centerX-textSize.Width /2, centerY-textSize.Height /2);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            // check if click was within a tile
            foreach (var tile in hexTiles)
            {
                if (tile.selectable && IsPointInHexagon(e.X, e.Y, tile.X, tile.Y, TILESIZE))
                { 
                    //handle mouse click
                    OnTIleCLick(tile);
                    break;
                }
            }
        }

        //check if click is within a tile
        private bool IsPointInHexagon(int mouseX, int mouseY, int hexCenterX, int hexCenterY, int size)
        {
            double dx = mouseX - hexCenterX;
            double dy = mouseY - hexCenterY;

            // use hexagon bounds to see if point is inside
            return (dx * dx + dy * dy) <= (size * size);
        }

        // handle tile click to change value and color
        private void OnTIleCLick(HexTile clickedTile)
        {
            if (!clickedTile.selectable) // ignore any non-selectable tile
            {
                return;
            }

            // set clicked tile to current player's color
            if (isRedTurn)
            {
                clickedTile.tileColor = Color.Red; // set to red
            }
            else
            {
                clickedTile.tileColor = Color.Blue; //set to blue
            }

            clickedTile.value = nextTile.value; // set clicked tile's value to be what was on next tile
            clickedTile.selectable = false; // switch tile to be non-selectable
            clickedTile.DisplayLabel.Text = clickedTile.value.ToString(); //update label text

            clickedTile.DisplayLabel.Visible = false; // this was to show tile's X,Y coords for debugging
            

            // apply game rules to neighbors
            List<HexTile> neighbors = GetNeighbors(clickedTile);

            //output for debugging  comment out later
            Console.WriteLine("Clicked Tile: " + clickedTile.name + " | Value: "+ clickedTile.value);

            Console.WriteLine("Neighbors of clicked tile: ");
            foreach (var neighbor in neighbors)
            {
                if (neighbor != null)
                {
                    Console.WriteLine($"Neighbor: {neighbor.name}, Value: {neighbor.value}, Color: {neighbor.tileColor}");
                }
            }
            //above for debugging comment out later
            //check neighbors' color and value if opposite color
            foreach (var neighbor in neighbors.Where(n => !n.selectable))
            {
                if (neighbor.tileColor == clickedTile.tileColor)
                {
                    //same color so increment value
                    neighbor.value += 1;
                }
                else
                {
                    // different color so check values
                    if (clickedTile.value > neighbor.value)
                    {
                        neighbor.tileColor = clickedTile.tileColor;
                    }
                }
            }

            //call method to calculate score & update it
            ScoreUpdate();
            
            // see if game ended - are all tiles non-selectable
            bool gameOver = hexTiles.All(t=>!t.selectable); //look at hexTiles list and see if all are !selectable

            if (gameOver)
            {
                if (redScore > blueScore)
                {
                    WinnerLabel.Text = "Red Wins!";
                    WinnerLabel.ForeColor = Color.Red;
                }
                else if (blueScore > redScore)
                {
                    WinnerLabel.Text = "Blue Wins";
                    WinnerLabel.ForeColor = Color.Blue;
                }
                else
                {
                    WinnerLabel.Text = "It's a Tie";
                    WinnerLabel.ForeColor = Color.Purple;
                }
                WinnerLabel.Visible = true;
            }

            // alternate turns
            isRedTurn = !isRedTurn;

            // trigger redraw of tiles
            this.Invalidate();
            
            InitializeNextTile();

        }
        public void ScoreUpdate()
        {
            // Make sure the labels are initialized before accessing them
            if (RedScoreLabel == null || BlueScoreLabel == null)
            {
                Console.WriteLine("Labels are not initialized yet.");
                return;
            }

            //reset scores b/c some will have lost some gained, so cant just +=
            redScore = 0;
            blueScore = 0;

            foreach (var hexTile in hexTiles)
            {
                if (!hexTile.selectable)
                {
                    if(hexTile.tileColor == Color.Red)
                    {
                        redScore += hexTile.value;
                    }
                    else
                    {
                        blueScore += hexTile.value;
                    }
                }
            }
            // Update the labels with the new scores
            //redScoreLabel.Text = $"Red: {redScore}";
            //blueScoreLabel.Text = $"Blue: {blueScore}";
            if (RedScoreLabel != null)
            {
                RedScoreLabel.Text = $"Red: {redScore}";
            }
            else
            {
                Console.WriteLine("RedScoreLabel is null");
            }

            if (BlueScoreLabel != null)
            {
                BlueScoreLabel.Text = $"Blue: {blueScore}";
            }
            else
            {
                Console.WriteLine("BlueScoreLabel is null");
            }

        }

        //private void RedScoreLabel_Click(object sender, EventArgs e)
        //{

        //}
    }


    
}


