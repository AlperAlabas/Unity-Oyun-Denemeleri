using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class button : MonoBehaviour
{
    public UnityEngine.UI.Button btn;
    
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        SceneManager.LoadScene(1);
    }
}
