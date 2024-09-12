using UnityEngine;

public class PlayerInvoker
{
	private Player _player;
	private PlayerMovement _playerMovement;
	private PlayerCombat _playerCombat;

	public PlayerInvoker(Player player, PlayerMovement playerMovement, PlayerCombat playerCombat)
	{
		_player = player;
		_playerMovement = playerMovement;
		_playerCombat = playerCombat;
	}

	public void Move(float x, float z)
	{
		_playerMovement.Move(new Vector3(x, 0f, z), _player.MovementSpeed, _player.Rb);
	}

	public void Jump()
	{		
		_playerMovement.Jump(_player.JumpForce, _player.Rb);
	}

	public void Attack()
	{
		_playerCombat.Attack(_player.Bullet, _player.transform.position, _player.transform.rotation);
	}
}