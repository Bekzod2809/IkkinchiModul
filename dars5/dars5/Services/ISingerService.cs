using dars5.Models;

namespace dars5.Services;

internal interface ISingerService
{
    public Guid AddSinger(Singer singer);
    public bool UpdateSinger(Singer singer);

    public List<Singer> GetAllSingers();
    public bool DeleteSinger(Guid singerId);
    public Singer? GetSingerById(Guid singerId);
}
