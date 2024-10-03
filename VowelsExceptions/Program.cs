namespace Vowels
{
    internal class Program
    {
        static void VowelCheck(string s)
        {
            s.ToLower();
            try
            {
                if (!(s.Contains('a') || s.Contains('e')
                    || s.Contains('i') || s.Contains('o') || s.Contains('u')))
                {
                    throw new VowelException();
                }
            }
            catch (VowelException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Checking process is done");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string including at least one vowel: ");
            string userInput = Console.ReadLine();
            VowelCheck(userInput);

        }
    }
}
