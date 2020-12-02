using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        /*What fields do ALL FOUR of the classes have in common? Id, nextId, Value
          Which constructors are the same in ALL FOUR classes? the body of the ones that set the value and id
          Which custom methods are identical in ALL of the classes? Equals(), GetHashCode(), ToString()*/

        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}
