using TestApp;

namespace LabWorkTest2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(35.288M, Task1.Power(3.28, 3));
        }

        [Fact]
        public static void Test2() {
            Assert.False(Task1.SafePassword("wer123++Вуц"));
        }

        [Fact]
        public void Test3() {

            Assert.True(Task1.SafePassword("wer123++Sup"));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(Task1.SafePassword("wer123++Supdeeeeeeeeeeeeeeeeeeeeeee"));
        }
    }
}
