using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenRechner_1._0
{
    public class CalculatorHistory
    {
        private static string logFilePath = "taschenRechner_log.txt";

        public static void Log(string expression, double ergebnis)
        {
            try
            {
                
                string logEntry = $"{DateTime.Now:G}: {expression} = {ergebnis}\n";

                
                File.AppendAllText(logFilePath, logEntry);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Err!:" + ex.Message);
            }
        }

    }
}
