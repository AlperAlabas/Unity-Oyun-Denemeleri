using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    public int scor;
    public int high;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scor>high)
        {
            txt.text = scor.ToString();
        }
        else
        {
            txt.text=high.ToString();
        }

    }
    private void OnEnable()
    {
       scor= PlayerPrefs.GetInt("score");
        high = PlayerPrefs.GetInt("highscore");
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("highscore", int.Parse(txt.text));
    }
}
