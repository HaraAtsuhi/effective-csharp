using System;

namespace 呼び出し順確認
{
    class Program
    {
        class CallOrder
        {
            public CallOrder()
            {
                Console.WriteLine("CallOrderのコンストラクタ");
            }
            static CallOrder()
            {
                Console.WriteLine("CallOrderのstaticコンストラクタ");
            }

            public CallOrder2 a = new CallOrder2();

            static public void Print()
            {
                Console.WriteLine("CallOrderのPrintメソッド");
            }
        }
        public class CallOrder2
        {
            public CallOrder2()
            {
                Console.WriteLine("フィールドの初期化");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mainメソッド開始");
            CallOrder callOdrer = new CallOrder();
            CallOrder.Print();
            Console.WriteLine("Mainメソッド終了");
            Console.ReadLine();
        }
    }
}
