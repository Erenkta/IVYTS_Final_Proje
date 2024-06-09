using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;


namespace IVYTS_Final_Proje.Module.BusinessObjects
{
    [NavigationItem("RandomData")]
    public class Random_Data : BaseObject
    {
        public virtual int Year { get; set; }
        public virtual float Present_Price { get; set; }
        public virtual float Kms_Driven { get; set; }
        public virtual int Owner { get; set; }
        public virtual bool Fuel_Type_Diesel { get; set; }
        public virtual bool Fuel_Type_Petrol { get; set; }
        public virtual bool Seller_Type_Individual { get; set; }
        public virtual bool Transmission_Manual { get; set; }
    }
}
