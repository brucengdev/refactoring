namespace ReplaceConditionalsWithPolymorphism
{
    internal class Original : IRatingCalculator
    {
        public Rating GetRating(Voyage voyage, History history)
        {
            var vpf = VoyageProfitFactor(voyage, history);
            var vr = VoyageRisk(voyage);
            var chr = CaptainHistoryRisk(voyage, history);
            if(vpf * 3 > (vr + chr * 2)) return Rating.A;
            return Rating.B;
        }

        private int VoyageProfitFactor(Voyage voyage, History history)
        {
            var result = 2;
            if(voyage.Zone == "china") { result ++; }
            if(voyage.Zone == "east-indies") { result++; }
            if(voyage.Zone == "china" && HasChina(history))
            {
                result += 3;
                if(history.Voyages.Count > 10) { result++; }
                if(history.Voyages.Count > 12) { result++; }
                if(history.Voyages.Count > 18) { result--; }
            }else
            {
                if(history.Voyages.Count > 8) { result++; }
                if(history.Voyages.Count > 14) { result--; }
            }
            return result;
        }

        private int VoyageRisk(Voyage voyage)
        {
            var result = 1;
            if(voyage.Length > 4) { result += 2; }
            if(voyage.Length > 8) { result += voyage.Length - 8; }
            if(new string[] { "china", "east-indies"}.Contains(voyage.Zone))
            {
                result += 4;
            }
            return result;
        }

        private int CaptainHistoryRisk(Voyage voyage, History history)
        {
            var result = 1;
            if(history.Voyages.Count < 5) { result += 4; }
            result += history.Voyages.Count(v => v.Profit < 0);
            if(voyage.Zone == "china" && HasChina(history))
            {
                result -= 2;
            }

            return Math.Max(result, 0);
        }

        private bool HasChina(History history)
        {
            return history.Voyages.Exists(v => v.Zone == "china");
        }
    }
}
