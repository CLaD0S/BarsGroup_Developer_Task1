using System;

namespace BarsGroup_Developer_Task1
{
    internal class ParallelFlow
    {
        public static void ParallelGetCount(int countRead)
        {
            for (int i = 0; i < countRead; i++)
            {
                Server.GetCount();
            }
        }
        public static void ParallelAddCount(int countWrite)
        {
            for (int i = 0; i < countWrite; i++)
            {
                Server.AddToCount();
            }
        }
    }
}