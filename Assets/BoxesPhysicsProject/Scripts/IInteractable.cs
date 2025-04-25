using UnityEngine;

public interface IInteractable 
{
    public Transform Transform { get; }

    public void OnGrab();

    public void OnRelease();
}
