using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Motion : MonoBehaviour
{
    public Rigidbody2D character;
    public Animator anim;
    public bool left;
    public bool right;
    public float speed;
    public Button run;
    public bool isRun;
    public bool isAttack;

    // Start is called before the first frame update
    void Start()
    {
        character.freezeRotation = true;
        left = false;
        right = false;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (isRun == true)
        {

            character.velocity = new Vector2(speed, character.transform.position.y);
            right = true;
            
            anim.SetBool("right", true);
        }
        if (isRun==false)
        {
            left = false;
            right = false;


            anim.SetBool("right", false);
            
        }
        
        if (isAttack==true&&isRun==false)
        {
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("attack", false);
        }


    }
    public void runner()
    {
        isRun = true;
    }
    public void stop()
    {
        isRun = false;
    }
    public void attack()
    {
        isAttack = true;
    }
    public void sheate()
    {
        isAttack = false;
    }
}
