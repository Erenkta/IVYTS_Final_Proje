﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace VYTSFinalProje.Module.BusinessObjects
{
    [NavigationItem("Target")]
    public class Y_Test : BaseObject
    {
        public virtual float Selling_Price { get; set; }
    }
}