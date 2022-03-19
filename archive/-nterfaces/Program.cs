using System;
namespace ınterfaces
{
    class program
    {
        static void Main(string[] args)
        {
            // interface -> arayüz
            // genelde I ile gösterilir
            // genelde DB veya loglama için yapılır 
            FıleLogger fileLogger1 = new FıleLogger();
            fileLogger1.WriteLog();
            
            DatabaseLogger databaseLogger1 = new DatabaseLogger();
            databaseLogger1.WriteLog();

            SmsLogger smsLogger1 = new SmsLogger();
            smsLogger1.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();


        }
    }
}