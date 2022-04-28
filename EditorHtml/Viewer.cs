using System;
using System.Text.RegularExpressions;

namespace EditorHtml{
    public class Viewer{
        public static void Show(string Text) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Replace(Text);
            Console.WriteLine("==================");
            Console.ReadKey();
            Menu.Show();
        }
    
        public static void Replace(string text){
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for(var i=0; i<=words.length; i++){
                
            }
        }
    }
}