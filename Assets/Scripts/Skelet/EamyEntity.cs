//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EamyEntity : MonoBehaviour
//{ 
//    [SerializeField] private int _maxHealth;
//    private int _currentHealth;
//    public int death;

//    private void Start()
//    {
//        _currentHealth = _maxHealth;

//        inventory = FindObjectOfType<inventory>();
//    }


//    public void TakeDamage(int damage)
//    {
//        _currentHealth -= damage;

//        DetectDeath();
//    }

//    public void DetectDeath()
//    {
//        if (_currentHealth <= 0) {
//            Destroy(gameObject);
//            inventory.OpenInventory();
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EamyEntity : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currentHealth;

    private Inventory inventory;

    private void Start()
    {
        _currentHealth = _maxHealth;
        inventory = FindObjectOfType<Inventory>(); 
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        DetectDeath();
    }

    private void DetectDeath()
    {
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);

            if (inventory != null)
            {
                //inventory.OpenInnventory();
            }
            else
            {
             //   Debug.LogWarning("Inventory reference is not found!");
            }
        }
    }
}
