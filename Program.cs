using Puzzle.Boards;
using Puzzle.States;
using Puzzle.Solvers.BFS;
using Puzzle.Solvers.DFS;
using Puzzle.Solvers.ID;

new BFSSolver(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 5},
			{2, 0, 6},
			{1, 8, 7}
		})
	)
).Solve(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 5},
			{2, 6, 7},
			{0, 1, 8}
		})
	)
);

new DFSSolver(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 5},
			{2, 0, 6},
			{1, 8, 7}
		})
	)
)
{ Depth = 7 }.Solve(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 0},
			{2, 6, 5},
			{1, 8, 7}
		})
	)
);

new IDSolver(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 5},
			{2, 0, 6},
			{1, 8, 7}
		})
	)
)
{ Depth = 7 }.Solve(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 0},
			{2, 6, 5},
			{1, 8, 7}
		})
	)
);
