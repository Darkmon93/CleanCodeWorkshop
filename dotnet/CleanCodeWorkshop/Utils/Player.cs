using System;

namespace CleanCodeWorkshop.Utils
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Player()
        {
        }

        public Player(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

        public override bool Equals(object obj)
        {
            var result = obj as Player;

            if (obj == null)
            {
                return false; ;
            }

            return Id == result.Id && Name == result.Name && Score == result.Score;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Score);
        }
    }
}
