using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Rotate : MonoBehaviour {

    public Text score;
    private int count;

	//playerController pc = new playerController();
	//countController cc = new countController();
	// Use this for initialization
	void Start () {
        count = 0;
       // updateScore();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);

	}

	/*public void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("pickUps"))
		{
			other.gameObject.SetActive (false);
			count++;
            updateScore();

		}	
	}

    public void updateScore()
    {
        score.text = "Score: " + count;

    }*/
}
