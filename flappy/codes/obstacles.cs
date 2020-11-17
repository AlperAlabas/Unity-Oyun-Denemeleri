using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacles : MonoBehaviour
{
    
    public GameObject[] gameObjects;
    public Rigidbody2D[] obstacless;
    public BoxCollider2D bird;
    GameObject clone;
    Rigidbody2D clonerigit;
    public Queue<GameObject> objects = new Queue<GameObject>();
    public Queue<Rigidbody2D> obsto = new Queue<Rigidbody2D>();
    public Queue<Rigidbody2D> text = new Queue<Rigidbody2D>();
    public int counter=0;
    public bool sayac = false;
    public bool control;
    public int sayac2 = 0;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(sayac==false)
        {
            clone=Instantiate(gameObjects[Random.Range(0,4)],new Vector3(948, 196, -1),Quaternion.identity);
            objects.Enqueue(clone);
            clonerigit=clone.GetComponent("Rigidbody2D") as Rigidbody2D;
            obsto.Enqueue(clonerigit);
            text.Enqueue(clonerigit);
            sayac = true;
        }
        
        if (counter == 250)
        {
            counter = 0;
            sayac = false;
            //Destroy(clone);
        }
        if (sayac2==4500)
        {
            GameObject peek = objects.Peek();
            objects.Dequeue();
            obsto.Dequeue();
            Destroy(peek);

            sayac2 = 4250;
        }
        ending();

       

        sayac2++;
        counter++;
    }
    public void ending()
    {
        foreach (var item in obsto)
        {
            if (item.IsTouching(bird))
            {
                /*
                obsto.Remove(item);
                item.gameObject.active = false;*/

                SceneManager.LoadScene(0);
            }
        }
        
    }
}
