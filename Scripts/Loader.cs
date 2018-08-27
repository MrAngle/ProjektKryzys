using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    // Use this for initialization
    public GameObject gameManager;


	void Awake () {
        if (GameManager.instance == null)
            Instantiate(gameManager);
	}
	

}
