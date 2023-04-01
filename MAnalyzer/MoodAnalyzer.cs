namespace MAnalyzer
{
    public class MoodAnalyzer
    {
        string message;
      public MoodAnalyzer()
        {
            this.message = message;
        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch(Exception)
            {
                return "HAPPY";
            }
            
        }
        
    }
}