namespace Dublicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i =0;
            List<int> intInputs = new List<int>();
            for (i = 0; i < 5; i++) {
                try
                {
                    Console.Write($"Enter a non duplicated int number [{i}]: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (intInputs.Contains(userInput))
                    {
                        throw new DuplicateException();
                    }
                    intInputs.Add(userInput);
                }
                catch (DuplicateException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    i--;
                }
                finally {
                    Console.WriteLine("Done");
                }

            }
        }
    }
}
