using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private LayerMask _shootedLayerMask;
    [SerializeField] private LayerMask _explodedLayerMask;
    [SerializeField] private float _explosionRadius = 3;
    [SerializeField] private float _explosionForce = 5;

    private const int RightMouseButton = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(RightMouseButton))
        {
            Vector3 clickPoint = Raycaster.GetCursorRaycastPoint(_shootedLayerMask);
            ShootIn(clickPoint);
        }
    }

    private void ShootIn(Vector3 point)
    {
        Collider[] colliders = Physics.OverlapSphere(point, _explosionRadius, _explodedLayerMask);

        foreach (Collider collider in colliders)
        {
            Rigidbody colliderRigidbody = collider.GetComponent<Rigidbody>();

            colliderRigidbody.AddForce(GetDirection(point, collider.transform.position) * _explosionForce, ForceMode.Impulse);
        }
    }

    private Vector3 GetDirection(Vector3 fromPoint, Vector3 toPoint)
        => (toPoint - fromPoint).normalized;
}
