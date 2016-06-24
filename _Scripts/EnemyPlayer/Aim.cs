using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour 
{

    private float _aimDepth = 10f;

	void Awake()
	{
		Cursor.visible = false;
	}

    void Update()
    {
        AimMouse();
    }

    void AimMouse()
    {
        Vector3 temp = Input.mousePosition;
        temp.z = _aimDepth;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}