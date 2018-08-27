using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour{


    public int movmentRatio;
    private GameObject instance;

    public Field(GameObject go){

        Instance = go;
    }

    public GameObject Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }

}
