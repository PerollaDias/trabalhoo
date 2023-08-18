public class Produto
{
    public string nome { get; set; }
    public string codigo { get; set; }
    public string descricao { get; set; }
    public string valor { get; set; }
    public string quantidade { get; set; }

    public Produto()
    {

    }

    public Produto(string nome, string codigo, string descricao, string valor, string quantidade)
    {
        this.nome = nome;
        this.codigo = codigo;
        this.descricao = descricao;
        this.valor = valor;
        this.quantidade = quantidade;
    }
}