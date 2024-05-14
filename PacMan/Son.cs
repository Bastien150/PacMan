using System;
using System.IO;
using System.Media;

namespace PacMan
{
    static class Son
    {
        static private SoundPlayer Player;
        static private Stream SonEnCours = null;

        static Son()
        {
            Player = new SoundPlayer();
        }

        static public void Jouer(Stream LeSon, bool EnBoucle = false)
        {
            if (SonEnCours != null && LeSon.Length == SonEnCours.Length && EnBoucle) return; // Son déjà joué
            Arreter();
            Player.Stream = LeSon;
            if (EnBoucle)
            {
                Player.PlayLooping();
                SonEnCours = LeSon;
            }
            else
            {
                Player.Play();
                SonEnCours = null;
            }
        }

        static public void Arreter()
        {
            Player.Stop();
            SonEnCours = null;
        }
    }
}
