namespace ReplaceFunctionWithCommand.Original
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //bunch of stuff
        }

        public int Score(Candidate candidate, MedicalExam medicalExam, ScoringGuide scoringGuide)
        {
            var result = 0;
            var healthLevel = 0;
            var highMedicalRiskFlag = false;

            if(medicalExam.IsSmoker)
            {
                healthLevel += 10;
                highMedicalRiskFlag = true;
            }

            var certificateGrade = "regular";
            if(scoringGuide.StateWithLowCertification(candidate.OriginState))
            {
                certificateGrade = "low";
                result -= 5;
            }

            //lots more code like this

            result -= Math.Max(healthLevel -5, 0);
            return result;
        }
    }
}
