using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] protected float RotationSpeed = 200;

    [SerializeField] private KeyCode _clockwiseKey = KeyCode.W;
    [SerializeField] private KeyCode _anticlockwiseKey = KeyCode.Q;

    protected void Update()
    {
        if (Input.GetKey(_clockwiseKey))
            Rotate(RotationSpeed);

        if (Input.GetKey(_anticlockwiseKey))
            Rotate(-RotationSpeed);
    }

    protected virtual void Rotate(float speed)
    {
        transform.Rotate(transform.up, speed * Time.deltaTime, Space.World);
    }
}
