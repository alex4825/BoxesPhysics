using UnityEngine;

public interface IDraggable
{
    bool IsDragging { get; }

    void Grab(Transform transform);

    void Drag();

    void Drop();

}
