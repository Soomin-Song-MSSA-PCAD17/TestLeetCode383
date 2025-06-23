namespace TestLeetCode383
{
    public class Tests
    {
        LeetCode383.Solution Solution { get; set; }
        string RansomeNote { get; set; }
        string Magazine { get; set; }
        bool ExpectedOutput { get; set; }

        [SetUp]
        public void Setup()
        {
            Solution = new LeetCode383.Solution();
        }

        [Test]
        public void Test1()
        {
            RansomeNote = "a";
            Magazine = "b";
            ExpectedOutput = false;
            Assert.That(Solution.CanConstruct(RansomeNote, Magazine), Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test2()
        {
            RansomeNote = "aa";
            Magazine = "ab";
            ExpectedOutput = false;
            Assert.That(Solution.CanConstruct(RansomeNote, Magazine), Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test3()
        {
            RansomeNote = "aa";
            Magazine = "aab";
            ExpectedOutput = true;
            Assert.That(Solution.CanConstruct(RansomeNote, Magazine), Is.EqualTo(ExpectedOutput));
        }
    }
}
