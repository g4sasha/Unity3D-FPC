using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private float _lifetime;
	[SerializeField] private LayerMask _playerLayer;

	private void Update()
	{
		Move();
		HandleLifetime();
	}

	private void Move()
	{
		transform.position += _speed * Time.deltaTime * transform.forward;
	}
	private void HandleLifetime()
	{
		_lifetime -= Time.deltaTime;

		if (_lifetime <= 0f)
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if ((_playerLayer & 1 << other.gameObject.layer) != 0)
		{
			return;
		}

		Destroy(gameObject);
	}
}