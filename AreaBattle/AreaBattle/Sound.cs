using Plugin.SimpleAudioPlayer;

namespace AreaBattle
{
    class Sound
    {
        public static void Play()
        {
            var player = CrossSimpleAudioPlayer.Current;
            player.Load("AreaBattleTest3.mp3");
            player.Loop = true;
            player.Play();
        }
    }
}