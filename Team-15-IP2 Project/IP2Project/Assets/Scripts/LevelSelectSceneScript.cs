﻿using UnityEngine;
using System.Collections;

public class LevelSelectSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevelOne()
	{

		Application.LoadLevel ("Level_1");
	}

	public void LoadLevelTwo()
	{
		Application.LoadLevel ("Level_2");
	}

	public void LoadLevelThree()
	{
		Application.LoadLevel ("Level_3");
	}
}
