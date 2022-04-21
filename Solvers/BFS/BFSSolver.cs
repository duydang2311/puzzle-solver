namespace Puzzle.Solvers.BFS;

using Puzzle.States;
using Puzzle.Boards;
using Puzzle.Directions;

public class BFSSolver : Solver
{
	public BFSSolver(State goal) : base(goal) { }
	public override void Solve(State state)
	{
		var visited = new HashSet<Board>();
		var queue = new Queue<State>();
		var directions = Enum.GetValues(typeof(Direction));
		State? child;

		queue.Enqueue(state);
		visited.Add(state.Board);
		while (queue.Count > 0)
		{
			state = queue.Dequeue();
			if (state.Board.Equals(Goal.Board))
			{
				Console.WriteLine($"Goal state found! {visited.Count} states visited.");
				state.PrintTrace();
				break;
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
				queue.Enqueue(child);
				visited.Add(child.Board);
			}
		}
	}
}

