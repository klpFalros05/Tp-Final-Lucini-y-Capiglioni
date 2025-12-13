namespace Entidades
{
    public abstract class Cliente
    {   
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
    }
}
