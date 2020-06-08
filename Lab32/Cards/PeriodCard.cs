using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab32.cards;
using Lab32.CardType;

namespace Lab32.cards
{
    public class PeriodCard : Card
    {
        private DateTime _dateOfExpiry;
        private PeriodType _periodType;

        public PeriodCard(long uniqueId, OwnerType ownerType, PeriodType periodType) :
            base(uniqueId, ownerType)
        {
            _periodType = periodType;
            SetDateOfExpiry();
        }

        private void SetDateOfExpiry()
        {
            switch (_periodType)
            {
                case PeriodType.Day:
                    _dateOfExpiry = DateTime.Now.AddDays(1);
                    break;
                case PeriodType.Week:
                    _dateOfExpiry = DateTime.Now.AddDays(7);
                    break;
                case PeriodType.Month:
                    _dateOfExpiry = DateTime.Now.AddMonths(1);
                    break;
            }
        }

        public override bool Verify()
        {
            return _dateOfExpiry > DateTime.Now;
        }

        public override string ToString()
        {
            return $"Card type: Term \n Date of expiry: {_dateOfExpiry}\n";
        }
    }
}
