using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Success");
        SceneManager.LoadScene("EndScene");
    }

    public void Menu()
    {
        FindObjectOfType<AudioManager>().Play("Success");
        SceneManager.LoadScene("MainMenu");
    }
}
