using UnityEngine;

public class InputListener : MonoBehaviour
{
	[SerializeField] private InputSwitcher _inputManager;
	[SerializeField] private Player _player;
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
		ReadShot();
	}

    private void ReadShot()
    {
        if (Input.GetMouseButtonDown(0))
		{
			_playerInvoker.Attack();
		}
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
        if (Input.GetKeyDown(KeyCode.Space) && _player.Gc.IsGrounded)
		{
			_playerInvoker.Jump();
		}
    }
}