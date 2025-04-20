using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private KeyCode _clockwiseKey = KeyCode.W;
    [SerializeField] private KeyCode _anticlockwiseKey = KeyCode.Q;
    [SerializeField] private float _rotationSpeed = 200;
    [SerializeField] private float _maxRotationAngle = 90;

    private void Update()
    {
        if (Input.GetKey(_clockwiseKey))
            Rotate(_rotationSpeed);
        
        if (Input.GetKey(_anticlockwiseKey))
            Rotate(-_rotationSpeed);
    }

    private void Rotate(float speed)
    {
        transform.Rotate(transform.up, speed * Time.deltaTime, Space.World);
    }
}
