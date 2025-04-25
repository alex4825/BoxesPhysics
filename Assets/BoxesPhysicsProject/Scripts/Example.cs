using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private ParticleSystem _explosionEffectPrefab;

    private const int LeftMouseButton = 0;
    private const int RightMouseButton = 1;

    private IInteractHandler _dragger;
    private IShootHandler _exploader;

    private void Awake()
    {
        _dragger = new Dragger(_groundMask);
        _exploader = new Exploder(_interactableMask, _explosionEffectPrefab);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) && Raycaster.TryTakeFirstOne(_interactableMask, out IIteractable interactableItem))
            _dragger.Take(interactableItem);

        _dragger.Use();

        if (Input.GetMouseButtonUp(LeftMouseButton))
            _dragger.Drop();

        if (Input.GetMouseButtonDown(RightMouseButton))
        {
            Vector3 clickPoint = Raycaster.GetCursorRaycastPoint(_groundMask);
            _exploader.ShootIn(clickPoint);
        }
    }
}
