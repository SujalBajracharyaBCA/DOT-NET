using System;

namespace Lab7d
{
    public class AlarmClock
    {
        public event EventHandler Alarm;
        public void TriggerAlarm()
        {
            Console.WriteLine("AlarmClock: Alarm is triggered!");
            Alarm?.Invoke(this, EventArgs.Empty);
        }
    }

    public class AlarmSubscriber
    {
        private string subscriberName;
        public AlarmSubscriber(string name)
        {
            subscriberName = name;
        }

        public void OnAlarmTriggered(object sender, EventArgs e)
        {
            Console.WriteLine($"{subscriberName} received the alarm notification.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            AlarmSubscriber subscriber = new AlarmSubscriber("Subscriber 1");
            alarmClock.Alarm += subscriber.OnAlarmTriggered;
            alarmClock.TriggerAlarm();
            alarmClock.Alarm -= subscriber.OnAlarmTriggered;
            alarmClock.TriggerAlarm();
        }
    }
}
