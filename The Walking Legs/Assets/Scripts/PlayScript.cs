using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject StartPanel;

    public void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            Cursor.visible = false;
            StartPanel.SetActive(false);
            Canvas.SetActive(false);
            
        }
    }
}
