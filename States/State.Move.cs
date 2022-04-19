namespace Puzzle.States;

using Puzzle.Directions;

public partial class State : IEquatable<State>
{
	public State? Move(Direction direction)
	{
		var board = Board.Move(direction);
		return board is null
			? null
			: new State(board);
	}
}
