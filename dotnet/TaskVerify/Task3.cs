using CleanCodeWorkshop.Task_3;
using CleanCodeWorkshop.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Xml.Serialization;

namespace TaskVerify
{
    [TestClass]
    public class Task3
    {
        private List<Player> players = new List<Player>()
        {
            new Player(1,"TestPlayer", 50),
            new Player(4, "Leroy", 10)
        };

        [TestMethod]
        public void Serialize_PlayersToXML()
        {
            var testedSerializer = new XmlDataSerializer();

            var result = testedSerializer.Serialize(this.players);

            var xmlSerializer = new XmlSerializer(typeof(List<Player>));

            List<Player> playersToVerify;

            using (TextReader reader = new StringReader(result))
            {
                playersToVerify = (List<Player>)xmlSerializer.Deserialize(reader);
            }

            CollectionAssert.AreEqual(players, playersToVerify);
        }

        [TestMethod]
        public void Serialize_PlayersToJson()
        {
            var assembly = typeof(GameEngine).Assembly;
            var jsonDataSerializerType = assembly.GetType("CleanCodeWorkshop.Task_3.JsonDataSerializer");
            Assert.IsNotNull(jsonDataSerializerType);

            var testedSerializer = Activator.CreateInstance(jsonDataSerializerType);

            var method = jsonDataSerializerType.GetMethod("Serialize");
            var result = method.Invoke(testedSerializer, new [] {this.players}) as string;

            List<Player> playersToVerify;

            playersToVerify = JsonSerializer.Deserialize<List<Player>>(result);

            CollectionAssert.AreEqual(players, playersToVerify);
        }
    }
}
