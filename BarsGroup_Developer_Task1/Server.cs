namespace BarsGroup_Developer_Task1
{
    using System.Threading;
    internal class Server
    {
        private static ReaderWriterLockSlim _readerWriterLockSlim = new ReaderWriterLockSlim();
        private static volatile int _count;

        public static int GetCount()
        {
            _readerWriterLockSlim.EnterReadLock();
            try
            {
                return _count;
            }
            finally
            {
                _readerWriterLockSlim.ExitReadLock();
            }
        }

        public static void AddToCount()
        {
            _readerWriterLockSlim.EnterWriteLock();
            try
            {
                Interlocked.Increment(ref _count);
            }
            finally
            {
                _readerWriterLockSlim.ExitWriteLock();
            }
        }
    }
}