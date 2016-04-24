using UnityEngine;
using System.Collections;

public class ShowInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showInfo()
    {
        transform.position += new Vector3(0f, 0f, 1f);
    }
}
