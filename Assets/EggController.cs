﻿using UnityEngine;
using System.Collections;

public class EggController : MonoBehaviour {

	public float Speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Speed * Time.deltaTime * transform.right);
	}
}
