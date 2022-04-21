namespace Puzzle.Solvers.UCS;

using Puzzle.States;
using Puzzle.Boards;
using Puzzle.Directions;

public class UCSSolver : Solver
{
	public uint Depth { get; set; } = 1;
	public UCSSolver(State goal) : base(goal) { }
	public override void Solve(State state)
	{
		var queue = new PriorityQueue<State, int>();
		var visited = new HashSet<Board>();
		var directions = Enum.GetValues(typeof(Direction));
		State? child;
		queue.Enqueue(state, 0);
		while (queue.Count != 0)
		{
			state = queue.Dequeue();
			visited.Add(state.Board);
			if (state.Equals(Goal))
			{
				Console.WriteLine($"Goal state found! {visited.Count} states visited.");
				state.PrintTrace();
				return;
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
				queue.Enqueue(child, (int)child.Depth);
				visited.Add(child.Board);
			}
		}
	}
}

