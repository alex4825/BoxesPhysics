using UnityEngine;

public class ShipMover : MonoBehaviour
{
    [SerializeField] private Wind _wind;
    [SerializeField] private Transform _sail;

    private void Update()
    {
        float directionKoefficient = Vector3.Dot(_wind.Direction, _sail.forward);

        if (directionKoefficient > 0)
            transform.Translate(transform.forward * directionKoefficient * _wind.Speed * Time.deltaTime, Space.World);
    }
}
