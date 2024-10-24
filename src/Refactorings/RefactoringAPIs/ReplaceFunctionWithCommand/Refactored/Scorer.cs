namespace ReplaceFunctionWithCommand.Refactored
{
    internal class Scorer
    {
        private Candidate _candidate { get; set; }
        private MedicalExam _medicalExam { get; set; }
        private ScoringGuide _scoringGuide { get; set; }
        public Scorer(Candidate candidate,
            MedicalExam medicalExam,
            ScoringGuide scoringGuide)
        {
            _candidate = candidate;
            _medicalExam = medicalExam;
            _scoringGuide = scoringGuide;
        }
        public int Execute()
        {
            var result = 0;
            var healthLevel = 0;
            var highMedicalRiskFlag = false;

            if (_medicalExam.IsSmoker)
            {
                healthLevel += 10;
                highMedicalRiskFlag = true;
            }

            var certificateGrade = "regular";
            if (_scoringGuide.StateWithLowCertification(_candidate.OriginState))
            {
                certificateGrade = "low";
                result -= 5;
            }

            //lots more code like this

            result -= Math.Max(healthLevel - 5, 0);
            return result;
        }
    }
}
