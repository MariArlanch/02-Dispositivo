namespace _02_Dispositivo.Models
{
    public class Smartphone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo {Modelo}, Ano {AnoFabricacao}, SO: {(Tem5G ? "Sim" : "Não")}";
        }
    }
}
