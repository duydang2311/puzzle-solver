namespace Puzzle.States;

using Puzzle.Boards;

public partial class State : IEquatable<State>
{
	public Board Board { get; }
	public State? Parent { get; set; }
	public uint Depth { get; }

	public State(Board board, State? parent = null)
	{
		Board = board;
		Parent = parent;
		Depth = 1;
		if (Parent is not null)
		{
			Depth = Parent.Depth + 1;
		}
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
	public void PrintTrace()
	{
		var state = this;
		while (state is not null)
		{
			foreach (var i in state.Board.Matrix)
			{
				Console.Write(i + ' '.ToString());
			}
			Console.WriteLine($" (Depth {state.Depth})");
			state = state.Parent;
		}
	}
}
