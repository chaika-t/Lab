using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab32.CardType;

namespace Lab32.cards
{
    public class QuantityCard : Card 
    {
        private int _travelLeft;
        private QuantityType _quantityType;

        public QuantityCard(long uniqueId, OwnerType ownerType, QuantityType quantityType) :
            base(uniqueId, ownerType)
        {
            _quantityType = quantityType;
            SetTravelsNumber();
        }
        private void SetTravelsNumber()
        {
            switch (_quantityType)
            {
                case QuantityType.Four:
                    _travelLeft = 4;
                    break;
                case QuantityType.Ten:
                    _travelLeft = 10;
                    break;
                case QuantityType.Twenty:
                    _travelLeft = 20;
                    break;
            }
        }

        public override bool Verify()
        {
            bool isVerified = false;

            if (_travelLeft > 0)
            {
                _travelLeft--;
                isVerified = true;
            }

            return isVerified;
        }

        public override string ToString()
        {
            return $"Card type: Quantity \n Travels left: {_travelLeft}";
        }
     
    }
}
