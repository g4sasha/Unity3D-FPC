using UnityEngine;

public class PlayerMovement
{
    public void Move(Vector3 direction, float speed, Rigidbody rb)
    {
        rb.position += speed * Time.deltaTime * direction;
    }

    public void Jump(float jumpForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Rotate(Vector3 direction, Transform transform)
    {
        transform.rotation = Quaternion.LookRotation(direction);
        transform.Rotate(-45f, 0f, 0f);
    }
}