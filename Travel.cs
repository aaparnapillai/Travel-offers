using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectConsoleApp
{
    class Travel
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the country or continent:");
                string searchOffers = Console.ReadLine();
            string[] tsvLines = System.IO.File.ReadAllLines(@"F:\Travel Agency Offers.tsv");
            
            for(int i=0; i<tsvLines.Length;i++)
            {
                string[] rowData = tsvLines[i].Split('\t');

                

                for (int j = 0; j < rowData.Length; j++)
                { 
                            if (("Continent="+rowData[0]).Equals(searchOffers,StringComparison.InvariantCultureIgnoreCase)|| ("Country="+rowData[1]).Equals(searchOffers,StringComparison.InvariantCultureIgnoreCase))
                            {

                              Console.WriteLine(rowData[j]);
                              
                            }
                    
                }
                


            }
            
            
            Console.Read();
        }
    }
}
