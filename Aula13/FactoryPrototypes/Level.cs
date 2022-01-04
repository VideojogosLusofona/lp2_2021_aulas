using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPrototype
{
    public class Level
    {
        private char category;
        private IList<int> scores;

        public Level(char category, IEnumerable<int> scores)
        {
            this.category = category;
            this.scores = new List<int>(scores);
        }

        public void SetCategory(char category)
        {
            this.category = category;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{category}:");
            foreach (float sc in scores) sb.Append($" {sc}");
            return sb.ToString();
        }

        public void IncScores()
        {
            for (int i = 0; i < scores.Count; i++)
            {
                scores[i]++;
            }
        }

        public Level ShallowCopy()
        {
            Level copy = MemberwiseClone() as Level;
            return copy;
        }

        public Level DeepCopy()
        {
            Level copy = MemberwiseClone() as Level;
            copy.scores = new List<int>(scores);
            return copy;
        }
    }
}