namespace Lab.Dominio.ServicoUsandoRepositorio;

public class ServicoComRepo
{
    private readonly IServicoComRepoRepositorio repositorio;

    public ServicoComRepo(IServicoComRepoRepositorio repositorio) => this.repositorio = repositorio;

    public int Operacao(int id) => repositorio.Obter(id);
}