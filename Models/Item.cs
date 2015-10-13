using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebElectronicShop.Models
{
  public class Item
  {
    public virtual int ItemId { get; set; }
    public virtual int CateId { get; set; }
    public virtual string Title { get; set; }
    public virtual decimal Price { get; set; }
    public virtual string Url { get; set; }

  }
}