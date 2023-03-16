using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class SeasonController
    {
        public static void section4()
        {
            var season = Season.Fall;

            switch (season)
            {
                case Season.Fall:
                    Console.WriteLine("It's fall. Time for football.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer. Time for baseball.");
                    break;
                default: 
                    Console.WriteLine("I don't know that season.");
                    break;
            }

            // The following is read as: If case is Fall or Summer. 
            switch (season)
            {
                case Season.Fall:
                case Season.Summer:
                    Console.WriteLine("This is a block for Fall or Summer.");
                    break;
                default:
                    Console.WriteLine("I don't know that season.");
                    break;

            }
        }
    }
}
