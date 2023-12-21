using System;
using System.Windows.Media;
namespace Snake_game
{
    public static class Audio   
    {
        public readonly static MediaPlayer GameOver = LoadAudio("GameOver.wav");
        
        private static MediaPlayer LoadAudio(string filename, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            

            if (autoReset)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            return player;
        }

        private static void Player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }
    }
}
