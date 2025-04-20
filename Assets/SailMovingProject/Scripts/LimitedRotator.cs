using UnityEngine;

public class LimitedRotator : Rotator
{
    [SerializeField] private float _maxRotationAngle = 90;
    [SerializeField] private float _minRotationAngle = -90;

    private float rotationY;

    private void Start()
    {
        rotationY = transform.eulerAngles.y;
    }

    protected override void Rotate(float speed)
    {
        rotationY = Mathf.Clamp(rotationY + speed * Time.deltaTime, _minRotationAngle, _maxRotationAngle);

        transform.localRotation = Quaternion.Euler(transform.rotation.x, rotationY, transform.rotation.z);
    }
}
