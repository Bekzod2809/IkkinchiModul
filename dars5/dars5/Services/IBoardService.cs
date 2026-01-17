using dars5.Models;

namespace dars5.Services;

public interface IBoardService
{
    public Guid AddBoard(Board board);
    public bool UpdateBoard(Board board);
    public bool DeleteBoard(Guid boardId);
    public Board? GetBoardById(Guid boardId);
    public List<Board> GetAllBoards();

}
