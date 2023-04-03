namespace MAnalyzer
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood1()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Message is null");
            }
        }
        public string AnalyzeMood2()
        {
            try
            {
                if (message.ToLower().Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
            }
        }

    }
}