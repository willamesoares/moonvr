using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeText : MonoBehaviour {

    private int count = 0;
    private string[] phrases = {"Hi there!",
                                "I'm the Moon.",
                                "I am 384 thousand km\n away from Earth.",
                                "On July, 20th of 1969\n I received the first visit\n from Earth.",
                                "I take 27 days to make\n a complete orbit\n around the Earth."
                               };
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeText(){
        GetComponent<TextMesh>().text = phrases[count];
        if(count == 4)
        {
            count = 0;
        }else
        {
            count++;
        }
    }
}
