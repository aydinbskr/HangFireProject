using Hangfire;

namespace HangFireProject.MyHangFire
{
    public class MyHangFire
    {
        public static void MyTxtJobs(string msg)
        {
            //Hangfire.BackgroundJob.Enqueue<ITxtSender>(a => a.Sender(msg));
            
            //var jobId=Hangfire.BackgroundJob.Schedule<ITxtSender>(a => a.Sender("Schedule "),System.TimeSpan.FromSeconds(15));
            //Hangfire.BackgroundJob.ContinueJobWith<ITxtSender>(jobId,a => a.Sender("ContinueJobWith "));

            Hangfire.RecurringJob.AddOrUpdate<ITxtSender>("Recurring ID", a => a.Sender("RECURRING ID "),Cron.Daily());
        }
    }
}
