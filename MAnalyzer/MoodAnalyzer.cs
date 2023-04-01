namespace MAnalyzer
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
                return "HAPPY";
        }
        
    }
}