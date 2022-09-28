namespace LambdaSumOfNaturalNumbers
{
    public delegate int sum(int n);
    public delegate int two(int a, int b);
    public delegate void swap(int a, int b);
    public delegate bool check(int n);
    public delegate void sortarr(int[] a);

    internal class Program
    {
        static void Main(string[] args)
        {

            sum obj = (n) =>
            {
                int res = 0;
                for (int i = 0; i <= n; i++)
                {
                    
                    res += i;
                }
                return res;
            };

            Console.WriteLine("Enter the number: ");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: "+ obj(a));



            two num = (a, b) => (a > b) ?   a :  b;

            Console.WriteLine("Enter the number a: ");
            int c= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b: ");
            int d = int.Parse(Console.ReadLine());

            int r=num(c, d);
            Console.WriteLine("Greater: "+ r);

            Console.WriteLine("Numbers before swap:" + c + " "+ d);

            swap sw = (c, d) =>
            {
                c = c ^ d ^ (d = c);
                Console.WriteLine("Numbers before swap:" + c + " " + d);
            };

            sw(c, d);

            /*Console.WriteLine("Numbers before swap:" + c+ " " + d);
*/
            Console.WriteLine("Enter the number for prime check: ");
            int e = int.Parse(Console.ReadLine());

            check c1 = delegate (int n)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine( c1(e));

            Console.WriteLine("Enter the length of the array:");
            int l=int.Parse(Console.ReadLine());

            int[] arr = new int[l];

            for(int i=0;i<l;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            sortarr s1=(arr) => Array.Sort(arr);

            s1(arr);

            for(int i=0;i<l;i++)
            {
                Console.WriteLine(arr[i]);
            }




        }
    }
}