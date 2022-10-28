using System;
using System.Threading;

namespace THREADINGG
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            
            for (int i = 0; i<=5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: {0} = {1} ",thread.Name,i);
                Thread.Sleep(1500);
                

                if (i == 5)
                {
                    //thread.Abort();
                }

            }
        }
    }
}
