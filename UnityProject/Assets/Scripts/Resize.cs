using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 tempScale = transform.localScale;
        //Vector3 tempPosition = transform.localPosition;


        // on déplace un peu si besoin (sinon apparait en 0 ;0 ;0)
        // surtout utile pour surélever l'oeuvre si elle rentre dans le sol

       /* tempPosition.x += 0;      // décale en X
        tempPosition.y += 0;      // décale en Y
        tempPosition.z += 0;      // décale en Z
*/

        // on redéfini la taille (en général diviser par 100 est à peu près bon pour un .obj)

        tempScale.x = tempScale.x / 100;      // adapte la taille en X
        tempScale.y = tempScale.y / 100;      // adapte la taille en Y
        tempScale.z = tempScale.z / 100;      // adapte la taille en Z


        transform.localScale = tempScale;
       // transform.localPosition = tempPosition;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
