using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDirection : MonoBehaviour
{
    [SerializeField] Vector2 viewportPos = new Vector2(0.9f, 0.1f);
    [SerializeField] float distanceFromCamera = 10f; // любое удобное значение между near и far

    void LateUpdate()
    {
        // задаём точку в вьюпорте: x=0–1 (0.9≈право), y=0–1 (0.1≈низ), z=расстояние
        Vector3 vp = new Vector3(viewportPos.x, viewportPos.y, distanceFromCamera);
        // переводим в мировые координаты и ставим стрелку туда:
        transform.position = Camera.main.ViewportToWorldPoint(vp);
    }
}
