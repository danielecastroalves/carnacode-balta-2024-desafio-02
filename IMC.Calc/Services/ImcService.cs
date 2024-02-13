namespace IMC.Calc.Services
{
    public class ImcService
    {
        private readonly List<(double, DateTime)> imcResults = [];

        public void AddResult(double imc)
        {
            imcResults.Add((imc, DateTime.Now));
        }

        public IReadOnlyList<(double, DateTime)> GetResults()
        {
            return imcResults.AsReadOnly();
        }
    }
}
