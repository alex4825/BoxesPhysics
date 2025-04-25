using UnityEngine;

public class Exploder : IShootHandler
{
    private LayerMask _interactableMask;
    private float _explosionRadius = 3;
    private float _explosionForce = 5;
    private ParticleSystem _explosionEffectPrefab;

    public Exploder(LayerMask interactableMask, ParticleSystem explosionEffectPrefab)
    {
        _interactableMask = interactableMask;
        _explosionEffectPrefab = explosionEffectPrefab;
    }

    public void ShootIn(Vector3 point)
    {
        Collider[] colliders = Physics.OverlapSphere(point, _explosionRadius, _interactableMask);

        foreach (Collider collider in colliders)
        {
            Rigidbody colliderRigidbody = collider.GetComponent<Rigidbody>();

            colliderRigidbody.AddForce(GetDirection(point, collider.transform.position) * _explosionForce, ForceMode.Impulse);
        }

        PlayEffectIn(point);
    }

    private void PlayEffectIn(Vector3 point)
        => Object.Instantiate(_explosionEffectPrefab, point, Quaternion.identity);

    private Vector3 GetDirection(Vector3 fromPoint, Vector3 toPoint)
        => (toPoint - fromPoint).normalized;
}
