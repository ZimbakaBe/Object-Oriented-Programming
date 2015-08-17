using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Healer: Character, IHeal
    {
        public const int DefaultHealthPoints = 75;
        public const int DefaultDefensePoints = 50;
        public const int DefaultRange = 6;
        public const int DefaultHealingPoints = 60;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(a => a != this && a.Team == this.Team && a.IsAlive).OrderBy(t => t.HealthPoints).FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public int HealingPoints { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Team: {1}, Health: {2}, Defense: {3}, Heal: {4}",
                this.Id, this.Team, this.HealthPoints, this.DefensePoints, this.HealingPoints);
        }
    }
}
