using UnityEngine;
using System.Collections;

public class AstroidFadeOut : MonoBehaviour
{
    [SerializeField]
    private float _destroyInSeconds;

    void Start()
    {
        Destroy(gameObject, _destroyInSeconds);
    }
}