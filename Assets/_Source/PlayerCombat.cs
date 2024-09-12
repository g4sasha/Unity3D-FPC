using UnityEngine;

public class PlayerCombat
{
	public void Attack(Player player)
	{
		GameObject.Instantiate(player.Bullet, player.transform.position, player.transform.rotation);
	}
}