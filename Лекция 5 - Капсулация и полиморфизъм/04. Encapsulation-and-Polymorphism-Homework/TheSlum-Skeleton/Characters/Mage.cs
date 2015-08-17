using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Characters;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Mage: Character, IAttack
    {
        public const int DefaultHealthPoints = 150;
        public const int DefaultDefensePoints = 50;
        public const int DefaultRange = 5;
        public const int DefaultattackPoint = 300;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultattackPoint;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(character => (character.Team != this.Team && character.IsAlive));

            //var target = targetsList.LastOrDefault(character => (character.Team != this.Team && character.IsAlive));
            //return target;
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

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public int AttackPoints { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Team: {1}, Health: {2}, Defense: {3}, Attack: {4}",
                this.Id, this.Team, this.HealthPoints, this.DefensePoints, this.AttackPoints);
        }
    }
}
