using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperatorOverloadTask.Models
{
    abstract class Person
    {
        public abstract int Id { get; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract int Age { get; set; }
        public abstract string ShowInfo();
    }
}
