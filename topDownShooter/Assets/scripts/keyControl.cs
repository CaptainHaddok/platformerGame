using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyControl : MonoBehaviour
{

    public int amountKeys = 0;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "key")
        {
            amountKeys++;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "door" && amountKeys > 0)
        {
            amountKeys--;
            Destroy(col.gameObject);
        }
    }
}
