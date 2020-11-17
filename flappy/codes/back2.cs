using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back2 : MonoBehaviour
{
    public Rigidbody2D backtwo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        backtwo.velocity = new Vector2(-60, 0);
        if (transform.position.x < -776)
        {
            backtwo.position = new Vector3(1586, 183, 0);
        }
    }
}
