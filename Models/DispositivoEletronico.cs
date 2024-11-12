namespace _02_Dispositivo.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; } //é um método 
        public abstract string ExibirDetalhes();

    }
}
