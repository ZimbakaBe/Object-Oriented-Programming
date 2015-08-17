using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Warrior : Character, IAttack
    {
        public const int DefaultHealthpoints = 200;
        public const int DefaultDefensePoints = 100;
        public const int DefaultRange = 2;
        public const int DefaultAttackPoints = 150;

        public Warrior(string id, int x, int y, Team team) :
            base(id, x, y, DefaultHealthpoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
           return targetsList.FirstOrDefault(character => (character.Team != this.Team && character.IsAlive));
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
