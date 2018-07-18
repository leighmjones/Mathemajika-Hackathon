using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {


    public float Health = 100;

    public void TakeHits (float damage)
    {
        Health -= damage;
        if (Health = 0)
        {
            Destroy(GameObject/*?*/);
        }
    }
    
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
