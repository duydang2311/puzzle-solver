namespace Puzzle.Solvers;

using Puzzle.States;

public abstract class Solver
{
	public State Goal { get; }
	public Solver(State goal)
	{
		Goal = goal;
	}
	public abstract void Solve(State initial);
}
