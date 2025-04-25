using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private LayerMask _interactableMask;

    private const int LeftMouseButton = 0;

    private Dragger _dragger;

    private void Awake()
    {
        _dragger = new Dragger(_groundMask);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) && Raycaster.TryTakeFirstOne(_interactableMask, out IIteractable interactableItem))
            _dragger.Take(interactableItem);

        _dragger.Use();

        if (Input.GetMouseButtonUp(LeftMouseButton))
            _dragger.Drop();
    }
}
