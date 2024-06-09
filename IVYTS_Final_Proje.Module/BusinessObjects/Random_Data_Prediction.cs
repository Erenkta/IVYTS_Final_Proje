using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace IVYTS_Final_Proje.Module.BusinessObjects
{
    [NavigationItem("RandomData")]
    public class Random_Data_Prediction : BaseObject
    {
        public virtual float Selling_Price { get; set; }
    }
}
