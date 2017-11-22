using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeDetect : MonoBehaviour {

    
    void Update () {
        
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        if (pos.x < 0) {
            pos.x = 0;
            transform.position = new Vector3(right.x, this.transform.position.y + 3f, this.transform.position.x);
        }
        if (pos.x > 1.0) {
            pos.x = 1;
            transform.position = new Vector3(left.x, this.transform.position.y + 3f, this.transform.position.x);
        }

    }
    
 
}
