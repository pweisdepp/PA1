using System;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptWord ew = new EncryptWord("Salad", 6);
            
            Console.WriteLine(ew.getEncryptedWord());
            Console.ReadKey();
        }
    }
}
