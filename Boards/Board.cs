namespace Puzzle.Boards;

public partial class Board : IEquatable<Board>
{
	public const byte Size = 3;
	public byte[,] Matrix { get; }
	private (byte, byte) zeroCoords;
	public Board(byte[,] matrix)
	{
		Matrix = matrix;
		for (byte i = 0; i != Size; ++i)
			for (byte j = 0; j != Size; ++j)
			{
				if (Matrix[i, j] == 0)
				{
					zeroCoords = (i, j);
					break;
				}
			}
	}
	public override bool Equals(object? obj)
	{
		return Equals(obj as Board);
	}
	public bool Equals(Board? board)
	{
		if (board is null)
		{
			return false;
		}
		for (byte i = 0; i != Size; ++i)
			for (byte j = 0; j != Size; ++j)
			{
				if (Matrix[i, j] != board.Matrix[i, j])
				{
					return false;
				}
			}
		return true;
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(Matrix);
	}
}
