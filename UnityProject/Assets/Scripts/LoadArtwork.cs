using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadArtwork : MonoBehaviour {

    public static string number;

	// Use this for initialization
	void Start () {
        GameObject model;
        model = OBJLoader.LoadOBJFile("C:\\Users\\joris.ZURICH\\Documents\\ProjetMuseeVRAlbi\\oeuvres\\" + number + "\\" + number + ".obj");
        model.AddComponent<Resize>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
