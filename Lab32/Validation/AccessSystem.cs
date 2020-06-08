using System.Collections.Generic;
using Lab32.cards;
using Lab32.CardType;

namespace Lab32.Verification
{
    public class AccessSystem
    {
        private List<Card> _cards;
        private List<Pass> _passes;
        private List<TourniquetSystem> _tourniquetSystem;
        private long _tourniquetSystemId;
        private long _cardId;
        private int _travelCoast = 4;

        public AccessSystem()
        {
            _passes = new List<Pass>();
            _cards = new List<Card>();
            _tourniquetSystem = new List<TourniquetSystem>();
            _tourniquetSystemId = 1;
            _cardId = 1;
        }
        public void AddPass(Pass pass)
        {
            _passes.Add(pass);
        }

        public void AddTourniquetSystem()
        {
            var item = new TourniquetSystem(_tourniquetSystemId, this);
            _tourniquetSystem.Add(item);
            _tourniquetSystemId++;
        }
        public void CreatePeriodCard(OwnerType ownerType, PeriodType periodType)
        {
            var item = new PeriodCard(_cardId, ownerType, periodType);
            _cards.Add(item);
            _cardId++;
        }
        public void CreateQuantityCard(OwnerType ownerType, QuantityType quantityType)
        {
            var item = new QuantityCard(_cardId, ownerType, quantityType);
            _cards.Add(item);
            _cardId++;
        }

        public void CreateCumulativeCard(int balance)
        {
            var item = new CumulativeCard(_cardId, balance, _travelCoast);
            _cards.Add(item);
            _cardId++;
        }

        public void BlockCard(Card card)
        {
            card.Block();
        }

        public Card GetCardByUniqueId(long uniqueId)
        {
            foreach (Card card in _cards)
            {
                if (card.UniqueId == uniqueId)
                {
                    return card;
                }
            }

            return null;
        }

        public string GetCardInfo(long uniqueId)
        {
            Card card = GetCardByUniqueId(uniqueId);
            return $"Card UniqueId: {card.UniqueId}\nOwner : {card.OwnerType}\n{card} Blocked: {card.IsBlocked}";
        }
        

        public List<CumulativeCard> GetCumulativeCardList()
        {
            List<CumulativeCard> cumulativeCardList = new List<CumulativeCard>();
            foreach (var card in _cards)
            {
                if (card.GetType() == typeof(CumulativeCard)) cumulativeCardList.Add((CumulativeCard)card);
            }
            return null;
        }

        public List<CumulativeCard> GetQuantityCardList()
        {
            List<QuantityCard> quantityCardList = new List<QuantityCard>();
            foreach (var card in _cards)
            {
                if (card.GetType() == typeof(QuantityCard))
                    quantityCardList.Add((QuantityCard)card);
            }
            return null;
        }

        public List<PeriodCard> GetPeriodCardList()
        {
            List<PeriodCard> termCardList = new List<PeriodCard>();
            foreach (var card in _cards)
            {
                if (card.GetType() == typeof(PeriodCard))
                    termCardList.Add((PeriodCard)card);
            }
            return null;
        }

        private string PassesToString(List<Pass> cardPasses)
        {
            string passes = "";
            foreach (Pass pass in cardPasses)
            {
                passes += pass.ToString();
                passes += "\n";
            }
            return passes;
        }

        public string GetPassDetailsForCard(long cardId)
        {
            List<Pass> cardPasses = _passes.FindAll(pass => pass.CardId == cardId);
            return PassesToString(cardPasses);
        }
        
        public string GetPassDetailsForCumulativeCards()
        {
            List<Pass> cardPasses = _passes.FindAll(pass => GetCardByUniqueId(pass.CardId).GetType() == typeof(CumulativeCard));
            return PassesToString(cardPasses);
        }

        public string GetPassDetailsForQuantityCards()
        {
            List<Pass> cardPasses = _passes.FindAll(pass => GetCardByUniqueId(pass.CardId).GetType() == typeof(QuantityCard));
            return PassesToString(cardPasses);
        }

        public string GetPassDetailsForTermCards()
        {
            List<Pass> cardPasses = _passes.FindAll(pass => GetCardByUniqueId(pass.CardId).GetType() == typeof(PeriodCard));
            return PassesToString(cardPasses);
        }
    }
}
