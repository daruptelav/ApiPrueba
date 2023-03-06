namespace ApiPrueba.Model
{
    public class EntriesResult
    {
        public EntriesResult() {
            
            entries = new List<Entries>();
        }

        public int count { get; set; }

        public List<Entries> entries  { get; set; }
    }
}
