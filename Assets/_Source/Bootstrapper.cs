using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
	[SerializeField] private Player _player;
	[SerializeField] private InputListener _inputListener;
	private PlayerInvoker _playerInvoker;
	private PlayerMovement _playerMovement;

	private void Awake()
	{
		_playerMovement = new PlayerMovement();
		_playerInvoker = new PlayerInvoker(_player, _playerMovement);
		_inputListener.SetPlayerInvoker(_playerInvoker);
	}
}