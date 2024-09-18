using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ThreadSafeSingletonLogger : SingletonBase
    {
        private static readonly object threadSafeLock = new object();

        private static ThreadSafeSingletonLogger instance;

        private ThreadSafeSingletonLogger() { }

        public static ThreadSafeSingletonLogger GetInstance()
        {
            if (instance == null)
            {
                lock (threadSafeLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletonLogger();
                    }

                }
            }
            return instance;
        }
    }
}
