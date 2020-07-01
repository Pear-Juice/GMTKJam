using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public Vector3 positionOffset;
    [Range(0f, 1f)] public float smoothTime;
    public float sensitivity;

    private void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position, target.position + positionOffset, smoothTime);
        transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
    }
}
