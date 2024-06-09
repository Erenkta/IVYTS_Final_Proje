using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace VYTSFinalProje.Module.BusinessObjects
{
    [NavigationItem("Prediction")]
    public class Trained_Prediction : BaseObject
    {
        public virtual float Selling_Price { get; set; }
    }
}