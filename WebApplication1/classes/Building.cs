namespace WebApplication1.classes
{
    public class Building
    {
        public string NameStreet { get; set; }//שם רחוב
        public string NameCity { get; set; }//שם רחוב
        public int NumBuilding { get; set; }// מספר בנין
        public int NumTenants { get; set; }// מספר דיירים
        public int MonthlyPayment { get; set; }
        public List<Tenant> Tenant { get; set; }
        public string codeBuild {  get; set; }
        public List<ServiceProvider> service { get; set; }

        public Building(string nameStreet, string nameCity, int numBuilding, int numTenants, int monthlyPayment, List<Tenant> tenant, string codeBuild, List<ServiceProvider> service)
        {
            NameStreet = nameStreet;
            NameCity = nameCity;
            NumBuilding = numBuilding;
            NumTenants = numTenants;
            MonthlyPayment = monthlyPayment;
            Tenant = tenant;
            this.codeBuild = codeBuild;
            this.service = service;
        }

        public Building()
        {

        }
    }
}
