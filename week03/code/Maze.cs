using System;
using System.Collections.Generic;

public class Maze {
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<(int, int), bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    public void MoveLeft() {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[0]) {
            _currX--;
            ShowStatus();
        } else {
            Console.WriteLine("Can't go left!");
        }
    }

    public void MoveRight() {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[1]) {
            _currX++;
            ShowStatus();
        } else {
            Console.WriteLine("Can't go right!");
        }
    }

    public void MoveUp() {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[2]) {
            _currY--;
            ShowStatus();
        } else {
            Console.WriteLine("Can't go up!");
        }
    }

    public void MoveDown() {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions[3]) {
            _currY++;
            ShowStatus();
        } else {
            Console.WriteLine("Can't go down!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }

    public static void Main() {
        var mazeMap = new Dictionary<(int, int), bool[]> {
            {(1, 1), new bool[] {false, true, false, true}},
            {(1, 2), new bool[] {false, true, true, false}},
            {(1, 3), new bool[] {false, false, false, false}},
            {(1, 4), new bool[] {false, true, false, true}},
            {(1, 5), new bool[] {false, false, true, true}},
            {(1, 6), new bool[] {false, false, true, false}},
            {(2, 1), new bool[] {true, false, false, true}},
            {(2, 2), new bool[] {true, false, true, true}},
            {(2, 3), new bool[] {false, false, true, true}},
            {(2, 4), new bool[] {true, true, true, false}},
            {(2, 5), new bool[] {false, false, false, false}},
            {(2, 6), new bool[] {false, false, false, false}},
            {(3, 1), new bool[] {false, false, false, false}},
            {(3, 2), new bool[] {false, false, false, false}},
            {(3, 3), new bool[] {false, false, false, false}},
            {(3, 4), new bool[] {true, true, false, true}},
            {(3, 5), new bool[] {false, false, true, true}},
            {(3, 6), new bool[] {false, false, true, false}},
            {(4, 1), new bool[] {false, true, false, false}},
            {(4, 2), new bool[] {false, false, false, false}},
            {(4, 3), new bool[] {false, true, false, true}},
            {(4, 4), new bool[] {true, true, true, false}},
            {(4, 5), new bool[] {false, false, false, false}},
            {(4, 6), new bool[] {false, false, false, false}},
            {(5, 1), new bool[] {true, true, false, true}},
            {(5, 2), new bool[] {false, false, true, true}},
            {(5, 3), new bool[] {true, true, true, true}},
            {(5, 4), new bool[] {true, false, true, true}},
            {(5, 5), new bool[] {false, false, true, true}},
            {(5, 6), new bool[] {false, true, true, false}},
            {(6, 1), new bool[] {true, false, false, false}},
            {(6, 2), new bool[] {false, false, false, false}},
            {(6, 3), new bool[] {true, false, false, false}},
            {(6, 4), new bool[] {false, false, false, false}},
            {(6, 5), new bool[] {false, false, false, false}},
            {(6, 6), new bool[] {true, false, false, false}}
        };

        var maze = new Maze(mazeMap);

        maze.ShowStatus();  // Initial status

        // Example movements
        maze.MoveRight();   // Move right from (1, 1) to (2, 1)
        maze.MoveDown();    // Move down from (2, 1) to (2, 2)
        maze.MoveLeft();    // Move left from (2, 2) to (1, 2)
        maze.MoveUp();      // Move up from (1, 2) to (1, 1)
        maze.MoveLeft();    // This should fail since there's a wall at (1, 1)

        // Show final status
        maze.ShowStatus();  // Should be at (1, 1)
    }
}
