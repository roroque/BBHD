//  Created by Gabriel Neves Ferreira.
//  Copyright © 2016 Neves. All rights reserved.
using UnityEngine;
using System.Collections;

public class ShootingPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter2D (Collider2D col){
	

		if(col.tag == "Enemy"){

			col.gameObject.GetComponent<Enemy>().EnemyIsNowInPlace();

		}

	
	}
}
