using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(string.Format("{0:HH:mm:ss tt}", DateTime.Now));
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Debug.Assert(true);
            int i = 20;
            int j = 20;
            i = i / 40 * 2;
            j = (int)((j / 40) + 3);
            Console.WriteLine(i);
            Console.WriteLine(j);

            string userDate = Console.ReadLine();
            DateTime newDate = DateTime.Parse(userDate);
            Console.WriteLine(newDate.ToString("MM/dd/yyyy"));
            string strTwo = "This";
            Console.WriteLine("{0} {1}", userDate, strTwo);
            Console.ReadLine();
        }
    }
}
