using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLog4NetRollbarDemo
{
    internal class Program
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {


            //Rollbar Log4Net Code Example

            //3 Nuget Packages are required
            //  Rollbar
            //  Rollbar.PlugIns.Log4net
            //  Rollbar.AppSettings.Json
            //appsettings.json is required as the settings will be reading from there



            //Write Line
            Console.WriteLine('A');
            Console.WriteLine('B');

            //3 Types of Issues to log
            log.Info("Error - Info from function ");
            log.Warn("Error - Warning from function");
            log.Fatal("Error - Fatal from function");


            Console.WriteLine("Working...");


            try
            {
                var int1 = 0;
                var int2 = 0;

                var int3 = int2 / int1;

                Console.WriteLine("Result: " + int3);
            }
            catch (Exception ex)
            {
                //Example to send a full exception object to Rollbar with the Fatal function
                log.Fatal(ex.Message,ex);
            }


            //Pause to Read Line
            Console.ReadLine();

        }
    }
}
