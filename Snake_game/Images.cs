using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake_game
{
    public static class Images
    {
        public readonly static ImageSource Body = LoadImage("DarkBlue.png");
        public readonly static ImageSource Empty = LoadImage("GreenSquare2.png");
        public readonly static ImageSource Head = LoadImage("BlueGuy.png");
        public readonly static ImageSource Food = LoadImage("Fries.png");
        public readonly static ImageSource Food2 = LoadImage("Apple.png");
        public readonly static ImageSource DeadBody = LoadImage("Skull2.png");
        public readonly static ImageSource DeadHead = LoadImage("Skull.png");
        public readonly static ImageSource Wall = LoadImage("BarbedWire.png");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }

    }
}
