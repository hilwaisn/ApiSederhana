namespace ApiSederhana.Models
{
    public class Personal
    {
        public int Umur { get; set; }
        public string Name { get; set; }
        //public string Alamat { get; set; }
        public Alamat Address { get; set; }
        public List<string> Skill { get; set; }
    }
}
