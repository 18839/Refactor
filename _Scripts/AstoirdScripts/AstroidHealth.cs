using UnityEngine;
using System.Collections;

public class AstroidHealth : MonoBehaviour 
{
	private int _takenHits;

    [SerializeField]
    private AudioSource _hitSFX;

	void Awake() 
	{
        _takenHits = 0;
	}

	public void HurtMe()
	{
        _takenHits++;
        _hitSFX.Play();
        CheckHit();
	}

    void CheckHit()
    {
        if (_takenHits == 3)
        {
            Destroy(gameObject);
            _takenHits = 0;
        }
    }
}
