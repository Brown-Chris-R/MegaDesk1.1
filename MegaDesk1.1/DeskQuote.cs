using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1dot1
{
    class DeskQuote
    {
        // DeskQuote class variables
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public int QuoteAmount { get; set; }

        // working variables
        private decimal SurfaceArea = 0;
        private int rushPriceIndex;

        // Constants
        public const decimal BASE_DESK_PRICE = 200;
        public const decimal PRICE_PER_SURF_AREA = 1;
        public const decimal PRICE_PER_DRAWER = 50;
        public const int BASE_DESKTOP_AREA = 1000;
        public const int DESKTOP_AREA_THRESHOLD = 2000;
        public static decimal[,] RushDayPrices = { { 60, 40, 30 }, {70,50,35}, {80,60,40} };

        public DeskQuote(string customerName, DateTime quoteDate, decimal width, decimal depth, int drawers, DesktopMaterial material, int rushDays)
        {
            // set class variables
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            // Calculate desktop surface area
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public decimal CalculateQuotePrice()
        {
            return BASE_DESK_PRICE + CalculateSurfaceAreaCost() + CalculateDrawerPrice() + (decimal)Desk.DesktopMaterial + CalculateRushAdder();
        }

        public decimal CalculateSurfaceAreaCost()
        {
            if (SurfaceArea > BASE_DESKTOP_AREA)
            {
                return (SurfaceArea - BASE_DESKTOP_AREA) * PRICE_PER_SURF_AREA;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateRushAdder()
        {
            if (SurfaceArea <= BASE_DESKTOP_AREA)
            {
                rushPriceIndex = 0;
            }
            else if (SurfaceArea <= DESKTOP_AREA_THRESHOLD)
            {
                rushPriceIndex = 1;
            }
            else
            {
                rushPriceIndex = 2;
            }

            switch (RushDays)                {
                    case 3:
                        return RushDayPrices[rushPriceIndex,0];
                    case 5:
                        return RushDayPrices[rushPriceIndex, 1];
                    case 7:
                        return RushDayPrices[rushPriceIndex, 2];
                    default:
                        return 0;
                }

        }

        public decimal CalculateDrawerPrice()
        {
            return Desk.NumberOfDrawers * PRICE_PER_DRAWER;
        }
    }
}
