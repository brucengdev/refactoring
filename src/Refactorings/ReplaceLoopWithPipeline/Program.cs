using ReplaceLoopWithPipeline.Original;

var data = @"
    office,country,telephone
    Chicago,USA,12345678
    Beijing,China,2222222
    Bangalore,India,32323232
    Proto Alegre,Brazil,44444444
    Chennai,India,775565566
";


static void Print(Record[] records)
{
    foreach(var record in records)
    {
        record.Print();
    }
}

Console.WriteLine("Original algorithm");
Print(Original.AccquireData(data, "India"));

Console.WriteLine("\nRefactored algorithm");
Print(Refactored.AccquireData(data, "India"));

public class Record
{
    public string Office { get; set; }
    public string Country { get; set; }
    public string Telephone { get; set; }

    public void Print()
    {
        Console.WriteLine("{0},{1},{2}", Office, Country, Telephone);
    }
}

