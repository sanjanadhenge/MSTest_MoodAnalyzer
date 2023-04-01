using MAnalyzer;

namespace MS_Test
{
    public class Tests
    {
        //TC1.1
       [Test]
        public void GivenSadMood_WhenAnalyze_shouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result1 = moodAnalyzer.AnalyzeMood(message);

            Assert.AreEqual("SAD", result1);
        }
        //TC1.2
        [Test]
        public void GivenAnyMood_WhenAnalyze_shouldReturnSad()
        {
            string message = "I am in Any Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string result = moodAnalyzer.AnalyzeMood(message);

            Assert.AreEqual("HAPPY", result);
        }
    }
}