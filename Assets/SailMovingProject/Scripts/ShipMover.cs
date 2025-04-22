using UnityEngine;

public class ShipMover : MonoBehaviour
{
    [SerializeField] private Wind _wind;
    [SerializeField] private Transform _sail;

    private void Update()
    {
        float windSailAlignmentKoefficient = Vector3.Dot(_wind.Direction, _sail.forward);
        float shipSailAlignmentKoefficient = Vector3.Dot(transform.forward, _sail.forward);

        if (windSailAlignmentKoefficient > 0)
            transform.Translate(transform.forward * shipSailAlignmentKoefficient * windSailAlignmentKoefficient * _wind.Speed * Time.deltaTime, Space.World);
    }
}
