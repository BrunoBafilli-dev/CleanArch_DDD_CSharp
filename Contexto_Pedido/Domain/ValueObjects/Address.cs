using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Validations;

namespace Domain.ValueObjects
{
    public class Address
    {
        //Props
        public string Number { get; private set; }
        public string Road { get; private set; }

        //Ctor
        public Address(string number, string road)
        {
            //Validations
            Validations(number, road);
            Number = number;
            Road = road;
        }
        //Methods
        public void Validations(string number, string road)
        {
            DefaultValidationsException.IsNullOrEmpty(number, nameof(number));
            DefaultValidationsException.IsNullOrEmpty(road, nameof(road));
        }

    }
}
