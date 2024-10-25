namespace ReplaceFunctionWithCommand.Refactored
{
    internal class Program
    {
        public int Score(Candidate candidate, MedicalExam medicalExam, ScoringGuide scoringGuide)
        {
            return new Scorer(candidate, medicalExam, scoringGuide).Execute();
        }
    }
}
