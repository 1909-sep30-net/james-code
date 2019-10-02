using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make bool, string, and int variables (with values)

            bool bVar = true;
            string sVar = "string";
            int iVar = 10;

            // change their values to something else

            bVar = false;
            sVar = "something else";
            iVar = 9;

            // print their values with Console

            Console.WriteLine(bVar);
            Console.WriteLine(sVar);
            Console.WriteLine(iVar);

            // do something in a for loop

            for (int i = 0; i < 5; i++)
            {
                iVar++;
            }
            // do something in a while loop

            while (iVar < 55)
            {
                iVar++;
            }

            // do something with a switch statement

            switch (bVar)
            {
                case true:
                    Console.WriteLine("bVar is true");
                    break;

                case false:
                    Console.WriteLine("bVar is false");
                    break;
            }

            
            // do something with if, else if, else

            if (iVar > 56)
                Console.WriteLine("Hmmm");

            else if (sVar != "something else")
                Console.WriteLine("Nope");

            else
                Console.WriteLine("yep");

            // figure out how to make multi-line comments in C#

            /* multi
                line
                 comments */


            // figure out how to format your document in VS Code

            // shift+alt+f 


            // extra: make a new static method to do something and call it

            static void printVar(int someVar)
            {
                Console.WriteLine("iVar = " + someVar);
            }

            printVar(iVar);

            // extra: learn what "var" means in C# and try it out.

            var someThang = "this or that";

            Console.WriteLine("someThang is a string and equals --> " + someThang);
        }
    }
}
