namespace _02_Dispositivo.Models
{
    //essa linha é responsavel por herdar o dispositivo
    public class Computador : DispositivoEletronico
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRam { get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo {Modelo}, Ano {AnoFabricacao}, SO: {SistemaOperacional}";
        }
    }
}
