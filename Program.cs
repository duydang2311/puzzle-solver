using Puzzle.Boards;
using Puzzle.States;
using Puzzle.Solvers.BFS;
using Puzzle.Solvers.DFS;

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
).Solve(
	new State(
		new Board(new byte[3, 3] {
			{3, 4, 5},
			{2, 6, 0},
			{1, 8, 7}
		})
	)
);
