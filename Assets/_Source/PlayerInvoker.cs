using UnityEngine;

public class PlayerInvoker
{
	private Player _player;
	private PlayerMovement _playerMovement;
	private PlayerCombat _playerCombat;
	private CameraRotate _cameraRotate;

	public PlayerInvoker(Player player, PlayerMovement playerMovement, PlayerCombat playerCombat, CameraRotate cameraRotate)
	{
		_player = player;
		_playerMovement = playerMovement;
		_playerCombat = playerCombat;
		_cameraRotate = cameraRotate;
	}

	public void Move(float x, float z)
	{
		_playerMovement.Move(_player.transform.forward * z, _player.MovementSpeed, _player.Rb);
	}

	public void Jump()
	{		
		_playerMovement.Jump(_player.JumpForce, _player.Rb);
	}

	public void Attack()
	{
		_playerCombat.Attack(_player.Bullet, _player.transform.position, _player.transform.rotation);
	}

	public void Rotate()
	{
		_playerMovement.Rotate(_cameraRotate.transform.rotation * Vector3.forward, _player.transform);
	}
}