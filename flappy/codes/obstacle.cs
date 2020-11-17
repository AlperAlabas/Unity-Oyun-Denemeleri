using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Rigidbody2D obstaclo;
    public GameObject objecto;
    public BoxCollider2D objectte;
    private float x;
    private float y;
    private float beginX;
    private float beginY;
    // Start is called before the first frame update
    void Start()
    {

        obstaclo.position = new Vector2(948, 196);
        obstaclo.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
            obstaclo.velocity = new Vector2(-60, 0);
        
       
        
    }
    
}
