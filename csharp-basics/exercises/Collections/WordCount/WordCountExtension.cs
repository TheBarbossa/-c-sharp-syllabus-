using System.IO;

namespace WordCount
{
    public class WordCountExtension
    {
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public static bool WhiteSpace(string text,int index)
        {
            return (char.IsWhiteSpace(text[index])) ? true : false;
        }
        public static bool Slash(string text, int index)
        {
            return (text[index] == '\'') ? true : false;
        }
    }
}