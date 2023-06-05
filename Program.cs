namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //FOR LOOP

            /*for (int a = 0; a <= 4; a++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
            for(int a = 0; a<=3; a++)
            {
                Console.WriteLine("*   *");
            }
            for (int a = 0; a <= 4; a++)
            {
                Console.Write("*");

            }*/

            /*
                        //WHILE LOOP
                        int a = 1;
                        while (a < 5)
                        {
                            Console.WriteLine(a);
                            a++;
                        }
            */

            /*
                        //DO WHILE LOOP
                        int b = 0;
                        do
                        {
                            Console.WriteLine(b);
                        } while (b <= 5);
            */

            /*
            int a = 1;
            a += 2;
            Console.WriteLine(a += 3); //first will increment and then will print
            Console.WriteLine(a =+ 3); //first will print and then will increment value
            */


            //below programm is how to find old number for start and end number
            /*Console.WriteLine("please enter start number");
            string startNumber = Console.ReadLine();
            int integerStartNumber = (int)Convert.ToInt64(startNumber);

            Console.WriteLine("please enter end number");
            string endNumber = Console.ReadLine();
            int integerendNumber = (int)Convert.ToInt64(endNumber);

            Console.WriteLine("old number from 1 to 9 is ");

            for (int i= integerStartNumber; i<= integerendNumber; i+=2)
            {
                Console.WriteLine(i);

            }
            */
            Console.WriteLine("please enter number");
            string num1 = Console.ReadLine();
            int integerNum = int.Parse(num1);
            Console.WriteLine("the Factorial of this number " + integerNum );
            int num2 = 1;
            while (integerNum >= 1)
            {
                
                num2 = integerNum * num2;
                integerNum--;
            }
            Console.WriteLine(num2);

        }
    }
}