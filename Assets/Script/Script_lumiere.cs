using UnityEngine;
using System.Collections;

public class Script_lumiere : MonoBehaviour
{
	public float allumage=0.01f;
	public bool activage=false;

	void Update ()
		{
		if (activage) {
			light.intensity+=allumage;
				}

		}

	void OnTriggerEnter(Collider other)
	{
		activage = true;
	}
	
}
