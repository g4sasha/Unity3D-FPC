using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	[SerializeField] private LayerMask _groundLayer;
	[SerializeField] private float _sphereRadius;

    public bool IsGrounded
    {
        get
        {
            return Physics.CheckSphere(transform.position, _sphereRadius, _groundLayer);
        }
    }
}