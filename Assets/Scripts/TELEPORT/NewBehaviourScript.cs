//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class NewBehaviourScript : MonoBehaviour
//{
//    private GameObject inventoryRef; // Исправлено имя переменной
//    public bool inventoryOpened = false; // Исправлено имя переменной


//    private GameObject inventoryVIL;

//    void Start()
//    {
//        inventoryRef = GameObject.Find("ROOM1");
//        inventoryVIL = GameObject.Find("Vilage");
//        inventoryVIL.SetActive(true);
//        inventoryRef.SetActive(false);
//    }

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            other.transform.position = new Vector2(10, -173);
//            OpenInventory(); // Исправлено имя метода
//        }
//    }

//    public void OpenInventory() // Исправлено имя метода
//    {
//        inventoryVIL.SetActive(false);
//        inventoryRef.SetActive(true);
//        inventoryOpened = true;


//    }

//    public void CloseInventory() // Исправлено имя метода
//    {
//        inventoryVIL.SetActive(true);
//        inventoryRef.SetActive(false);
//        inventoryOpened = false;
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject inventoryRef; // Исправлено имя переменной
    public bool inventoryOpened = false; // Исправлено имя переменной

    private GameObject inventoryVIL;

    void Start()
    {
        inventoryRef = GameObject.Find("ROOM1");
        inventoryVIL = GameObject.Find("Vilage"); // Исправлено имя объекта

        if (inventoryVIL != null)
        {
            inventoryVIL.SetActive(true);
        }
        else
        {
            Debug.LogError("Object 'Vilage' not found");
        }

        if (inventoryRef != null)
        {
            inventoryRef.SetActive(false);
        }
        else
        {
            Debug.LogError("Object 'ROOM1' not found");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector2(10, -173);
            OpenInventory(); // Исправлено имя метода
        }
    }

    public void OpenInventory() // Исправлено имя метода
    {
        if (inventoryVIL != null)
        {
            inventoryVIL.SetActive(false);
        }

        if (inventoryRef != null)
        {
            inventoryRef.SetActive(true);
        }

        inventoryOpened = true;
    }

    public void CloseInventory() // Исправлено имя метода
    {
        if (inventoryVIL != null)
        {
            inventoryVIL.SetActive(true);
        }

        if (inventoryRef != null)
        {
            inventoryRef.SetActive(false);
        }

        inventoryOpened = false;
    }
}
