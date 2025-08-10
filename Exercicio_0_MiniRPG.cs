
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int ataque = random.Next(1, 10);
        int herohp = 10;
        int monsterhp = 10;

        while (monsterhp > 0 && herohp > 0)
        {
            ataque = random.Next(1, 10);
            monsterhp -= ataque;
            Console.WriteLine($"Monster was damaged and lost {ataque} health and now has {monsterhp} health.");
            if (monsterhp > 0)
            {
                ataque = random.Next(1, 10);
                herohp -= ataque;
                Console.WriteLine($"Hero was damaged and lost {ataque} health and now has {herohp} health.");
            }

            if (monsterhp <= 0)
                Console.WriteLine("Hero wins!!");
            if (herohp <= 0)
                Console.WriteLine("Monster wins!!");

        }
    }
}