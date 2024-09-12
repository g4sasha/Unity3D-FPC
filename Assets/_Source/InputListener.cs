using UnityEngine;

public class InputListener : MonoBehaviour
{
	[SerializeField] private float _mouseSensitivity;
	[SerializeField] private InputSwitcher _inputManager;
	[SerializeField] private Player _player;
	[SerializeField] private CameraRotate _cameraRotate;
	private PlayerInvoker _playerInvoker;
	private float _horizontalMousePosition;

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
		ReadMousePosition();
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

	private void ReadMousePosition()
	{
		_horizontalMousePosition += Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
		_cameraRotate.Rotate(_horizontalMousePosition);
		_playerInvoker.Rotate();
	}
}