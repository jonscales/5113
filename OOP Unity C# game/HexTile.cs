using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace HexGame_3._0
{
    public class HexTile
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public int GridX { get; set; }
        public int GridY { get; set; }
        public int value { get; set; } = 0;
        public string name => $"{GridX},{GridY}";
        
        public bool selectable { get; set; } = true;
        public Color tileColor { get; set; } = Color.Teal;

        public Label DisplayLabel { get; set; } // For showing text in the UI

        public HexTile(int gridX, int ridY)
        {
            
            GridX = gridX;
            GridY = ridY;  
            
            DisplayLabel = new Label
            {
                Text = $"{GridX},{GridY}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 30, // adjust size for hex display
                Height = 30,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
        }
    }
}
