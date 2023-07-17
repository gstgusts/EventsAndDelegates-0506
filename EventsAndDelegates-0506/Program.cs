namespace EventsAndDelegates_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.OnCreated += EmailService.Send;
            order.OnCreated += SmsService.Send;
            order.OnCreated += ExternalApiService.Send;

            order.Create();

            order.OnCreated -= EmailService.Send;

            order.Create();
        }

       
    }
}