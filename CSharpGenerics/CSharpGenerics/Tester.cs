﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    // An example program to under the concept of Generics
    //public class MyGenericArray<T>
    //{
    //    private T[] array;
    //    public MyGenericArray(int size)
    //    {
    //        array = new T[size + 1];
    //    }

    //    public T getItem(int index)
    //    {
    //        return array[index];
    //    }

    //    public void setItem(int index, T value)
    //    {
    //        array[index] = value;
    //    }
    //}

    //class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //        //// declaring an int array
    //MyGenericArray<int> intArray = new MyGenericArray<int>(5);
    //// setting values 
    //for(int c = 0; c < 5; c++)
    //{
    //    intArray.setItem(c, c * 5);
    //}
    //// retrieving the values
    //for(int c = 0; c < 5; c++)
    //{
    //    Console.Write(intArray.getItem(c) + " ");
    //}
    //Console.WriteLine();

    //// delcaring a character array
    //MyGenericArray<char> charArray = new MyGenericArray<char>(5);
    //// setting values
    //for(int c = 0; c < 5; c++)
    //{
    //    charArray.setItem(c, (char)(c + 97));
    //}
    //// retrieving the values
    //for(int c = 0; c < 5; c++)
    //{
    //    Console.Write(charArray.getItem(c) + " ");
    //}
    //Console.WriteLine();
    //Console.ReadKey();

    //}
    //}

    // A Example program to demo Generic method with type parameter
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            // display values before swap:
            Console.WriteLine("Int values before calling swap: ");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Character values before calling swap: ");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            // call swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine();
            Console.WriteLine();

            // display values after swap:
            Console.WriteLine("Int values after calling swap: ");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Character values after calling swap: ");
            Console.WriteLine("c = {0}, d = {1}", c, d);
        }
    }
}
