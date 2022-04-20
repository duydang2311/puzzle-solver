namespace Puzzle.Solvers.DFS;

using Puzzle.States;
using Puzzle.Boards;
using Puzzle.Directions;

public class DFSSolver : Solver
{
	public uint Depth { get; set; } = 1;
	public DFSSolver(State goal) : base(goal) { }
	public override void Solve(State state)
	{
		var visited = new HashSet<Board>();
		var stack = new Stack<State>();
		var directions = Enum.GetValues(typeof(Direction));
		State? child;

		stack.Push(state);
		visited.Add(state.Board);
		while (stack.Count > 0)
		{
			state = stack.Pop();
			if (state.Board.Equals(Goal.Board))
			{
				Console.Write("Solution: ");
				while (state is not null)
				{
					foreach (var i in state.Board.Matrix)
					{
						Console.Write(i + ' '.ToString());
					}
					state = state.Parent!;
					Console.WriteLine();
				}
				return;
			}
			if (state.Depth == Depth)
			{
				continue;
			}
			foreach (var d in directions)
			{
				child = state.Move((Direction)d);
				if (child is null
				|| visited.Contains(child.Board))
				{
					continue;
				}
				child.Parent = state;
				stack.Push(child);
				visited.Add(child.Board);
			}
		}
		Console.WriteLine($"Unable to find goal state with max depth set to {Depth}.");
	}
}

