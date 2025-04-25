using UnityEngine;

public class Dragger : IInteractHandler
{
    private LayerMask _groundMask;

    private Vector3 _dragOffset = new(0, 1, 0);
    private IIteractable _item;

    public Dragger(LayerMask groundMask)
    {
        _groundMask = groundMask;
    }

    public bool IsTaken => _item != null;

    public void Take(IIteractable item)
    {
        _item = item;
        _item.OnGrab();
    }

    public void Use()
    {
        if (IsTaken)
        {
            Vector3 raycastPoint = Raycaster.GetCursorRaycastPoint(_groundMask);
            _item.Transform.position = raycastPoint + _dragOffset;
        }
    }

    public void Drop()
    {
        if (IsTaken)
        {
            _item.OnRelease();
            _item = null;
        }
    }

}
