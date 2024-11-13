using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User(19, " ");
                Console.WriteLine(user);
            }
            catch(AgeCustomExcep a)
            {
                Console.WriteLine(a.Message);
            }
            //try
            //{
            //    User user = new User(19, " ");
            //}
            catch (NameCustomExcep c)
            {
                Console.WriteLine(c.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
