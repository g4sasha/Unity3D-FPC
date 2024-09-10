using UnityEngine;

public class InputListener : MonoBehaviour
{
	private PlayerInvoker _playerInvoker;

	public void SetPlayerInvoker(PlayerInvoker playerInvoker)
    {
        _playerInvoker = playerInvoker;
    }

	private void Update()
	{
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