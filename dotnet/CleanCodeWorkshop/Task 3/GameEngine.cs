using CleanCodeWorkshop.Utils;
using System.Collections.Generic;
using System.IO;

namespace CleanCodeWorkshop.Task_3
{
    // TODO: replace xml data serializer type with interface type you create
    public class GameEngine
    {
        private List<Player> players;
        private XmlDataSerializer serializer;

        public GameEngine(XmlDataSerializer serializer)
        {
            this.players = new List<Player>();
            this.serializer = serializer;
        }

        public GameEngine(List<Player> players, XmlDataSerializer serializer)
        {
            this.players = players;
            this.serializer = serializer;
        }   

        public void SavePlayersData()
        {
            string playersDataPath = @"save/players.data";
            string playersToSave = this.serializer.Serialize(players);
            File.WriteAllText(playersDataPath, playersToSave);
        }
    }
}
