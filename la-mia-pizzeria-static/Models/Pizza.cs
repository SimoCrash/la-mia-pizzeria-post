namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id {  get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descrizione { get; set; } = string.Empty;
        public string Foto { get; set; } = string.Empty;
        public string Prezzo { get; set; } = string.Empty;
    }
}
