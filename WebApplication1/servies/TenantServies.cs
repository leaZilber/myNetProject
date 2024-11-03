using WebApplication1.classes;

namespace WebApplication1.servies
{
    public class TenantServies
    {
        static List<Tenant> tenantsList = new List<Tenant>();
        public Tenant GetTenantByid(string id)//שליפת דייר עפ"י קוד
        {
            Tenant t = tenantsList.Where(te => te.CodeTenant == id).FirstOrDefault();
            if (t == null)
                return null;

            return t;
        }
        public void AddTenant(Tenant tenant)//הוספת דייר
        {
            tenantsList.Add(tenant);
        }

        public void DeleteTenant(string id)//מחיקת דייר
        {
            tenantsList.RemoveAll(te => te.CodeTenant == id);
        }
        public void UpDateTenant(Tenant newTen, string id)//עדכון פרטי דייר
        {
            foreach (var t in tenantsList)
            {
                if (t.CodeTenant == id)
                {
                    tenantsList.Add(t);
                }
            }
        }
    }
}