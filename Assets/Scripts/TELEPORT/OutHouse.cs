//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OutHouse : MonoBehaviour
//{
//    private NewBehaviourScript newBehaviourScript;

//    void Start()
//    {
//        newBehaviourScript = FindObjectOfType<NewBehaviourScript>();
//    }

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            other.transform.position = new Vector2(30, 29);
//            newBehaviourScript.CloseInventory(); // Вызов метода через ссылку на объект
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutHouse : MonoBehaviour
{
    public NewBehaviourScript newBehaviourScript;

   // private NewBehaviourScript newBehaviourScript;

    void Start()
    {
        newBehaviourScript = FindObjectOfType<NewBehaviourScript>(true);

        if (newBehaviourScript == null)
        {
            Debug.LogError("NewBehaviourScript not found in the scene.");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector2(30, 29);

            if (newBehaviourScript != null)
            {
                newBehaviourScript.CloseInventory(); // Вызов метода через ссылку на объект
            }
            else
            {
                Debug.LogError("newBehaviourScript is null.");
            }
        }
    }
}
