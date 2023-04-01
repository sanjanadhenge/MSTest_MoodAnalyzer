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
            string result1 = moodAnalyzer.AnalyzeMood1();

            Assert.AreEqual("SAD", result1);
        }
        //TC1.2
        [Test]
        public void GivenHappyMood_WhenAnalyze_shouldReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string result = moodAnalyzer.AnalyzeMood1();

            Assert.AreEqual("HAPPY", result);
        }
        //TC3.1
        [Test]
        public void GivenNullMood_WhenAnalyze_shouldReturnSad()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string result = moodAnalyzer.AnalyzeMood1();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Message is null");
            }
        }
        //TC3.2
        [Test]
        public void GivenEmptyMood_WhenAnalyze_shouldReturnSad()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                string result = moodAnalyzer.AnalyzeMood2();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }


        }
    }
}