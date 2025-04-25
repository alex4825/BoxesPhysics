using UnityEngine;

public static class Raycaster
{
    public static Vector3 GetCursorRaycastPoint(int layerMask)
    {
        Physics.Raycast(GetPointerRay(), out RaycastHit hit, Mathf.Infinity, layerMask);

        return hit.point;
    }

    public static bool TryTakeFirstOne(LayerMask layerMask, out IInteractable grabbleItem)
    {
        bool isGrabbed = Physics.Raycast(GetPointerRay(), out RaycastHit hit, Mathf.Infinity, layerMask);

        grabbleItem = hit.collider != null ? hit.collider.GetComponent<IInteractable>() : null;

        return isGrabbed;
    }

    private static Ray GetPointerRay() => Camera.main.ScreenPointToRay(Input.mousePosition);
}
