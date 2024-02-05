using System;

class Shiritori
{
    private string[] words;
    private int count;
    private bool game_over;

    public Shiritori()
    {
        words = new string[0];
        count = 0;
        game_over = false;
    }

    public string[] Play(string word)
    {
        if (!game_over)
        {
            if (count == 0 || word[0] == words[count - 1][words[count - 1].Length - 1])
            {
                if (!Array.Exists(words, w => w == word))
                {
                    Array.Resize(ref words, words.Length + 1);
                    words[count] = word;
                    count++;
                    return words;
                }
                else
                {
                    game_over = true;
                    Console.WriteLine("Game over! Word has already been said.");
                }
            }
            else
            {
                game_over = true;
                Console.WriteLine("Game over! Word does not follow the rules.");
            }
        }
        else
        {
            Console.WriteLine("Game over! You can't play in a finished game.");
        }
        return null;


    }

    public string Restart()
    {
        words = new string[0];
        count = 0;
        game_over = false;
        return "Game restarted.";
    }
}

class Program
{
    static void Main()
    {
        Shiritori myShiritori = new Shiritori();

        Console.WriteLine(string.Join(", ", myShiritori.Play("apple")));
        Console.WriteLine(string.Join(", ", myShiritori.Play("ear")));
        Console.WriteLine(string.Join(", ", myShiritori.Play("rhino")));
        Console.WriteLine(myShiritori.Play("corn"));
        Console.WriteLine(myShiritori.Restart());
    }
}
