namespace GerenciamentoDeEletrodomesticos_MVC.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo Energético: {ConsumoEnergetico}, Tamanho de Tela: {TamanhoTela}, É Smart: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
