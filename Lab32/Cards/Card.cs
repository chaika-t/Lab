using Lab32.CardType;

namespace Lab32
{
    public abstract class Card
    {
        private long _uniqueId;
        private OwnerType _ownerType;
        private bool _isBlocked;

        public Card(long uniqueId, OwnerType ownerType)
        {
            _uniqueId = uniqueId;
            _ownerType = ownerType;
            _isBlocked = false;

        }

        public long UniqueId => _uniqueId;

        public OwnerType OwnerType => _ownerType;

        public bool IsBlocked => _isBlocked;

        public void Block() => _isBlocked = true;

        public string GetOwner()
        {
            switch (_ownerType)
            {
                case OwnerType.Standard:
                    return "Ordinary";
                case OwnerType.Retiree:
                    return "Retiree";
                default:
                    return "Student";
            }
        }

        public abstract bool Verify();
    }
}
