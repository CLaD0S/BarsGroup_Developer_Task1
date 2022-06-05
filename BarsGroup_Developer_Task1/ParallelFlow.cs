namespace BarsGroup_Developer_Task1
{
    internal class ParallelFlow
    {
        public static void ParallelGetCount(int countRead)
        {
            for (int i = 0; i < countRead; i++)
            {
                //Console.WriteLine("Читатель " + Thread.CurrentThread.Name + " читает " + Server.GetCount());
                Server.GetCount();
            }
            //Console.WriteLine("Читатель " + Thread.CurrentThread.Name + " прочел!");
        }
        public static void ParallelAddCount(int countWrite)
        {
            for (int i = 0; i < countWrite; i++)
            {
                Server.AddToCount();
                //Console.WriteLine("Писатель " + Thread.CurrentThread.Name + " записал " + Server.GetCount());
            }
            //Console.WriteLine("Писатель " + Thread.CurrentThread.Name + " закончил!");
        }
    }
}