
namespace example
{
    class Program123
    {
        static void Main(string[] args)
        {
            string[] arr = { "simcha", "sasson", "gil", "rina", "aliza", "tzila", "ron" };
            //var q= arr.Where(name => name.Length > 3);
            //IEnumerable<string> q = arr.Where(name => name.Length > 3).Skip(2).Take(2).Reverse();


            //*** query operators
            var q = from name in arr
                    where name.Length > 3
                    select name;

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}