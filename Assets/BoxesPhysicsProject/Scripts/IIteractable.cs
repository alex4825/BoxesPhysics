using UnityEngine;

public interface IIteractable 
{
    public Transform Transform { get; }

    public void OnGrab();

    public void OnRelease();
}
