using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject invettoryRef;

    public bool innventoryOpened = false;


    void Start()
    {
        invettoryRef = GameObject.Find("inventory");
        invettoryRef.SetActive(false);
    }
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.I))
        {
            if (!innventoryOpened)
            {
                OpenInnventory();
            }
            else
            {
                CloseInnventory();
            }
        }

    }

    public void OpenInnventory()
    {
        invettoryRef.SetActive(true);
        innventoryOpened = true;
    }

    public void CloseInnventory()
    {
        invettoryRef.SetActive(false);
        innventoryOpened = false;
    }



}