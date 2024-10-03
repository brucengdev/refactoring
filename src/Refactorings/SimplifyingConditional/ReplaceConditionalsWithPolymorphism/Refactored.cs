namespace ReplaceConditionalsWithPolymorphism
{

    internal class VoyageRating
    {
        protected Voyage _voyage;
        protected History _history;
        public VoyageRating(Voyage voyage, History history)
        {
            _voyage = voyage;
            _history = history;
        }
        public Rating GetRating()
        {
            var vpf = VoyageProfitFactor();
            var vr = VoyageRisk();
            var chr = CaptainHistoryRisk();
            if (vpf * 3 > (vr + chr * 2)) return Rating.A;
            return Rating.B;
        }
        private int VoyageProfitFactor()
        {
            var result = 2;
            if (_voyage.Zone == "china") { result++; }
            if (_voyage.Zone == "east-indies") { result++; }
            result += VoyageAndHistoryLengthProfitFactor();
            return result;
        }

        protected virtual int VoyageAndHistoryLengthProfitFactor()
        {
            var result = 0;
            if (_history.Voyages.Count > 8) { result++; }
            if (_history.Voyages.Count > 14) { result--; }
            return result;
        }

        private int VoyageRisk()
        {
            var result = 1;
            result += VoyageLengthFactor();
            if (new string[] { "china", "east-indies" }.Contains(_voyage.Zone))
            {
                result += 4;
            }
            return result;
        }

        private int VoyageLengthFactor()
        {
            var result = 0;
            if (_voyage.Length > 4) { result += 2; }
            if (_voyage.Length > 8) { result += _voyage.Length - 8; }
            return result;
        }

        protected virtual int CaptainHistoryRisk()
        {
            var result = 1;
            if (_history.Voyages.Count < 5) { result += 4; }
            result += _history.Voyages.Count(v => v.Profit < 0);
            return Math.Max(result, 0);
        }

        private bool HasChina()
        {
            return _history.Voyages.Exists(v => v.Zone == "china");
        }
    }

    internal class HasExperienceInChinaVoyageRating : VoyageRating
    {
        public HasExperienceInChinaVoyageRating(Voyage voyage, History history) : base(voyage, history)
        {
        }

        protected override int VoyageAndHistoryLengthProfitFactor()
        {
            var result = 0;
            result += 3;
            if (_history.Voyages.Count > 10) { result++; }
            if (_history.Voyages.Count > 12) { result++; }
            if (_history.Voyages.Count > 18) { result--; }
            return result;
        }

        protected override int CaptainHistoryRisk()
        {
            return Math.Max(base.CaptainHistoryRisk() - 2, 0);
        }
    }

    internal class Refactored : IRatingCalculator
    {
        private VoyageRating CreateVoyageRating(Voyage voyage, History history)
        {
            if(voyage.Zone == "china" && HasChina(history))
            {
                return new HasExperienceInChinaVoyageRating(voyage, history);
            }
            return new VoyageRating(voyage, history);
        }
        private bool HasChina(History history)
        {
            return history.Voyages.Exists(v => v.Zone == "china");
        }

        public Rating GetRating(Voyage voyage, History history)
        {
            var rating = CreateVoyageRating(voyage, history);

            return rating.GetRating();

        }
    }
}
