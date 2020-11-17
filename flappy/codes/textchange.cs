using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textchange : MonoBehaviour
{
    public obstacles obs;
    public Rigidbody2D bird;
    public Text txt;
    public int sayac;
    void Start()
    {
        txt.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if(obs.text.Peek().position.x<bird.position.x)
        {
            obs.text.Dequeue();
            sayac++;
        }
        txt.text = sayac.ToString();
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("score", sayac);
    }
}
