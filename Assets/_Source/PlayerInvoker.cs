using UnityEngine;

public class PlayerInvoker
{
	private Player _player;
	private PlayerMovement _playerMovement;

	public PlayerInvoker(Player player, PlayerMovement playerMovement)
	{
		_player = player;
		_playerMovement = playerMovement;
	}

	public void Move(float x, float z)
	{
		_playerMovement.Move(new Vector3(x, 0f, z), _player.MovementSpeed, _player.Rb);
	}

	public void Jump()
	{
		_playerMovement.Jump(_player.JumpForce, _player.Rb);
	}
}