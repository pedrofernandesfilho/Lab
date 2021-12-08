using Lab.Dominio.ServicoUsandoRepositorio;

namespace Lab.Dados.ServicoUsandoRepositorio;

public class ServicoComRepo : IServicoComRepoRepositorio
{
    public int Obter(int id) => 10 * id;
}