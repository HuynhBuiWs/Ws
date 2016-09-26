using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs1
{
    class List<T>
    {
        Class1<T> head;

        internal Class1<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List() { }
        public void addfirst(Class1<T> e) { e.Next = head; this.head = e; }
    }
}
