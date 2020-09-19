using System;

namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var turkey = new WildTurkey();
            var duck = new MallardDuck();
            var adapter = new TurkeyAdapter(turkey);
            var duckadapter = new DuckAdapter(duck);
            Tester(adapter);
            Tester(duckadapter);
        }

        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
			Console.WriteLine("Here the method called is Quack that belongs to Duck \n" );

        }


        private static void Tester(ITurkey turkey)
        {
            Console.WriteLine("Here the method called is Gobble that belongs to Turkey \n");

            turkey.Fly();
            turkey.Gobble();
        }
    }
}
