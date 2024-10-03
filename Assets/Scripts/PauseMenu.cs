
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class PauseMenu : MonoBehaviour
//{

//    private bool isPaused = false;
//    private MonoBehaviour[] scripts;
//    private Rigidbody[] rigidbodies;

//    void Start()
//    {
//        // Получаем все скрипты и Rigidbody в сцене
//        scripts = FindObjectsOfType<MonoBehaviour>();
//        rigidbodies = FindObjectsOfType<Rigidbody>();
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.P))
//        {
//            TogglePause();
//        }
//    }

//    void SwithPause()
//    {
//        isPaused = true;

//    }

//    private void TogglePause()
//    {
//        isPaused = !isPaused;

//        if (isPaused)
//        {
//            PauseGame();
//        }
//        else
//        {
//            ResumeGame();
//        }
//    }

//    public void PauseGame()
//    {
//        // Останавливаем все скрипты
//        foreach (MonoBehaviour script in scripts)
//        {
//            script.enabled = false;
//        }

//        // Останавливаем все Rigidbody
//        foreach (Rigidbody rb in rigidbodies)
//        {
//            rb.isKinematic = true;
//        }
//    }

//    public void ResumeGame()
//    {
//        // Включаем все скрипты
//        foreach (MonoBehaviour script in scripts)
//        {
//            script.enabled = true;
//        }

//        // Включаем все Rigidbody
//        foreach (Rigidbody rb in rigidbodies)
//        {
//            rb.isKinematic = false;
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused = false;
    private MonoBehaviour[] scripts;
    private Rigidbody[] rigidbodies;

    void Start()
    {
        // Получаем все скрипты и Rigidbody в сцене
        scripts = FindObjectsOfType<MonoBehaviour>();
        rigidbodies = FindObjectsOfType<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void SwithPause()
    {
        isPaused = true;

    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        // Останавливаем все скрипты
        foreach (MonoBehaviour script in scripts)
        {
            if (script != this)
                script.enabled = false;
        }

        // Останавливаем все Rigidbody
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = true;
        }
    }

    public void ResumeGame()
    {
        // Включаем все скрипты
        foreach (MonoBehaviour script in scripts)
        {
            if (script != this)
                script.enabled = true;
        }

        // Включаем все Rigidbody
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = false;
        }
    }
}
