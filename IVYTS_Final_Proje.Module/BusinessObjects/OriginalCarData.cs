using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace IVYTS_Final_Proje.Module.BusinessObjects
{
    [NavigationItem("Data")]
    public class OriginalCarData : BaseObject
    {
        public virtual String Car_Name { get; set; }
        public virtual int Year { get; set; }
        public virtual float Selling_Price { get; set; }
        public virtual float Present_Price { get; set; }
        public virtual float Kms_Driven { get; set; }
        public virtual String Fuel_Type { get; set; }
        public virtual String Seller_Type { get; set; }
        public virtual String Transmission { get; set; }
        public virtual int Owner { get; set; }

    }
}
