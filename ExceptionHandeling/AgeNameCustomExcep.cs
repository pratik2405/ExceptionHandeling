using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    public class AgeCustomExcep:Exception
    {
        public AgeCustomExcep(string msg):base(msg)
        { 
        }
    }

    public class NameCustomExcep : Exception
    {
        public NameCustomExcep(string msg) : base(msg)
        {
        }
    }

    public class User
    {
        private string name;
        private int age;

        public User(int age, string name)
        {
            if (age >= 18)
            {
                this.age = age;
            }
            else
            {
                throw new AgeCustomExcep(age + " age is not allowed");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new NameCustomExcep("Null not accepted !");
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                throw new NameCustomExcep("Name Empty is allowed !");
            }
            else
            {
                this.name = name;
            }
        }

        public override string ToString()
        {
            return $"Age= {age} , Name={name}";
        }
    }
}
