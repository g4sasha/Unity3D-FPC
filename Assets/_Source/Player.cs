using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [field: SerializeField] public float JumpForce { get; private set; }
}