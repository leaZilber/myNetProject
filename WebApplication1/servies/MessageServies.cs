using System.Linq;
using WebApplication1.classes;

namespace WebApplication1.servies
{
    public class MessageServies
    {
        static List<Message> MessagesList = new List<Message>();
        public Message GetMessageByid(string Title)//שליפת הודעה עפ"י כותרת
        {
            Message m = MessagesList.Where(te => te.Title == Title).FirstOrDefault();
            if (m == null)
                return null;
            return m;
        }
        public void AddMessages(Message mes)//הוספת הודעה
        {
            MessagesList.Add(mes);
        }

        public void DeleteMessages(string title, string target)//מחיקת הודעה
        {
            MessagesList.RemoveAll(item => item.target == target&&item.Title==title);

        }
        public void UpDateMessage(string target,string title, Message newMes)//עדכון פרטי הודעה
        {
            foreach (Message item in MessagesList)
            {
                if (item.Title==title && item.target==target)
                {
                    MessagesList.Add(newMes);
                }
            }

        }
    }
}
