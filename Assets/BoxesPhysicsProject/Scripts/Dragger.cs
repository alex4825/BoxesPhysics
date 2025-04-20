using UnityEngine;

public class Dragger : MonoBehaviour, IDraggable
{
    [SerializeField] private LayerMask _groundLayerMask;
    [SerializeField] private LayerMask _grabbedLayerMask;

    private const int LeftMouseButton = 0;

    private Vector3 _dragOffset = new(0, 1, 0);
    private Transform _currentTarget;

    public bool IsDragging { get; private set; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) && Raycaster.TryGetGrabbed(_grabbedLayerMask, out Transform grabbedTransform))
            Grab(grabbedTransform);

        if (IsDragging)
        {
            Drag();
        }

        if (Input.GetMouseButtonUp(LeftMouseButton))
            Drop();
    }

    public void Grab(Transform target)
    {
        IsDragging = true;
        _currentTarget = target;
    }

    public void Drag()
    {
        Vector3 raycastPoint = Raycaster.GetCursorRaycastPoint(_groundLayerMask);
        _currentTarget.position = raycastPoint + _dragOffset;
    }

    public void Drop()
    {
        if (IsDragging)
        {
            IsDragging = false;
            _currentTarget = null;
        }
    }
}
