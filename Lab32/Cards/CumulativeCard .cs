using Lab32.CardType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32
{
    public class CumulativeCard : Card
    {
        private int _balance;
        private int _cost;
        public CumulativeCard(long uniqueId, int balance, int cost):
            base(uniqueId, OwnerType.Standard)
        {
            _balance = balance;
            _cost = cost;
        }
        public override bool Verify()
        {
            if (_balance < _cost)
                return false;

            _balance -= _cost;

            return true;

        }

        public override string ToString()
        {
            return $"Card type: Cumulative \n Balance: {_balance}\n";
        }

        public void Replenishment(int quantity)
        {
            _balance += quantity;
        }
    }
}
