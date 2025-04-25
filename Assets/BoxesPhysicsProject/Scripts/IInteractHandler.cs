public interface IInteractHandler
{
    bool IsTaken { get; }

    void Take(IInteractable item);

    void Use();

    void Drop();
}
