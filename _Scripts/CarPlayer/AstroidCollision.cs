using UnityEngine;
using System.Collections;

public class AstroidCollision : MonoBehaviour 
{
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag (GameTags.asteroid)) 
		{
			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag (GameTags.rain)) 
		{
			Destroy (other.gameObject);
		}
	}
}
