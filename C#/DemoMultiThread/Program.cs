using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMultiThread
{
    class myThread
    {
        public void Thread_()
        {
            for (int i = 0; i< 10; i++)
            {
                Thread thr = Thread.CurrentThread;
                Console.WriteLine(thr.Name + "=" + i);
            }
            try
            {
                Thread.Sleep(1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.ToString());
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before start thread:");

            myThread thr1 = new myThread();
            myThread thr2 = new myThread();

            Thread thr_1 = new Thread(new ThreadStart(thr1.Thread_));
            Thread thr_2 = new Thread(new ThreadStart(thr2.Thread_));

            thr_1.Name = "Thread 1";
            thr_2.Name = "Thread 2";

            thr_1.Start();
            thr_2.Start();
        }
    }
}
