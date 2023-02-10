namespace NET_Angular.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureFileName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>(); 
    }
}
