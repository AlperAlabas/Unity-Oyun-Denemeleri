using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject character;
    public float x;
    public bool left;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if ((character.transform.position.x-this.transform.position.x)>x)
        {
            this.transform.position = new Vector3(character.transform.position.x+x, this.transform.position.y, 0);
        }
        if ((character.transform.position.x - this.transform.position.x) < -x)
        {
            this.transform.position = new Vector3(character.transform.position.x - x, this.transform.position.y, 0);
        }
    }
}
