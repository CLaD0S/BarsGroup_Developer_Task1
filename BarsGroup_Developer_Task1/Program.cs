namespace BarsGroup_Developer_Task1
{
    using System;
    using System.Threading;

    internal class Program
    {
        static void Main()
        {
            Thread thread;
            for (int i = 0; i < 5; i++)
            {
                thread = new(() => ParallelFlow.ParallelGetCount(10000))
                {
                    Name = i.ToString()
                };
                thread.Start();

            }
            thread = new(() => ParallelFlow.ParallelAddCount(100))
            {
                Name = 6.ToString()
            };
            thread.Start();
            Console.ReadKey();
            Console.WriteLine(Server.GetCount());

            Console.ReadKey();
        }
    }
}
