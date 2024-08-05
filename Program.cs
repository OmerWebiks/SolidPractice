using SolidTest.classes;



EmailSender emailSender = new EmailSender();
SmsSender smsSender = new SmsSender();
PhoneCaller phoneCaller = new PhoneCaller();
NotificationService ns1 = new NotificationService(emailSender);
NotificationService ns2 = new NotificationService(smsSender);
NotificationService ns3 = new NotificationService(PhoneCaller);
try
{
    // 3 valid calls for the 3 notification services
    // get the parameters from the user. (Using Console.ReadLine());
    ns1.Notify("omer@omer.com", "WHere Are You?");
    ns2.Notify("Leizer", "Come Here");

    // 3 invalid calls for the 3 notification services
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}


//async Task foo1()
//{
//    Console.WriteLine("inside foo1 ");
//    await Task.Delay(2000);
//    Console.WriteLine("hi1");
//    await Task.Delay(2000);
//}

//async Task foo2()
//{
//    Console.WriteLine("inside foo2 ");
//    await Task.Delay(3000);
//    Console.WriteLine("hi2");

//}


//foo1();
//await foo2();
