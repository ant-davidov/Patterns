﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CompositeBuilder
{
    public class Person
    {
        public Person()
        {
        
        }

     
        public string StreetAddress, Postcode, City;

     
        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}," +
                   $" {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}," +
                   $" {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

}
