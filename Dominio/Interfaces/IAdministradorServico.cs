using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    void Incluir(Administrador administrador);
    List<Administrador> Todos(int? pagina = 1);
    Administrador? BuscaPorId(int id);
}
