using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject menu;
    public Camera NormalCam;
    public Camera PauseCam;

	void Start ()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        PauseCam.gameObject.SetActive(false);
        NormalCam.gameObject.SetActive(true);
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
            PauseCam.gameObject.SetActive(true);
            NormalCam.gameObject.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            PauseCam.gameObject.SetActive(false);
            NormalCam.gameObject.SetActive(true);
        }
    }
}
