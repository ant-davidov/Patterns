﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CompositeBuilder.Builders
{
    internal class PersonBuilder
    {
        protected Person person;

        public PersonBuilder() 
        {
            person = new Person();
        }

        protected PersonBuilder(Person person) => this.person = person;

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
