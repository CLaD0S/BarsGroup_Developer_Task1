namespace BarsGroup_Developer_Task1
{
    internal class Server
    {
        private static int _count;
        private static readonly object _lockAddCount = new();

        public static int GetCount()
        {
            lock (_lockAddCount)
                return _count;
            //object __lockObj = _lockAddCount;
            //bool __lockWasTaken = false;
            //try
            //{
            //    Monitor.Enter(__lockObj, ref __lockWasTaken);
            //    return _count;
            //}
            //finally
            //{
            //    if (__lockWasTaken) Monitor.Exit(__lockObj);
            //}
        }

        public static void AddToCount()
        {
            lock (_lockAddCount)
                _count++;
            //object __lockObj = _lockAddCount;
            //bool __lockWasTaken = false;
            //try
            //{
            //    Monitor.Enter(__lockObj, ref __lockWasTaken);
            //    _count += Convert.ToInt32(Console.ReadLine());
            //}
            //finally
            //{
            //    if (__lockWasTaken) Monitor.Exit(__lockObj);
            //}
        }
    }
}