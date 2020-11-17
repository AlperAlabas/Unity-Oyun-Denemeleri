using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballMotion : MonoBehaviour
{
    public Rigidbody2D ball;
    public BoxCollider2D bar;
    public BoxCollider2D up;
    public BoxCollider2D right;
    public BoxCollider2D left;
    public int sayac;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(x, y);
        ball.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (sayac<60)
        {
            sayac++;
        }
        
        if (ball.IsTouching(bar))
        {
            
            y = -y;
            ball.velocity = new Vector2(x, y);
            sayac = 0;
        }
        else if (ball.IsTouching(up))
        {
            y = -y;
            ball.velocity = new Vector2(x, y);
            sayac = 0;
        }
        else if (ball.IsTouching(left))
        {
            x = -x;
            sayac = 0;
            ball.velocity = new Vector2(x, y);
        }
        else if (ball.IsTouching(right))
        {
            x = -x;
            
            ball.velocity = new Vector2(x, y);
            sayac = 0;
        }
        else if (ball.position.y<-5)
        {
            SceneManager.LoadScene("menu");
        }
        ball.velocity = new Vector2(x, y);





    }
}
