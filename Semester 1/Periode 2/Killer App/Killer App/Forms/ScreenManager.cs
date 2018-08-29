using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Killer_App.Forms;

namespace Killer_App
{
    static class ScreenManager
    {
        public static int CurrentUser;
        public enum Screen {BiljartClub, Chat, Geschiedenis, HoofdMenu, InlogScherm, MijnProfiel, PoolMatch, Profiel, Exit}
        static public Screen NextScreen = Screen.InlogScherm;

        public static void RunApplication()
        {
            while (true)
            {
                OpenScreen();
            }
        }

        public static void OpenScreen()
        {
            switch (NextScreen)
            {
                case Screen.BiljartClub:
                    BiljartClub biljartClub = new BiljartClub();
                    biljartClub.ShowDialog();
                    break;
                case Screen.Chat:
                    Chat chat = new Chat();
                    chat.ShowDialog();
                    break;
                case Screen.Geschiedenis:
                    Geschiedenis geschiedenis = new Geschiedenis();
                    geschiedenis.ShowDialog();
                    break;
                case Screen.HoofdMenu:
                    HoofdMenu hoofdMenu = new HoofdMenu();
                    hoofdMenu.ShowDialog();
                    break;
                case Screen.InlogScherm:
                    InlogScherm inlogScherm = new InlogScherm();
                    inlogScherm.ShowDialog();
                    break;
                case Screen.MijnProfiel:
                    MijnProfiel mijnProfiel = new MijnProfiel();
                    mijnProfiel.ShowDialog();
                    break;
                case Screen.PoolMatch:
                    PoolMatch poolMatch = new PoolMatch();
                    poolMatch.ShowDialog();
                    break;
                case Screen.Profiel:
                    Profiel profiel = new Profiel();
                    profiel.ShowDialog();
                    break;
                case Screen.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
