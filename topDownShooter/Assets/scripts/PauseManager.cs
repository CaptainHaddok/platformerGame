using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject menu;

	void Start ()
    {
        Cursor.visible = false;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menuswitch();
        }
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Menuswitch()
    {
        menu.active = !menu.active;
        if (menu.active == true)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
        }
    }
}
