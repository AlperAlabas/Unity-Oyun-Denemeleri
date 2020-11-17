using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class locations : MonoBehaviour
{
    public GameObject reds;
    public Rigidbody2D ball;
    public ballMotion motion;
    public List<GameObject> objects = new List<GameObject>();
    private int[] locationx = { -9, -7, -5, -3, -1, 1, 3, 5, 7, 9 };
    private int[] locationy = { 2, 3, 4 };
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(5, 10);
        random(rand);
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < objects.Count; i++)
        {

            if (ball.IsTouching(objects[i].transform.Find("right").GetComponent<BoxCollider2D>()))
            {
                motion.x = -motion.x;
                motion.ball.velocity = new Vector2(motion.x, motion.y);
                GameObject holder = objects[i];
                objects.Remove(objects[i]);
                Destroy(holder);
            }
            else if (ball.IsTouching(objects[i].transform.Find("left").GetComponent<BoxCollider2D>()))
            {
                motion.x = -motion.x;
                motion.ball.velocity = new Vector2(motion.x, motion.y);
                GameObject holder = objects[i];
                objects.Remove(objects[i]);
                Destroy(holder);
            }
            else if (ball.IsTouching(objects[i].GetComponent<BoxCollider2D>()))
            {
                motion.y = -motion.y;
                motion.ball.velocity = new Vector2(motion.x, motion.y);
                GameObject holder = objects[i];
                objects.Remove(objects[i]);
                Destroy(holder);
            }
            
        }
        if (objects.Count == 0)
        {
            SceneManager.LoadScene("menu");
               
        }
    }
    void random(int rand)
    {

        for (int i = 0; i < locationx.Length; i++)
        {
            for (int j = 0; j < locationy.Length; j++)
            {
                GameObject holder = Instantiate(reds, new Vector3(locationx[i], locationy[j], -5), Quaternion.identity);
                objects.Add(holder);
            }
        }

        
        for (int i = 0; i <rand ; i++)
        {
            int count = Random.Range(0, objects.Count);
            GameObject game = objects[count];
            objects.RemoveAt(count);
            Destroy(game);

            

        }
    }
}
