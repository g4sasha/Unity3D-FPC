using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _distance = 5.0f;

    private float _currentAngle = 0f;

    public void Rotate(float horizontalInput)
    {
        _currentAngle = horizontalInput;
        Vector3 offset = new Vector3(0f, 0f, -_distance);
        Quaternion rotation = Quaternion.Euler(15f, _currentAngle, 0f);
        transform.position = _target.position + rotation * offset + new Vector3(0f, 3f, 0f);
        transform.LookAt(_target);
    }
}