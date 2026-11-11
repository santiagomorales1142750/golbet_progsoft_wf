using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match>
{
    // Agregamos el parámetro opcional search
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, string? search = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
}