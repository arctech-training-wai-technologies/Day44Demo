// See https://aka.ms/new-console-template for more information

using Day44ThreadDemo;

const string filePath = @"C:\logs\test\Samplexml100.xml";

Console.WriteLine("Starting Program");

// Single Default Thread
//StartTransfer();

// Multiple Threads
var t = new Thread(StartTransfer)
{
    IsBackground = true
};

t.Start();

Console.WriteLine("Ending Program");

void StartTransfer()
{
    var fileToDbService = new FileToDbService();

    for (var i = 0; i < 10; i++)
    {
        fileToDbService.TransferDataFromFileToDb(filePath);
    }
}