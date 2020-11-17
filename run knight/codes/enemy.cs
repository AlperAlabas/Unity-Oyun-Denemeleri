using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject enemies;
    public GameObject[] others;
    private GameObject holder;
    public GameObject character;
    private int sayac;
    public int length;
    public int distance;
    public float y;
    public Queue<GameObject> dizi = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        sayac = length;
    }

    // Update is called once per frame
    void Update()
    {

       


            if (sayac == 0 )
            {
                holder = Instantiate(enemies, new Vector3(character.transform.position.x + 15, y, -5), Quaternion.identity);
                dizi.Enqueue(holder);
                sayac = length;
                
            }
        
        sayac--;
        if (dizi.Count > 0)
        {
            if (character.GetComponent<Rigidbody2D>().IsTouching(dizi.Peek().GetComponent<BoxCollider2D>()))
            {
                SceneManager.LoadScene(0);
            }
        }
        if (dizi.Count > 0)
        {
            if ((dizi.Peek().transform.position.x-character.transform.position.x)<distance&&character.GetComponent<Motion>().isAttack==true)
            {
                GameObject peek = dizi.Peek();
                dizi.Dequeue();
                Destroy(peek);
            }
        }

    }
}
