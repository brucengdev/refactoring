
namespace ReplaceSubclassWithDelegate2.Original
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(BirdDataRecords))]
        public void Test(BirdData data)
        {
            var _sut = new Client();

            _sut.GetBirdInfo(data);
        }

        public static IEnumerable<object[]> BirdDataRecords = new List<object[]>
        {
            new object[] { new BirdData { 
                Name = "birda",
                IsNailed = false,
                NumberOfCoconuts = 0,
                Plumage = "long",
                Type = "EuropeanSwallow",
                Voltage = 0
            } },
            new object[] { new BirdData {
                Name = "birda",
                IsNailed = false,
                NumberOfCoconuts = 0,
                Plumage = "long",
                Type = "AfricanSwallow",
                Voltage = 0
            } },
            new object[] { new BirdData {
                Name = "birda",
                IsNailed = false,
                NumberOfCoconuts = 0,
                Plumage = "long",
                Type = "NorwegianBlueParrot",
                Voltage = 0
            } },
            new object[] { new BirdData {
                Name = "birda",
                IsNailed = false,
                NumberOfCoconuts = 0,
                Plumage = "long",
                Type = "Unknown",
                Voltage = 0
            } },
        };
    }
}