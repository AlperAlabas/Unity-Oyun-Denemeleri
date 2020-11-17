using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                Vector3 loc = Camera.main.ScreenToWorldPoint(t.position);

                this.transform.position = new Vector3(loc.x, this.transform.position.y, 0);

            }
        
        }   
    }
}
