namespace ApiPrueba.Model
{
    public class Entries
    {
        public  Entries() {

            API = string.Empty;
            Description = string.Empty;
            Auth = string.Empty;
            Cors  = string.Empty;
            Link = string.Empty;
            Category = string.Empty;
        }

        public string API { get; set; }
        
        public string Description { get; set; }  

        public string Auth { get; set; }

        public bool HTTPS { get; set; }
        public string Cors { get; set; }

        public string Link { get; set; }

        public string Category { get; set; }
    }
}
