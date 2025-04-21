using UnityEngine;

public class ArrowPointer : MonoBehaviour
{
    [SerializeField] private Wind _wind;
    [SerializeField] private float _rotationSpeed = 2f;

    void LateUpdate()
    {
        Quaternion targetRotation = Quaternion.LookRotation(_wind.Direction.normalized, Vector3.up);
        
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            _rotationSpeed * Time.deltaTime
        );
    }
}
