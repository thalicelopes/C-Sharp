using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
        }

        public static void DrawScreen()
        {
            //DESENHAR TELA, PROCURAR REFATORAR
            Console.Clear();
            Console.Write("+");
            for (int i = 0; i <= 30; i++) Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i <= 30; i++) Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.Clear();
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=======================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("=======================");
        }
    }
}