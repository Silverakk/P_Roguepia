using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace P_RogueTower
{
    
    static class Sauvegarde
    {
        const string DefaultFileName = "Game.Game";
        public static void Serialisation(Game game, string fichierSave = DefaultFileName)
        {
            if(game != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fichierSave, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, game);
                stream.Close();
            }
        }
        public static Game Deserialisation(string fichierSave = Sauvegarde.DefaultFileName)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fichierSave, FileMode.Open, FileAccess.Read, FileShare.Read);
                Game game = (Game)formatter.Deserialize(stream);
                stream.Close();
                return game;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
