namespace Seg3.Models
{
    public class AsistenteComicCon
    {
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string TipoEntrada { get; set; } = string.Empty; // Ejemplo: General, VIP, Cosplayer
        public bool ParticipaCosplay { get; set; }
        public string MensajeConfirmacion { get; set; } = string.Empty;
    }
}