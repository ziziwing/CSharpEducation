using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.Json;

public class TikTakToe
{
    enum Motion
    {
        X,
        O
    }
    private static int[] motions = new int[9];

    public static void Main()
    {
        Random random = new Random();
        var choise = random.Next(2);
        var firstMove = choise == 0 ? Motion.X : Motion.O;
        var secondMove = firstMove.Equals(Motion.X) ? Motion.O : Motion.X;
        string[,] newField = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        ShowField(newField);
        Console.WriteLine("Первыми ходят " + firstMove);
        for (int i = 1; i <= 9; i++)
        {
            int move = Move();
            motions[i - 1] = move;
            var currentMove = i % 2 != 0 ? firstMove : secondMove;
            var field = DieIsCast(move, currentMove, newField);
            Console.Clear();
            ShowField(field);
            if (!ItsWin(field))
            {
                var nextMove = currentMove.Equals(Motion.X) ? Motion.O : Motion.X;
                Console.WriteLine("Сейчас ходит " + nextMove);
            }
            else
            {
                Console.WriteLine("Победа за " + currentMove);
                GameOver();
            }
        }
        Console.WriteLine("Ничья");
        GameOver();
    }

    private static int Move()
    {
        var readLine = Console.ReadLine();
        int move;

        if (int.TryParse(readLine, out var value))
        { 
            move =  Convert.ToInt32(readLine);
            bool itsBadMove = BadMove(move);
            if (BadMove(move))
            {
                Console.WriteLine("Такой ход уже есть.");
                return Move();
            }
            else
            {
                return move;
            }
        }
        else
        {
            Console.WriteLine("Нужно ввести цифру от 1 до 9");
            return Move();
        }
    }

    private static string[,] DieIsCast(int value, Enum currentMove, string[,] field)
    {
        switch (value)
        {
            case 1:
                field[0, 0] = currentMove.ToString();
                break;
            case 2:
                field[0, 1] = currentMove.ToString();
                break;
            case 3:
                field[0, 2] = currentMove.ToString();
                break;
            case 4:
                field[1, 0] = currentMove.ToString();
                break;
            case 5:
                field[1, 1] = currentMove.ToString();
                break;
            case 6:
                field[1, 2] = currentMove.ToString();
                break;
            case 7:
                field[2, 0] = currentMove.ToString();
                break;
            case 8:
                field[2, 1] = currentMove.ToString();
                break;
            case 9:
                field[2, 2] = currentMove.ToString();
                break;

        }
        return field;
    }
    private static void ShowField(string[,] field)
    {
        int rows = field.GetUpperBound(0) + 1;
        int colums = field.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                if (field[i, j] == Motion.X.ToString())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (field[i, j] == Motion.O.ToString())
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write($"{field[i, j]} \t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    private static void GameOver()
    {
        Console.WriteLine("Игра окончена. Хотите начать сначала?(y/n)");
        switch (Console.ReadKey().Key)
        {
            case
                ConsoleKey.Y:
                Console.Clear();
                motions = new int[9];
                Main();
                break;
            case ConsoleKey.N:
                Console.WriteLine();
                Console.WriteLine("Это было здорово!");
                Console.WriteLine("Игра окончена");
                Process.GetCurrentProcess().Kill();
                break;
        }
    }

    private static bool ItsWin(string[,] field)
    {
        bool itsWin = false;

        for(int i = 0; i < 3; i++)
        {
            var horizontalWin = field[i, 0];
            var verticalWin = field[0, i];

            int hCount = 0;
            int vCount = 0;

            for (int j = 0; j < 3; j++)
            {
                if (horizontalWin == field[i, j])
                {
                    hCount++;
                }
                if (verticalWin == field[j, i])
                {
                    vCount++;
                }
            }

            if(hCount == 3 | vCount == 3)
            {
                itsWin = true;
            }
        }

        if(!itsWin)
        {
            if ((field[0, 0] == field[1, 1] & field[1, 1] == field[2, 2]) 
                || (field[0, 2] == field[1, 1] & field[1, 1] == field[2, 0]))
            {
                itsWin = true;
            }
        }

        return itsWin;
    }

    private static bool BadMove(int move)
    {
        bool result = false;

        foreach (var item in motions)
        {
            if(item == move)
            {
                result = true;   
            }
        }

        return result;
    }
}