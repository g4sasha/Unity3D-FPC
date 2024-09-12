using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
	[SerializeField] private Player _player;
	[SerializeField] private InputListener _inputListener;
	[SerializeField] private CameraRotate _cameraRotate;
	private PlayerInvoker _playerInvoker;
	private PlayerMovement _playerMovement;
	private PlayerCombat _playerCombat;

	private void Awake()
	{
		_playerMovement = new PlayerMovement();
		_playerCombat = new PlayerCombat();
		_playerInvoker = new PlayerInvoker(_player, _playerMovement, _playerCombat, _cameraRotate);
		_inputListener.Construct(_playerInvoker);
	}
}