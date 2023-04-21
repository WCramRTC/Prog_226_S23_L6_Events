using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_S23_L6_Events
{
    public class BaseballPlayer
    {

        string _firstName;
        string _lastName;
        double _average;

        public BaseballPlayer(string firstName, string lastName, double average)
        {
            _firstName = firstName;
            _lastName = lastName;
            _average = average;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double Average { get => _average;

            set
            {
                if (value < 0)
                {
                    _average = 0;
                }
                else
                {
                    _average = value;
                }

            }
        }
    }
}
