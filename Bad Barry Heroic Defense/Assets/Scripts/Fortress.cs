//  Created by Gabriel Neves Ferreira.
//  Copyright © 2016 Neves. All rights reserved.
using UnityEngine;
using System.Collections;

public class Fortress : MonoBehaviour {

	private float durability;
	private GameBehaviour behaviour;




	// Use this for initialization
	void Start () {

		behaviour = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();
		durability = behaviour.GetDurability();

	}

	// Update is called once per frame
	void Update () {


	}







	public void IncreaseDurabilityBy(float amount){

		durability = durability + amount;

	}

	public void TakeDamage(float amount){

		durability = durability - amount;
		//animation
		//new sprite case durability is low

	}

	public float GetDurability(){

		return durability;

	}



}
