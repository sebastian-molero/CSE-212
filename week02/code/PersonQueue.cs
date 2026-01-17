/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    // Internal Storage for the Queue
    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person), "Person cannot be null");
        }

        _queue.Add(person);
    }

    /// <summary>
    /// Remove and return the person at the front of the queue
    /// </summary>
    public Person Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    /// <summary>
    /// Check if the queue is empty
    /// </summary>
    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}