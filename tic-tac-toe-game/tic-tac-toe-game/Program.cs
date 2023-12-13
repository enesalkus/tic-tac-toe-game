
Console.WriteLine("Welcome to tic-tac-toe!");

int action = 0;
char[] list = new char[9];
drawTable(list);

do
{
    if (action != 9)
    {
        char player = (action % 2 == 0) ? 'X' : 'O';
        Console.Write($"{player}'s move > ");
        int move = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (move < 0 || list.Length <= move || list[move] == 'X' || list[move] == 'O')
        {
            Console.WriteLine("Illegal move! Try again.\n");
            continue;
        }
        list[move] = player;
        action++;
        drawTable(list);
    }
    else
    {
        action++;
        Console.WriteLine("Game over!");
    }
} while (action < 10);


void drawTable(char[] list)
{
    int tempStep = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 1; j <= 11; j++)
        {
            if (j % 4 == 0)
            {
                Console.Write("|");
            }
            else if (j % 2 == 0)
            {
                Console.Write((list[tempStep] == 'X' || list[tempStep] == 'O') ? list[tempStep] : ' ');
                tempStep++;
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (i < 2) Console.WriteLine("\n---+---+---");
    }
    Console.WriteLine("\n");
}