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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string result1 = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual("SAD", result1);
        }
        //TC1.2
        [Test]
        public void GivenHappyMood_WhenAnalyze_shouldReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string result = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual("HAPPY", result);
        }
    }
}