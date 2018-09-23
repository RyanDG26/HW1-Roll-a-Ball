using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Button PlayGame;
    public Button QuitGame;
	// Use this for initialization
	void Start () {
        PlayGame.onClick.AddListener(() => { SceneManager.LoadScene("Scene1"); });
        QuitGame.onClick.AddListener(() => { Application.Quit(); });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
