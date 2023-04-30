using System;
using System.Collections.Generic;
using System.Text;

namespace DP_calculator
{
    class BattleShipStrategy
    {
        static public void Use()
        {
            XT500Ship xt500 = new XT500Ship(new LaserAttack(), new EnergyShieldDefense());

            XT300Ship xT300 = new XT300Ship(new CannonAttack(), new InivisibilityDefense());

            xt500.Attack();
            xT300.Defense();

            xT300.Attack();
            xt500.Defense();
        }
    }


    interface IAttackStrategy
    {
        void Attack();
    }

    interface IDefenseStrategy
    {
        void Defend();
    }

    public class LaserAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("laser attack");
        }
    }

    public class CannonAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("cannon attack");
        }
    }

    public class EnergyShieldDefense : IDefenseStrategy
    {
        public void Defend()
        {
            Console.WriteLine("energy shield");
        }
    }

    public class InivisibilityDefense : IDefenseStrategy
    {
        public void Defend()
        {
            Console.WriteLine("insivibility");
        }
    }

    abstract class Ship
    {
        protected IAttackStrategy attackStrategy;
        protected IDefenseStrategy defenseStrategy;

        public Ship(IAttackStrategy attackStrategy, IDefenseStrategy defenseStrategy)
        {
            this.attackStrategy = attackStrategy;
            this.defenseStrategy = defenseStrategy;
        }

        public void Attack()
        {
            attackStrategy.Attack();
        }

        public void Defense()
        {
            defenseStrategy.Defend();
        }
    }

    class XT500Ship: Ship
    {
        public XT500Ship(IAttackStrategy attackStrategy, IDefenseStrategy defenseStrategy) : base(attackStrategy, defenseStrategy)
        {

        }
    }

    class XT300Ship: Ship
    {
       public XT300Ship(IAttackStrategy attackStrategy, IDefenseStrategy defenseStrategy) : base(attackStrategy, defenseStrategy)
       {

       }
    }

}
