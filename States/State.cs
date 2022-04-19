namespace Puzzle.States;

using Puzzle.Boards;

public partial class State : IEquatable<State>
{
	public Board Board { get; }
	public State? Parent { get; set; }

	public State(Board board)
	{
		Board = board;
	}
	public override bool Equals(object? obj)
	{
		return Equals(obj);
	}
	public bool Equals(State? state)
	{
		return
			state is not null &&
			Board.Equals(state.Board);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(Board);
	}
}
