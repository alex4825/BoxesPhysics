using UnityEngine;

public static class Raycaster
{
    public static Vector3 GetCursorRaycastPoint(int layerMask)
    {
        Physics.Raycast(GetPointerRay(), out RaycastHit hit, Mathf.Infinity, layerMask);

        return hit.point;
    }

    public static bool TryGetGrabbed(LayerMask layerMask, out Transform transform)
    {
        bool isGrabbed = Physics.Raycast(GetPointerRay(), out RaycastHit hit, Mathf.Infinity, layerMask);

        transform = hit.collider != null ? hit.collider.transform : null;

        return isGrabbed;
    }

    private static Ray GetPointerRay() => Camera.main.ScreenPointToRay(Input.mousePosition);
}
