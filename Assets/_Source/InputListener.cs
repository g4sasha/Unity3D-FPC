using UnityEngine;

public class InputListener : MonoBehaviour
{
	[SerializeField] private InputManager _inputManager;
	private PlayerInvoker _playerInvoker;

	public void Construct(PlayerInvoker playerInvoker)
    {
        _playerInvoker = playerInvoker;
    }

	private void Update()
	{
		if (!_inputManager.IsInputEnabled)
		{
			return;
		}
		
		ReadMovement();
		ReadJump();
	}

	private void ReadMovement()
	{
		var moveX = Input.GetAxis("Horizontal");
		var moveZ = Input.GetAxis("Vertical");

		if (moveX != 0 || moveZ != 0)
		{
			_playerInvoker.Move(moveX, moveZ);
		}
	}

    private void ReadJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			_playerInvoker.Jump();
		}
    }
}