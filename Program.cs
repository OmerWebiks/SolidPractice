using SolidTest.classes;


    
//EmailSender emailSender = new EmailSender();
//SmsSender smsSender = new SmsSender();
//NotificationService ns1 = new NotificationService(emailSender);
//NotificationService ns2 = new NotificationService(smsSender);
//ns1.Notify("Shulem", "WHere Are You?");
//ns2.Notify("Leizer", "Come Here");

async Task foo1()
{
    Console.WriteLine("inside foo1 ");
    await Task.Delay(2000);
    Console.WriteLine("hi1");
    await Task.Delay(2000);
}

async Task foo2()
{
    Console.WriteLine("inside foo2 ");
    await Task.Delay(3000);
    Console.WriteLine("hi2");

}


foo1();
await foo2();
