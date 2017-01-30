using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //          StringReverse reverseString = new StringReverse();
            //          string reversed = reverseString.ReverseString("hello");
            //          Console.WriteLine(reversed);

            Bottle myBottle = new Bottle();

            // Test 1
            myBottle.Fill();
            Console.WriteLine(myBottle.PercentRemaining);

            // Test 2
            try
            {
                myBottle.Fill(12);
            } 
            catch(BottleOverflowException ex)
            {
                Console.WriteLine("Something very very horrible has happened: " + ex.Message);
            }

            // Test 3
            myBottle.Consume(1);
            myBottle.Fill(1);
            Console.WriteLine(myBottle.PercentRemaining);

            // Test 4
            myBottle.Consume(1);
            try { myBottle.Fill(2); } catch(BottleOverflowException bex) { Console.WriteLine("Something happened, Man: " + bex.Message); }
            Console.WriteLine(myBottle.PercentRemaining);


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

public class Bottle
{
    // Member Fields - stores data
    private const int MaxCapacity = 20; // ounces
    private int CurrentOunces;

    // Constructors -- allow users to provide the initial configuration
    public Bottle()
    {
        CurrentOunces = 0;
    }

    public Bottle(int ounces)
    {
        CurrentOunces = ounces;
    }

    // Properties
    public int PercentRemaining
    {
        get
        {
            if (CurrentOunces == 0)
            {
                return 0;
            }
            else
            {
                var result = (Double)CurrentOunces / (Double)MaxCapacity;
                return (int)((result) * 100);
            }
        }
    }

    // Member Functions - performs actions on data
    public void Fill()
    {
        CurrentOunces = MaxCapacity; 
    }

    public void Fill(int ounces)
    {
        if ((CurrentOunces + ounces) > MaxCapacity)
        {
            throw new BottleOverflowException("The bottle cannot handle the added capacity. The bottle has " + (MaxCapacity - CurrentOunces) + " left.");
        }

        CurrentOunces += ounces;
    }

    public void Consume(int ounces)
    {
        CurrentOunces = CurrentOunces - ounces;
    }
    
    public void Empty()
    {
        CurrentOunces = 0;
    }
}

class BottleOverflowException : Exception {
    public BottleOverflowException(string message) : base(message)
    {
    }
}
