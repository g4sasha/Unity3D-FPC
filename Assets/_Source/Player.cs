using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [field: SerializeField] public float JumpForce { get; private set; }
    [field: SerializeField] public GameObject Bullet { get; private set; }
    [field: SerializeField] public Rigidbody Rb { get; private set; }
    [field: SerializeField] public GroundCheck Gc { get; private set; }

    private void OnValidate()
    {
        Rb = GetComponent<Rigidbody>();
        Gc = GetComponentInChildren<GroundCheck>();
    }
}