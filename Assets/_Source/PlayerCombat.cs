using UnityEngine;

public class PlayerCombat
{
	public void Attack(GameObject prefab, Vector3 startPosition, Quaternion direction)
	{
		GameObject.Instantiate(prefab, startPosition, direction);
	}
}