using UnityEngine;
using System.Collections;

public class DetectHit : MonoBehaviour 
{
	public bool sendOnHitOther;
	public bool destroyOther;
	public bool sendOnHitSelf;
	public bool destroySelf;


	private void OnCollisionEnter2D(Collision2D c)
	{
//		if (c.gameObject.tag == "Enemy")	could filter on tag, but for now, filtering on collision matrix
		if (sendOnHitOther) c.gameObject.SendMessage ("OnHit");
		if (destroyOther) Destroy (c.gameObject);

		if (sendOnHitSelf) SendMessage ("OnHit");
		if (destroySelf) Destroy (gameObject);
	}
}
