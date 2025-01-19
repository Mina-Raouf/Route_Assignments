using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T,R> where T : IComparable<T> where R : class
    {
        // T Must be Class or Struct Implementing the built-in Interface "IComparable"

        /// Primary Constraint [0: 1]
        //1. General Primary Constarint
        //class  => T Must Be Class
        //struct => T Must Be Struct
        //notnull => T Must be Not Nullable(C# 8.0)
        //default =>
        //unmanaged =>
        //Enum => T Must Be Enum (C# 7.3)
        //2. Spacial Primary Constarint (User-Defined Class (Except Sealed))
        //Point => T Must Be Point Or Another Class Inherits From Point

        /// Secondary Constraint (Interface Constraint) [\Theta: M]
        /// IComparable<T>
        /// T Must Be Class/Struct Implementing IComparable
         
        /// /// Parameterless Constructor Constraint [0:1]  
        /// T Must be Datatype Having Accessable[Non-Private] Parameterless Constructor  
        /// Till C# 12.0 Only One Constructor Constraint  
        /// Can't Use new() [Constructor Constraint] With struct [Special Primary Constraint]
        public static void SWAP<T>(ref T X, ref T Y) //where T : class
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        public static int LinearSearch<T>(T[] arr, T val)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(val))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int LinarSearch(T[] Arr, T Value, Func<T, T, bool> equals)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    //if (Value.Equals(Arr[i]))
                    // if (equalityComparer.Equals(Value, Arr[i]))
                    if (equals(Value, Arr[i]))
                        return i;
                }
            }
            return -1;
        }

        public static void BubbleSort(T[] arr)
        {
            if (arr is null | arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                        SWAP(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        public static void BubbleSort(T[] arr, IComparer<T> compare)// Interface refer to any object that implement it
        {
            if (arr is null | arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare.Compare(arr[j], arr[j + 1]) == 1)
                        SWAP(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        public static void BubbleSort(T[] arr, Func<T,T,bool> compare)// Interface refer to any object that implement it
        {
            if (arr is null | arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                        SWAP(ref arr[j], ref arr[j + 1]);
                }
            }
        }


    }
}
