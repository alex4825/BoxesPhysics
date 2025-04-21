using UnityEngine;
using Cinemachine;

public class AlignerFromOtherVirtualCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _thisCamera;
    [SerializeField] private CinemachineVirtualCamera _otherCamera;

    private Vector3 _initialThisCameraOffset;
    private Vector3 _initialOtherCameraOffset;

    private void Start()
    {
        _initialThisCameraOffset = _thisCamera.
    }

    private void LateUpdate()
    {
        
    }
}
