using dars5.Models;

namespace dars5.Services;

internal class SingerService : ISingerService
{
    List<Singer> Singers;
    public SingerService()
    {
        Singers = new List<Singer>();
    }
    public Guid AddSinger(Singer singer)
    {
        singer.SingerId = Guid.NewGuid();
        Singers.Add(singer);
        return singer.SingerId;
    }

    public bool DeleteSinger(Guid singerId)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                Singers.Remove(singer);
                return true;
            }
        }
        return false;
    }

    public List<Singer> GetAllSingers()
    {
        return Singers;
    }

    public Singer? GetSingerById(Guid singerId)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                return singer;
            }
        }
        return null;
    }

    public bool UpdateSinger(Singer newsinger)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == newsinger.SingerId)
            {
                singer.SingerAge = newsinger.SingerAge;
                singer.FirstName = newsinger.FirstName;
                singer.LastName = newsinger.LastName;
                return true;
            }
        }
        return false;
    }
}
