using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{

    public BoxCollider2D[] obstacles;
    
    public Rigidbody2D bird;
    public Scene scene = new Scene();
    // Start is called before the first frame update
    void Start()
    {
        
        bird.freezeRotation=true;
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                bird.velocity = new Vector2(0, 60);
            }
        }
        
       if(Input.GetKeyDown(KeyCode.Space))
        {
            bird.velocity = new Vector2(0,60);
            
            
      
        }/*
       if(Input.GetKey(KeyCode.D))
        {
            bird.velocity = new Vector2(2, 0);
            if (Input.GetKey(KeyCode.Space))
            {
                bird.velocity = new Vector2(2, 2);



            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            bird.velocity = new Vector2(-2, 0);
            if (Input.GetKey(KeyCode.Space))
            {
                bird.velocity = new Vector2(-2, 2);



            }
        }*/
        /*for (int i = 0; i < obstacles.Length; i++)
        {
            if (bird.IsTouching(obstacles[i]))
            {
                bird.position = new Vector2(128.7f, 191.5f);
                scene.GetRootGameObjects();
            }
        }*/
       
    }
}
