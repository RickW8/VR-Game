using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {
	public Text countText;
	public tumbleOut _tumbleOut;
	public int count;
	// Use this for initialization
	public void Start () {
		countText = GetComponent<Text> () as Text;
		countText.text = "Obj left: 5";
		count = 5;
	}

	public void doIt () {
		count--;
		countText.text = "Obj left: "+count.ToString();
        if (count == 0){
            countText.text = "Congrats. You win!";
        }
	}
}
