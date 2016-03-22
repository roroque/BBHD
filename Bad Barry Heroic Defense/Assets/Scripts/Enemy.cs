//  Created by Gabriel Neves Ferreira.
//  Copyright © 2016 Neves. All rights reserved.
using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private bool enemyInPlace;
	private Rigidbody2D body;
	public float speed;
	public float damage;
	public float health;


	// Use this for initialization
	void Start () {

		enemyInPlace = false;
		body = gameObject.GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		Move();
		Shoot();

	
	}

	private void Shoot(){

		if(enemyInPlace){

			//shoot projectile
			print("pew pew");


		}

	}



	private void Move(){

		if(enemyInPlace){

			body.velocity = new Vector2(0,0);

		}else{

			body.velocity = new Vector2(speed,0);


		}

	}

	public void EnemyIsNowInPlace(){

		enemyInPlace = true;


	}

	public void TakeDamage(int damage){

		health = health - damage;

		if(health <= 0){
			Die();

		}
		//representacao visual
		print("que dor");


	}

	public void Die(){

		print("morri");
		//animacao de morte

	}


}
