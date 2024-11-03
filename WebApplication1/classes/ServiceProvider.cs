using System.ComponentModel;
using WebApplication1.classes;
namespace WebApplication1.servies
{
    public enum ETypeService
    {
        elevator,
        electricity,
        water,
        cleanliness,
        other
    }
    public class ServiceProvider//נותן שירות
    {
        public string NameServiceProvider { get; set; }//שם נותן השירות
        public string PhoneProvider { get; set; }//טלפון נותן השירות

        public string MailProviderName { get; set; }// מייל נותן השירות
        public int Price { get; set; }//מחיר
        public DateTime dateService { get; set; }//תאריך השירות

        public ETypeService typeService { get; set; }//סוג השירות

        public ServiceProvider(string nameServiceProvider, string phoneProvider, string mailProviderName, int price, DateTime dateService, ETypeService typeService)
        {
            NameServiceProvider = nameServiceProvider;
            PhoneProvider = phoneProvider;
            MailProviderName = mailProviderName;
            Price = price;
            this.dateService = dateService;
            this.typeService = typeService;
        }

        public ServiceProvider()
        {

        }
    }

}
