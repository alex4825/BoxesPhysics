using TMPro;
using UnityEngine;

public class WindSpeedWriter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textSpeed;
    [SerializeField] private Wind _wind;

    private void Update()
    {
        _textSpeed.text = "Wind speed: " + _wind.Speed.ToString(".00") + " m/s";
    }
}
