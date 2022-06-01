namespace BarsGroup_Developer_Task1
{
    using System;
    using System.Threading;

    internal class ParallelFlow
    {
        public static void ParallelAddCount()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Server.AddToCount();
                //Console.WriteLine("Писатель " + Thread.CurrentThread.Name + " изменил.");
            }
            Console.WriteLine("Писатель " + Thread.CurrentThread.Name + " закончил!");
        }
        public static void ParallelGetCount()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                //Console.WriteLine("Читатель " + Thread.CurrentThread.Name + " получил " + Server.GetCount());
            }
            Console.WriteLine("Читатель " + Thread.CurrentThread.Name + " прочел!");
        }
    }
}