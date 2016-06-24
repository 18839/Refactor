using UnityEngine;
using System.Collections;

public class DestroySkid : MonoBehaviour 
{

    [SerializeField]
    private float _destroyInSeconds;

    public void Start()
    {
        Destroy(gameObject, _destroyInSeconds);
    }
}
