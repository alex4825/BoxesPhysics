public interface IInteractHandler
{
    bool IsTaken { get; }

    void Take(IIteractable item);

    void Use();

    void Drop();
}
