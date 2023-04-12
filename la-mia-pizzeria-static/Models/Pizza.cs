
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserisci il Nome della pizza che vuoi aggiungere.")]
        [StringLength(100, ErrorMessage = "Puoi inserire fino a un massimo di 100 caratteri")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Inserisci la Descrizione della pizza che vuoi aggiungere.")]
        public string Descrizione { get; set; } = string.Empty;

        public string? Foto { get; set; } = string.Empty;

        [Required(ErrorMessage = "Inserisci il Prezzo della pizza che vuoi aggiungere.")]
        public string Prezzo { get; set; } = string.Empty;
    }
}