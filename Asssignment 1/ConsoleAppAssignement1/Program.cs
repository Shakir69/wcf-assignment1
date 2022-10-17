using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var player_option = string.Empty;
            while (player_option != "6")
            {


                Console.WriteLine("PLEASE SELECT AN OPTION");

                Console.WriteLine("1 - PRIME NUMBER");
                
                Console.WriteLine("2 - SUM OF DIGITS");
                
                Console.WriteLine("3 - REVERSE A STRING");
                
                Console.WriteLine("4 - PRINT OUT AN HTML TAGS");
                
                Console.WriteLine("5 - SORT 5 NUMBERS ");
                
                
                Console.WriteLine("6 - EXIT");
                
                player_option = Console.ReadLine();

                switch (player_option)
                {
                    case "1":
                        Console.WriteLine("PLEASE ENTER A NUMBER TO DETERMINE WHETHER IT IS PRIME OR NOT");
                        var Pnum = player_option;
                        Pnum = Console.ReadLine();
                        string pn = client.GetPrime_Number(Int32.Parse(Pnum));
                        Console.WriteLine(pn);
                        break;

                    case "2":
                        Console.WriteLine("PLEASE ENTER A NUMBER");
                        var num = player_option;
                        num = Console.ReadLine();
                        string res = client.getSum_of_digits(Int32.Parse(num));
                        Console.WriteLine(res);
                        break;
                        

                    case "3":
                        Console.WriteLine("PLEASE ENTER A WORD");
                        var val = player_option;
                        val = Console.ReadLine();
                        string r = client.reverse_String(val);
                        Console.WriteLine(r);
                        break;

                    case "4":
                        string second_val;
                        Console.WriteLine("PLEASE ENTER AN HTML TAG");
                        var value = player_option;
                        value = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER A WORD OR PHRASE");
                        second_val = Console.ReadLine();
                        string html = client.html_tags(value , second_val);
                        Console.WriteLine(html);
                        break;

                    case "5":
                        string s_val;
                        string t_val;
                        string f_val;
                        string ff_val;
                        string ss_val;
                        Console.WriteLine("PLEASE ENTER WHETHER YOU WANT THE NUMBERS TO BE DESC OR ASC (CASE SENSITIVE ALL CAPS PLEASE!)");
                        var asc_desc = player_option;
                        asc_desc = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER A NUMBER");
                        s_val = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER ANOTHER NUMBER");
                        t_val = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER A THIRD NUMBER");
                        f_val = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER A FOURTH NUMBER");
                        ff_val = Console.ReadLine();
                        Console.WriteLine("PLEASE ENTER A FIFTH NUMBER");
                        ss_val = Console.ReadLine();
                        string sn = client.sort_Numbers(asc_desc, Int32.Parse(s_val), Int32.Parse(t_val), Int32.Parse(f_val), Int32.Parse(ff_val) , Int32.Parse(ss_val));
                        Console.WriteLine(sn);
                        break;
                }
            }
        }
    }
}
