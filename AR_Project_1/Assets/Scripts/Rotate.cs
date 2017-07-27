using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    //Variable para controlar la velocidad de rotación
    public int Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Rotar cubo sobre el eje Y
        transform.Rotate(new Vector3(0, Time.deltaTime * Speed, 0));
	}
}
