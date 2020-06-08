using System;
using Lab32.cards;

namespace Lab32.Verification
{
    public class TourniquetSystem
    {
        private AccessSystem _accessSystem;
        private long _id;

        public TourniquetSystem(long id, AccessSystem accessSystem)
        {
            _id = id;
            _accessSystem = accessSystem;
        }

        public bool Passes(Card card)
        {
            if (_accessSystem.GetCardByUniqueId(card.UniqueId) == null)
            {
                _accessSystem.BlockCard(card);
                return false;
            }

            bool passes = card.Verify();

            if (!passes)
            {
                if (card.GetType() == typeof(PeriodCard) ||
                    card.GetType() == typeof(QuantityCard))
                    card.Block();
            }

            Pass pass = new Pass(passes, _id, card.UniqueId);
            _accessSystem.AddPass(pass);

            return passes;
        }
    }
}
