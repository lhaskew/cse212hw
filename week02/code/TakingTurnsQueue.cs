public class TakingTurnsQueue {
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns) {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public void GetNextPerson() {
        if (_people.IsEmpty()) {
            Console.WriteLine("No one in the queue.");
            return;
        }

        var person = _people.Dequeue();

        if (person.Turns > 0 && person.Turns != int.MaxValue) {
            person.Turns--;
            _people.Enqueue(person);
        }
        else if (person.Turns <= 0) {
            _people.Enqueue(person);
        }

        Console.WriteLine(person.Name);
    }

    public override string ToString() {
        return _people.ToString();
    }
}