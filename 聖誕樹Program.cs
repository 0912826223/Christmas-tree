using System;
class P
{
    {
        Console.WriteLine("");

        int star = 1;
        int line = 1;

        int space;
        space = 4;

        int b = 1;
        while(b<=5)


        {
            int i = 1;
            while (i <= space)
            {
                Console.Write(" ");
              i+=1;
            }

            {
                int t = 1;
                while (t <= star)
                {
                    Console.Write("*");
                   t+= 1;
                }
            }

            {
                int p = 1;
                while (p <= line)
                {
                    Console.Write("\n");
                 p += 1;
                }

            }

           space -= 1;
           star += 2;
            b += 1;


        }


        Console.WriteLine("結束");
        Console.Write("\n");
    }
}