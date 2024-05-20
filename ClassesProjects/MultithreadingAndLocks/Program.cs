namespace MultithreadingAndLocks
{
    internal class Program
    {
        private static int Counter = 1;

        private static object Dummy = new object();

        private static void Increment()
        {
            for (int i = 0; i < 100_000_000; i++)
            {
                lock (Dummy)
                {
                    Counter++;
                }

                //Interlocked.Increment(ref Counter);
            }
        }

        static void Main(string[] args)
        {
            var t1 = new Thread(Increment);
            var t2 = new Thread(Increment);
            
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(Counter);


            // This is really old school - no one does it anymore
            //var t = new Thread(Runner1);
            //t.IsBackground = true;

            //t.Start();

            //var list = new List<int>();

            //for (int i = 0; i <= 1_000_000_000; i++)
            //{
            //    list.Add(i);

            //    if (i > 0 && i % 100_000_000 == 0)
            //        Console.WriteLine($"{i} reached in the main");
            //}
            //Console.WriteLine("Job done in the main");

            //t.Join();
        }

        public static void Runner1()
        {
            var list = new List<int>();

            for (int i = 0; i <= 2_000_000_000; i++)
            {
                list.Add(i);

                if (i > 0 && i % 100_000_000 == 0)
                    Console.WriteLine($"{i} reached");
            }
            Console.WriteLine("Job done");
        }
    }
}