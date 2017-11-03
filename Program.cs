using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamAuth;
using System.IO.Ports;

namespace SteamAuthConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SteamGuardAccount account = new SteamGuardAccount();
            account.SharedSecret = args[0];
            string loginCode = account.GenerateSteamGuardCode();
            Console.Write(loginCode);
        }
    }
}
