﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEndComp : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnTriggerEnter2D(Collider2D other){
		if(GameMgr.Instance.IsPlayer(other.gameObject))
		{
			GameMgr.Instance.player.gameObject.SetActive(false);
			anim.Play("theEnd");
		}
	}

	public void Over(){

	}
}
