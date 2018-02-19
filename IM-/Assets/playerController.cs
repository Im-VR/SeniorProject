using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public int count = 0 ;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		count = 0;
		//updateScore ();
	}
	
	// Update is called once per frame
	void Update () {
     //   updateScore();
	}
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickUps"))
        {
            other.gameObject.SetActive(false);
            count++;
            Debug.Log(count);
            updateScore();
        }
    }

/*	public void incScore(){
		count++;
		updateScore ();
	}*/

	public void updateScore(){
		scoreText.text = "Score: " + count.ToString();

	}


}
