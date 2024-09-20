namespace WhisperingTales.Models
{
    public class iUser
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<iTale>  Tales { get; set; } = [];
    }
}
