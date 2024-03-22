using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6Set
{
    internal class Menu
    {
        Set mySet = new Set();

        public void run()
        {
            int s;
            do
            {
                s = UserSelection();
                switch (s)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Remove();
                        break;
                    case 3:
                        IsContains();
                        break;
                    case 4:
                        IsEmptyy();
                        break;
                    case 5:
                        ReturnRandom();
                        break;
                    case 6:
                        EvenCnt();
                        break;
                    case 7:
                        Print();
                        break;
                    default:
                        Console.WriteLine("You have exitted :(");
                        break;

                }
            } while (s != 0);

        }
        private static int UserSelection()
        {
            int s;
            do
            {
                Console.WriteLine("-----Please choose:----");
                Console.WriteLine("-----------------------");
                Console.WriteLine("0- Exit");
                Console.WriteLine("1- Insert");
                Console.WriteLine("2- Remove");
                Console.WriteLine("3- IsContains");
                Console.WriteLine("4- IsEmpty");
                Console.WriteLine("5- Return random");
                Console.WriteLine("6- Count of evens");
                Console.WriteLine("7- Print the Set");
                Console.WriteLine("-----------------------");



                try
                {
                    s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You chose " + s + ". ");
                }
                catch (System.FormatException)
                {
                    s = -1;
                }
            } while (s < 0 || s > 7);
            return s;
        }

        private int Read()
        {
            int elem;
            bool ok;
            do
            {
                Console.WriteLine("Give the element: ");
                try
                {
                    elem = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Only integer typed elements are allowed! ");
                    ok = false;
                    elem = -1; 
                }
            } while (!ok);
            return elem;
        }

        private void Insert()
        {
            bool ok = false;
           
            do
            {
                int elem=Read();
                try
                {
                    if (mySet.ContainsElem(elem) == false)
                    {
                        mySet.InsertElem(elem);
                        ok = true;
                    }
                }
                catch
                {
                    if (mySet.ContainsElem(elem) == true)
                    {

                        ok = false;
                    }
                }
            } while (!ok);

        }
        private void Remove()
        {
            if (mySet.IsEmpty() == true)
            {
                Console.WriteLine("The set is empty");
            }
            else
            {
                bool ok = false;
                
                do
                {
                    int elem = Read();
                    try
                    {
                        if (mySet.ContainsElem(elem) == true)
                        {
                            mySet.RemoveElem(elem);
                            ok = true;
                        }
                    }
                    catch
                    {
                        if (mySet.ContainsElem(elem) == false)
                        {

                            ok = false;
                        }
                    }
                } while (!ok);
            }

        }
        public void IsContains()
        {
            if (mySet.IsEmpty() == true)
            {
                Console.WriteLine("The set is empty");

            }
            else
            {
                int elem = Read();
                if (mySet.ContainsElem(elem) == true)
                    Console.WriteLine(elem + " contains in the set");
                else
                    Console.WriteLine(elem + " does not contain in the set.");

            }
        }
        public void IsEmptyy()
        {
            if (mySet.IsEmpty() == true)
                Console.WriteLine("The set is empty");
            else
                Console.WriteLine("The set is not empty");

        }
        public void ReturnRandom()
        {
            if (mySet.IsEmpty() == true)
            {
                Console.WriteLine("The set is empty");
            }
            else
                Console.WriteLine(mySet.RandomElem());
        }
        public void EvenCnt()
        {
            if (mySet.IsEmpty() == true)
            {
                Console.WriteLine("The set is empty");
            }
            else
                Console.WriteLine(mySet.NumEven());
        }
        public void Print()
        {
            if (mySet.IsEmpty() == true)
            {
                Console.WriteLine("The set is empty");
            }
            else 
                mySet.PrintElems();
        }

    }
}
