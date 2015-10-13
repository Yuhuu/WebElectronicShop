namespace WebElectronicShop
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public class Customer
  {
    public int id { get; set; }
    public string navn { get; set; }
    public string adresse { get; set; }

}
  public partial class DbModel : DbContext
  {
    public DbModel()
        : base("name=DbModel")
    {
    }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
    }
  }
}
