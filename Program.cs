using Puzzle.Boards;
using Puzzle.States;
using Puzzle.Solvers.BFS;
using Puzzle.Solvers.DFS;
using Puzzle.Solvers.ID;
using Puzzle.Solvers.UCS;

// new BFSSolver(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{0, 8, 7},
// 			{6, 4, 5}
// 		})
// 	)
// ).Solve(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{7, 4, 0},
// 			{8, 5, 6}
// 		})
// 	)
// );

// new DFSSolver(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{0, 8, 7},
// 			{6, 4, 5}
// 		})
// 	)
// )
// { Depth = 11 }.Solve(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{7, 4, 0},
// 			{8, 5, 6}
// 		})
// 	)
// );

// new IDSolver(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{0, 8, 7},
// 			{6, 4, 5}
// 		})
// 	)
// )
// { Depth = 5 }.Solve(
// 	new State(
// 		new Board(new byte[3, 3] {
// 			{1, 2, 3},
// 			{7, 4, 0},
// 			{8, 5, 6}
// 		})
// 	)
// );

new UCSSolver(
	new State(
		new Board(new byte[3, 3] {
			{1, 2, 3},
			{0, 8, 7},
			{6, 4, 5}
		})
	)
).Solve(
	new State(
		new Board(new byte[3, 3] {
			{1, 2, 3},
			{7, 4, 0},
			{8, 5, 6}
		})
	)
);
