using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class toggleVrMode : MonoBehaviour {

	public int score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		score = 0;
		updateScore ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
	public void incScore(){
		scoreText.text = "Score:gggggg " + score.ToString();
		score++;
		updateScore ();
	}

	public void updateScore(){
		scoreText.text = "Score: " + score.ToString();

	}

	public void moveUp(){
		transform.position += new Vector3 (0f, 1f, 0f);

	}

}
