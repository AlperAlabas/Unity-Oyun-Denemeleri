using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    
    public GameObject character;
    
    public bool left;
    public bool right;
    public float x;
    public float speed;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        left = character.GetComponent<Motion>().left;
        right = character.GetComponent<Motion>().right;
        if (left == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if (right == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }
        if(right==false&&left==false)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        if ((character.transform.position.x - this.transform.position.x) > x)
        {
            this.transform.position = new Vector3(character.transform.position.x + x, this.transform.position.y,this.transform.position.z );
        }
        if ((character.transform.position.x - this.transform.position.x)< -x)
        {
            this.transform.position = new Vector3(character.transform.position.x - x, this.transform.position.y, this.transform.position.z);
        }
    }
}
