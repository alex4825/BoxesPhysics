using UnityEngine;

public class Box : MonoBehaviour, IIteractable
{
    [SerializeField] private Rigidbody _rigidbody;

    public Transform Transform => transform;

    public void OnGrab()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    public void OnRelease()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
