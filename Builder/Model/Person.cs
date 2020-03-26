using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Model
{
    abstract class Person
    {
        public string Name { get; }
        public DateTime DoB { get; }
    }
}
