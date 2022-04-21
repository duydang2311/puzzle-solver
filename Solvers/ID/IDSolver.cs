namespace Puzzle.Solvers.ID;

using Puzzle.States;
using Puzzle.Boards;
using Puzzle.Directions;

public class IDSolver : Solver
{
	public uint Depth { get; set; } = 1;
	public IDSolver(State goal) : base(goal) { }
	private State? DFSHelper(Stack<State> stack, Queue<State> queue, HashSet<Board> visited)
	{
		State state;
		State? child;
		var directions = Enum.GetValues(typeof(Direction));
		while (stack.Count > 0)
		{
			state = stack.Pop();
			if (state.Board.Equals(Goal.Board))
			{
				return state;
			}
			if (state.Depth == Depth)
			{
				queue.Enqueue(state);
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
		return null;
	}
	private State? BFSHelper(Queue<State> queue, HashSet<Board> visited)
	{
		State state;
		State? child;
		var directions = Enum.GetValues(typeof(Direction));
		while (queue.Count > 0)
		{
			state = queue.Dequeue();
			if (state.Board.Equals(Goal.Board))
			{
				return state;
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
		return null;
	}
	public override void Solve(State state)
	{
		var visited = new HashSet<Board>();
		var stack = new Stack<State>();
		var queue = new Queue<State>();
		State? goal;
		stack.Push(state);
		visited.Add(state.Board);
		goal = DFSHelper(stack, queue, visited);
		if (goal is null)
		{
			Console.WriteLine("Switch to BFS.");
			goal = BFSHelper(queue, visited);
		}
		if (goal is null)
		{
			Console.WriteLine("Unable to find goal state.");
			return;
		}
		Console.WriteLine("Goal found!");
		goal.PrintTrace();
	}
}

