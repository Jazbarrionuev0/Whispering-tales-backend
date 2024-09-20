namespace WhisperingTales.Models
{
    public class iTale
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public iUser User { get; set; } =  new iUser();
        public iCategory Category { get; set; } = new iCategory();
    }
}
