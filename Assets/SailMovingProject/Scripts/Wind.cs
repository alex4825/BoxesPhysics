using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField] private float _minSpeed = 5;
    [SerializeField] private float _maxSpeed = 15;
    [SerializeField] private float _changeDirectionTime = 5;

    private float _minRotationAngle = 10;
    private float _maxRotationAngle = 350;
    private float _timer = 0;

    public float Speed { get; private set; }
    public Vector3 Direction { get; private set; }

    private void Start()
    {
        Direction = GetRandomDirectionXZ();
        Speed = GetRandomValue();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _changeDirectionTime)
        {
            _timer = 0;
            Direction = GetRandomDirectionXZ();
            Speed = GetRandomValue();
        }
    }

    private Vector3 GetRandomDirectionXZ()
    {
        Vector3 direction = Vector3.forward;

        float randomAngle = Random.Range(_minRotationAngle, _maxRotationAngle);
        Quaternion turn = Quaternion.Euler(0, randomAngle, 0);

        return turn * direction;
    }

    private float GetRandomValue() => Random.Range(_minSpeed, _maxSpeed);
}
