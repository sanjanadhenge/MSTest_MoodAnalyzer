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
        //TC4.1
        [Test]
        public void GivenClassName_WhenAnalyze_ShouldReturnMoodAnalyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerReflector.CreateMoodAnalyze("MAnalyzer.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
          //Assert.AreEqual(expected, obj);
                
        }
        //TC5.1
        [Test]
        public void GivenClassName_WhenAnalyze_ShouldReturnMoodAnalyzeObjectUsingParamertizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerReflector.CreateMoodAnalyzeUsingParameterizedConstructor("MAnalyzer.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);

        }
        //TC5.2
        [Test]
        public void GivenImproperClassName_WhenAnalyze_ShouldReturnMoodAnalyzeObjectUsingParamertizedConstructor()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyzerReflector.CreateMoodAnalyzeUsingParameterizedConstructor("MAnalyzer.Moodanalyze", "MoodAnalyzer", "HAPPY");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Class Not Found");
            }
        }
        //TC5.3
        [Test]
        public void GivenImproperConstructorName_WhenAnalyze_ShouldReturnMoodAnalyzeObjectUsingParamertizedConstructor()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyzerReflector.CreateMoodAnalyzeUsingParameterizedConstructor("MAnalyzer.MoodAnalyzer", "Moodanalyzer", "HAPPY");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Constructor Not Found");
            }
        }
        //TC6.1
        [Test]
        public void GivenMessageHappy_WhenAnalyze_ShouldReturnHappyUsingInvoke()
        {
            string result = MoodAnalyzerReflector.InvokeMethod("Happy", "AnalyzeMood1");
            Assert.AreEqual("HAPPY", result);
           
        }
        //TC6.2
        [Test]
        public void GivenWrongMethod_WhenAnalyze_ShouldThrowException()
        {
            try
            {
                string result = MoodAnalyzerReflector.InvokeMethod("Happy", "Analyze_Mood");
                Assert.AreEqual("HAPPY", result);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Method Not Found");
            }

        }

    }
}