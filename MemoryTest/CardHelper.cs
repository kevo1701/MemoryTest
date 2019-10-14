using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Media;

namespace MemoryTest
{
    public static class CardHelper
    {
        public static ImageSource BackImage { get; }

        private static string rootDirectory;

        static CardHelper()
        {
            var rootDirectoryFull = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location).Split(new[] { @"\" }, StringSplitOptions.None);
            rootDirectory = string.Join(@"\", rootDirectoryFull.Take(rootDirectoryFull.Length - 2));
            BackImage = GetImageByIndex(0);
        }

        public static ImageSource GetImageByIndex(int index)
        {
            var cardPath = rootDirectory + $@"\Assets\Card{index}.jpg";
            return (new ImageSourceConverter()).ConvertFromString(cardPath) as ImageSource;
        }
    }
}
