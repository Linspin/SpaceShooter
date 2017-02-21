using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GUIText scoretext;
    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();		
	}
	
	// Update is called once per frame
	void UpdateScore () {
        scoretext.text = "Score: " + score;
	}
    public void Addscore (int add)
    {
        score += add;
        UpdateScore();

    }

    public int Getscore ()
    {
        return score;
    }
}
