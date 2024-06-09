using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace IVYTS_Final_Proje.Module.BusinessObjects
{
    [NavigationItem("RandomData")]
    public class Random_Data_Scaled : BaseObject
    {
        public virtual float Year { get; set; }
        public virtual float Present_Price { get; set; }
        public virtual float Kms_Driven { get; set; }
        public virtual float Owner { get; set; }
        public virtual float Fuel_Type_Diesel { get; set; }
        public virtual float Fuel_Type_Petrol { get; set; }
        public virtual float Seller_Type_Individual { get; set; }
        public virtual float Transmission_Manual { get; set; }
    }
}
