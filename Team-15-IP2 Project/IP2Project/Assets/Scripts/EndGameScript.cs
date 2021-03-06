﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGameScript : MonoBehaviour {

	public Text winnerText;
	public Image winnerSprite;

	public Sprite yellow;
	public Sprite red;
	public Sprite blue;
	public Sprite green;
	GameObject eventSys;

	// Use this for initialization
	void Start () {
		eventSys = GameObject.Find("EventSystem");
		StartCoroutine (wait ());
	}
	
	// Update is called once per frame
	void Update () {

		GameObject g = GameObject.Find ("ScoreObject");
		if (g != null) 
		{
			WinScript win = g.GetComponent<WinScript> ();

			if (win.winningPlayer == 1)
			{
				winnerText.text = "Player 1 Wins!";

				GameObject dataObject = GameObject.Find("Player1Data");
				if(dataObject != null)
				{
					DataScript data = dataObject.GetComponent<DataScript>();
					if(data.playerSpriteNumber == 1)
					{
						winnerSprite.sprite = blue;
					}
					if(data.playerSpriteNumber == 2)
					{
						winnerSprite.sprite = green;
					}
					if(data.playerSpriteNumber == 3)
					{
						winnerSprite.sprite = yellow;
					}
					if(data.playerSpriteNumber == 4)
					{
						winnerSprite.sprite = red;
					}
				}
			}
			else if(win.winningPlayer == 2)
			{
				winnerText.text = "Player 2 Wins!";

				GameObject dataObject = GameObject.Find("Player2Data");
				if(dataObject != null)
				{
					DataScript data = dataObject.GetComponent<DataScript>();
					if(data.playerSpriteNumber == 1)
					{
						winnerSprite.sprite = blue;
					}
					if(data.playerSpriteNumber == 2)
					{
						winnerSprite.sprite = green;
					}
					if(data.playerSpriteNumber == 3)
					{
						winnerSprite.sprite = yellow;
					}
					if(data.playerSpriteNumber == 4)
					{
						winnerSprite.sprite = red;
					}
				}
			}
			else if(win.winningPlayer == 3)
			{
				winnerText.text = "Player 3 Wins!";

				GameObject dataObject = GameObject.Find("Player3Data");
				if(dataObject != null)
				{
					DataScript data = dataObject.GetComponent<DataScript>();
					if(data.playerSpriteNumber == 1)
					{
						winnerSprite.sprite = blue;
					}
					if(data.playerSpriteNumber == 2)
					{
						winnerSprite.sprite = green;
					}
					if(data.playerSpriteNumber == 3)
					{
						winnerSprite.sprite = yellow;
					}
					if(data.playerSpriteNumber == 4)
					{
						winnerSprite.sprite = red;
					}
				}
			}
			else if(win.winningPlayer == 4)
			{
				winnerText.text = "Player 4 Wins!";

				GameObject dataObject = GameObject.Find("Player4Data");
				if(dataObject != null)
				{
					DataScript data = dataObject.GetComponent<DataScript>();
					if(data.playerSpriteNumber == 1)
					{
						winnerSprite.sprite = blue;
					}
					if(data.playerSpriteNumber == 2)
					{
						winnerSprite.sprite = green;
					}
					if(data.playerSpriteNumber == 3)
					{
						winnerSprite.sprite = yellow;
					}
					if(data.playerSpriteNumber == 4)
					{
						winnerSprite.sprite = red;
					}
				}
			}
			else if(win.winningPlayer == 5)
			{
				winnerText.text = "What!? How did you manage to get this response? Did you all literally just sit there leaving the score at zero? Don't you have better things to do?";
			}
		}
	
		//if (Input.GetButtonDown ("Jump_P1") || Input.GetButtonDown ("Jump_P2")||Input.GetButtonDown ("Jump_P3")||Input.GetButtonDown ("Jump_P4")) {
		//	LoadMainLevel();
		//}
	}
	IEnumerator wait()
	{
		eventSys.SetActive (false);
		yield return new WaitForSeconds (1.5f);
		eventSys.SetActive (true);
	}
	public void LoadMainLevel()
	{
		Application.LoadLevel ("LevelSelectScene");
	}


	
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel ("MainMenu");
	}
}
