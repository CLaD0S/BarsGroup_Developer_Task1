namespace BarsGroup_Developer_Task1
{
    using System;
    using System.Threading;
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread task = new(ParallelFlow.ParallelAddCount)
                {
                    Name = i.ToString()
                };
                task.Start();
            }
            for (int i = 0; i < 10; i++)
            {
                Thread task = new(ParallelFlow.ParallelGetCount)
                {
                    Name = i.ToString()
                };
                task.Start();
            }
            Console.ReadKey();
        }
    }
}
