namespace Puzzle.Boards;

using Puzzle.Directions;

public partial class Board : IEquatable<Board>
{
	private static void Swap(byte[,] matrix, (byte, byte) coord1, (byte, byte) coord2)
	{
		(matrix[coord2.Item1, coord2.Item2], matrix[coord1.Item1, coord1.Item2]) = (matrix[coord1.Item1, coord1.Item2], matrix[coord2.Item1, coord2.Item2]);
	}
	public Board? Move(Direction direction)
	{
		Board? board = null;
		if (direction == Direction.Up)
		{
			if (zeroCoords.Item1 != 0)
			{
				board = new Board((byte[,])Matrix.Clone());
				Swap(board.Matrix, (zeroCoords.Item1, zeroCoords.Item2), ((byte)(zeroCoords.Item1 - 1), zeroCoords.Item2));
			}
		}
		else if (direction == Direction.Down)
		{
			if (zeroCoords.Item1 != Size - 1)
			{
				board = new Board((byte[,])Matrix.Clone());
				Swap(board.Matrix, (zeroCoords.Item1, zeroCoords.Item2), ((byte)(zeroCoords.Item1 + 1), zeroCoords.Item2));
			}
		}
		else if (direction == Direction.Left)
		{
			if (zeroCoords.Item2 != 0)
			{
				board = new Board((byte[,])Matrix.Clone());
				Swap(board.Matrix, (zeroCoords.Item1, zeroCoords.Item2), (zeroCoords.Item1, (byte)(zeroCoords.Item2 - 1)));
			}
		}
		if (direction == Direction.Right)
		{
			if (zeroCoords.Item2 != Size - 1)
			{
				board = new Board((byte[,])Matrix.Clone());
				Swap(board.Matrix, (zeroCoords.Item1, zeroCoords.Item2), (zeroCoords.Item1, (byte)(zeroCoords.Item2 + 1)));
			}
		}
		return board;
	}
}
