namespace WebApplication1.classes
{
    public class HouseCommittee//וועד בית
    {
        public string FamilyHouseCommittee { get; set; }//שם משפחה
        public string FirstHouseCommittee { get; set; }//שם פרטי
        public string MailHouseCommittee { get; set; }//מייל וועד הבית
        public string PhoneHouseCommittee { get; set; }//טלפון וועד הבית

        public HouseCommittee(string familyHouseCommittee, string firstHouseCommittee, string mailHouseCommittee, string phoneHouseCommittee)
        {
            FamilyHouseCommittee = familyHouseCommittee;
            FirstHouseCommittee = firstHouseCommittee;
            MailHouseCommittee = mailHouseCommittee;
            PhoneHouseCommittee = phoneHouseCommittee;
        }
        public HouseCommittee()
        {

        }
    }
}
