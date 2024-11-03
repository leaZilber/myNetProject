using WebApplication1.classes;
namespace WebApplication1.servies
{
    public class HouseCommitteeServies
    {
        static List<HouseCommittee> HouseCommitteeList = new List<HouseCommittee>();
        public HouseCommittee GetHouseCommByid(string phone)//שליפת הודעה עפ"י כותרת
        {
            HouseCommittee h = HouseCommitteeList.Where(te => te.PhoneHouseCommittee == phone).FirstOrDefault();
            if (h == null)
                return null;
            return h;
        }

        public void AddHouseCommittee(HouseCommittee House)//הוספת וועד בית
        {
            HouseCommitteeList.Add(House);
        }
       
        public void UpDateHouse(string phone, HouseCommittee newHouse)//עדכון וועד בית
        {
            foreach (HouseCommittee item in HouseCommitteeList)
            {
                if (!HouseCommitteeList.Contains(newHouse) && item.PhoneHouseCommittee == phone)
                {
                    HouseCommitteeList.Add(newHouse);
                }
            }
        }
        public void DeleteHouse(string phone)//מחיקת וועד בית
        {
            HouseCommitteeList.RemoveAll(match => match.PhoneHouseCommittee == phone);
        }
    }
}
