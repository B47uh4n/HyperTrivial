using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private Vector3 maxPosition;
    [SerializeField] [Range(0,1)]private float progress;

    private void Awake()
    {
        transform.localPosition = initialPosition;
    }

    private void LateUpdate() //lateupdate kamera kontrolunde daha smooth oluyor.
    {
        transform.localPosition = Vector3.Lerp(initialPosition, maxPosition, progress);
    }
}
