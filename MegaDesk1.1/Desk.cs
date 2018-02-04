using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1dot1
{
    class Desk
    {
        // Desk Class Variables
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }

        // Constants
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int DEPTH_MIN = 12;
        public const int DEPTH_MAX = 48;
        public const int DRAWERS_MIN = 0;
        public const int DRAWERS_MAX = 7;

    }
    public enum DesktopMaterial
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125
    };
}
