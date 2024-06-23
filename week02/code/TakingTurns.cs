public static class TakingTurns {
    public static void Test() {
        // Test 1
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        RunTurns(players, 10);
        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        RunTurns(players, 5);
        players.AddPerson("George", 3);
        RunTurns(players, 8);
        Console.WriteLine("---------");

        // Test 3
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0); // Forever
        players.AddPerson("Sue", 3);
        RunTurns(players, 10);
        Console.WriteLine("---------");

        // Test 4
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3); // Forever
        players.AddPerson("Sue", 3);
        RunTurns(players, 10);
        Console.WriteLine("---------");

        // Test 5
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson(); // Empty queue
        Console.WriteLine("---------");
    }

    private static void RunTurns(TakingTurnsQueue players, int turns) {
        for (int i = 0; i < turns; i++) {
            players.GetNextPerson();
        }
    }
}
