using System.Drawing;
using UnityEngine;

public class Box : MonoBehaviour, IInteractable, IExploding
{
    [SerializeField] private Rigidbody _rigidbody;

    public Transform Transform => transform;

    public void Explode(Vector3 direction, float force)
    {
        _rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }

    public void OnGrab()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    public void OnRelease()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
