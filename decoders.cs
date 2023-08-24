static void Skitala(string text)
{
    for (int i = 2; i <= text.Length / 2 + (text.Length % 2 == 0 ? 0 : 1); i++)
    {
        int len = text.Length / i + (text.Length % i == 0 ? 0 : 1);
        char[,] table = new char[i, len];
        Console.WriteLine("Table {0} x {1}", i, len);
        int str_pos = 0;
        for (int j = 0; j < len; j++)
        {
            for (int k = 0; k < i; k++)
            {
                try
                {
                    table[k, j] = text[str_pos];
                }
                catch(Exception ex)
                {
                    table[k, j] = ' ';
                }
                str_pos++;
            }
        }
        for(int j = 0; j < i; j++)
        {
            for (int k = 0; k < len; k++)
            {
                Console.Write("{0} | ", table[j, k]);
            }
            Console.Write("\n");
        }
    }
}
