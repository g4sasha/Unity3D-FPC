using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private float _lifetime;

	private void Update()
	{
		transform.position += _speed * Time.deltaTime * transform.forward;
		_lifetime -= Time.deltaTime;
		if (_lifetime <= 0f)
		{
			Destroy(gameObject);
		}
	}
}