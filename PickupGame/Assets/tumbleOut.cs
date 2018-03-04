using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tumbleOut : MonoBehaviour {
	public GameObject a;

	public NewBehaviourScript _NewBehaviourScript;
    public Shader shader1, shader2, shader3, shader4, shader5;
    void Start()
	{
		gameObject.transform.position = new Vector3(
            GetRandCoord(), Random.Range(-3, 2), GetRandCoord());



    }

    public void RandomlyTeleport()
    {
        gameObject.transform.position = new Vector3(10, 10, 10);

		a.GetComponent<NewBehaviourScript>().doIt();

    }

    private float GetRandCoord()
    {
        var coord = Random.Range(-6, 6);
        while(coord> -2 && coord < 2)
        {
            coord = Random.Range(-6, 6);
        }
        return coord;
        
    }
}
    
/*public void Update()
    {
	if(count==1){
		countText.text = count.ToString();
    }
}
*/