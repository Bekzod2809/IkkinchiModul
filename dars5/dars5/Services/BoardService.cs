using dars5.Models;

namespace dars5.Services;

internal class BoardService : IBoardService
{
    List<Board> Boards;
    public BoardService()
    {
        Boards = new List<Board>();
    }
    public Guid AddBoard(Board board)
    {
        board.BoardId = Guid.NewGuid();
        Boards.Add(board);
        return board.BoardId;
    }

    public bool DeleteBoard(Guid boardId)
    {
        foreach (var board in Boards)
        {
            if (board.BoardId == boardId)
            {
                Boards.Remove(board);
                return true;
            }
        }
        return false;
    }

    public List<Board> GetAllBoards()
    {
        return Boards;
    }

    public Board? GetBoardById(Guid boardId)
    {
        foreach (var board in Boards)
        {
            if (board.BoardId == boardId)
            {
                return board;
            }
        }
        return null;
    }

    public bool UpdateBoard(Board newboard)
    {
        foreach (var board in Boards)
        {
            if (board.BoardId == newboard.BoardId)
            {
                board.Price = newboard.Price;
                board.Color = newboard.Color;
                board.Razmer = newboard.Razmer;
                return true;
            }
        }
        return false;
    }
}
