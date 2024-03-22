using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A6Set
{
    public class Set
    {
        //Represent the set as a sequence of its elements.
        private List<int> set;
        private int evenCnt;
        public Set()
        {
            set = new List<int>();
            evenCnt = 0;
        }
        //exceptions
        public class TheSetContains : Exception { };
        public class TheSetIsEmpty: Exception { };
        public class TheSetDoesNotContain: Exception { };

        //inserting an element
        public void InsertElem(int e)
        {
            if
                (set.Contains(e) == true) throw new TheSetContains();
            else
            {
                set.Add(e);
                if (e % 2 == 0) evenCnt++;
            }
                
            
        }
        //removing an element
        public void RemoveElem(int e)
        {
            if (set.Count == 0) throw new TheSetIsEmpty();
            else if (set.Contains(e)==false) throw new TheSetDoesNotContain();
            else set.Remove(e);
                if (e%2==0)
                {
                    evenCnt--;
                }
        }
        //returning whether the set is empty
        public bool IsEmpty()
        {
            return set.Count == 0;
        }
        // returning whether the set contains an element
        public bool ContainsElem(int e)
        {

            return set.Contains(e);
        }
        // returning a  random element without removing it from the set
        public int RandomElem()
        {

            if (set.Count == 0) throw new TheSetIsEmpty();

            Random rand = new Random();
            int randInd = rand.Next(set.Count - 1);
            return set.ElementAt(randInd);
        }
        //returning the number of even numbers in the set
        public int NumEven()
        {
            
            int cnt = 0;
            if (set.Count == 0) throw new TheSetIsEmpty();
            else
                return evenCnt;

        }
        //print the set
        public void PrintElems()
        {
            Console.Write("{ ");
            for (int i = 0; i < set.Count; i++)
            {
                Console.Write(set[i]);
                if (i < set.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
    }
}
