using System.ComponentModel;
using WebApplication1.classes;
namespace WebApplication1.servies
{
    public class BuildingServies
    {
        static List<Building> BuildingList = new List<Building>();
        public Building GetBuildingByid(string code)//שליפת בנין עפ"י קוד
        {
            Building b = BuildingList.Where(te => te.codeBuild == code).FirstOrDefault();
            if (b == null)
                return null;
            return b;
        }
        public void AddBuilding(Building newBuild)//הוספת בנין
        {
            BuildingList.Add(newBuild);
        }

        public void DeleteBuilding(string id)//מחיקת בנין
        {
            BuildingList.RemoveAll(item=>item.codeBuild == id);
        }
        public void UpDateBuild(Building newBuild, string id)//עדכון פרטי בנין
        {
            foreach (Building item in BuildingList)
            {
                if (item.codeBuild==id)
                {
                    BuildingList.Add(newBuild);
                }
            }
        }
    }
}
