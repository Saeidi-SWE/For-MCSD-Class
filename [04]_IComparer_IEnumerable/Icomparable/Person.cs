using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }

        public override string ToString()
        {
            return $"{Name} {Family}, {NationalCode}";
        }

        public int CompareTo(object obj)
        {
            Person p0 = (Person)obj;
            return string.Compare(this.Family, p0.Family);
        }
    }

    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = (Person)x;
            Person p2 = (Person)y;

            return string.Compare(p1.Family, p2.Family);

        }
    }
}
