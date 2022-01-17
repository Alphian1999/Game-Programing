using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int scoreValue = 0;
	Text score;
	//public GameObject player;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		//player= GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score : " + scoreValue;
		//Debug.Log("Text: " + player.transform);
	}
}
