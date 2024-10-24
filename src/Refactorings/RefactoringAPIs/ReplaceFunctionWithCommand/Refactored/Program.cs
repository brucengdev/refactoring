namespace ReplaceFunctionWithCommand.Refactored
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //bunch of stuff
        }

        public int Score(Candidate candidate, MedicalExam medicalExam, ScoringGuide scoringGuide)
        {
            return new Scorer(candidate, medicalExam, scoringGuide).Execute();
        }
    }
}
