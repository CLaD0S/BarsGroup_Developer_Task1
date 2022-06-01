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
        }

        public static void AddToCount()
        {
            lock (_lockAddCount)
                _count++;
        }
    }
}