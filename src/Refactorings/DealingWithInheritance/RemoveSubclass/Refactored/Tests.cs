using Shouldly;

namespace RemoveSubclass.Refactored
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            var sut = new Client();

            sut.SetData(
            [
                ("Tom", 'M'),
                ("Jack", 'M'),
                ("Tim", 'M'),
                ("Joanna", 'F'),
                ("Jenna", 'F'),
                ("Timmy", 'X')
            ]);

            sut.GetNumberOfMales().ShouldBe(3);
        }
    }
}