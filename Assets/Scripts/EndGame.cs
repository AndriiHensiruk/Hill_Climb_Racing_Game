using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
