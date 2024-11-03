namespace WebApplication1.classes
{
    public class Message
    {
        public string Title { get; set; }//כותרת ההודעה
        public string Body { get; set; }//גוף ההודעה
        public DateTime DateTimeMessage { get; set; }//תאריך שליחת ההודעה
        public string target {  get; set; }
        public Message()
        {

        }
        public Message(string title, string body, DateTime dateTimeMessage, string target)
        {
            Title = title;
            Body = body;
            DateTimeMessage = dateTimeMessage;
            this.target = target;
        }
    }
}
