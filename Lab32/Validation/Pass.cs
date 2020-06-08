using System;

namespace Lab32.Verification
{
    public class Pass
    {
        private long _cardId;
        private long _tourniquetSystemId;
        private bool _passed;
        private DateTime _passDate;

        public Pass(bool passed, long tourniquetSystemId, long cardId)
        {
            _passed = passed;
            _tourniquetSystemId = tourniquetSystemId;
            _cardId = cardId;
            _passDate = DateTime.Now;
        }

        public long CardId => _cardId;

        public override string ToString()
        {
            return "\nCard id: " + _cardId +
                   "\nPass result: " + _passed +
                   "\nPass date: " + _passDate +
                   "\nTurnstileSystem uniqueId: " + _tourniquetSystemId + "\n";
        }
    }
}
