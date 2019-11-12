using UnityEngine;

public class Weapon : MonoBehaviour
{
	[Header("Gun Info")]
	/*Information about the gun's ammo counts; the total and clip amounts*/
	private int totalAmmo = 100; //total ammo at the start (information)
	public float damagePower; //the amount of damage it deals
	public int currentAmmo; //current ammo possessed (mutable variable)
	private int maxClip = 10; //how much ammo one clip can hold (information)
	public int currentClip; //current ammo in clip (mutable variable)


	// Use this for initialization
	private void Start()
	{
		//initialize current ammo to starting ammo
		//initialze our clip to the max clip
		currentAmmo = totalAmmo;
		currentClip = maxClip;
	}

	public void reload()
	{
		//if current clip is 0(empty), then we set current clip to max clip
		//then subtract max clip to current ammo simulating reloading a gun
		if (currentClip <= 0 && currentAmmo > 0)
		{
			currentClip = maxClip;
			currentAmmo -= maxClip;
		}

		//of course if total ammo is 0, then nothing happens
	}
}