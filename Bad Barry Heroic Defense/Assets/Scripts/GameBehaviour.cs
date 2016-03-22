//  Created by Gabriel Neves Ferreira.
//  Copyright © 2016 Neves. All rights reserved.
using UnityEngine;
using System.Collections;

public class GameBehaviour : MonoBehaviour {

	private float durability;

	void Awake(){

		durability = 100;

	}

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




	public float GetDurability(){

		return durability;

	}

	public void SetDurability(float value){

		durability = value;

	}

}
