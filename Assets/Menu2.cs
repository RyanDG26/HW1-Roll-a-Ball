using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu2 : MonoBehaviour
{

    public Button Back;
   
    // Use this for initialization
    void Start()
    {
        Back.onClick.AddListener(() => { SceneManager.LoadScene("Menu Scene"); });
    }

    // Update is called once per frame
    void Update()
    {

    }
}

