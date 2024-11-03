namespace WebApplication1.classes
{
    public class Tenant
    {
        public string FamilyName { get; set; }//שם משפחה
        public string FirstName { get; set; }//שם פרטי
        public int ApartmentNumber { get; set; }// מספר דירה
        public int AmounPayments { get; set; }//כמות תשלומים
        public string MailTenant { get; set; }//מייל הדייר
        public string PhoneTenant { get; set; }//טלפון הדייר
        public string CodeTenant { get; set; }

        public Tenant(string familyName, string firstName, int apartmentNumber, int amounPayments, string mailTenant, string phoneTenant, string codeTenant)
        {
            FamilyName = familyName;
            FirstName = firstName;
            ApartmentNumber = apartmentNumber;
            AmounPayments = amounPayments;
            MailTenant = mailTenant;
            PhoneTenant = phoneTenant;
            CodeTenant = codeTenant;
        }

        public Tenant()
        {

        }
    }
}
