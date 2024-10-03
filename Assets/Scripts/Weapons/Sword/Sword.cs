using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private int _damageAmount = 2;
    public event EventHandler OnSwordSwing;
    private PolygonCollider2D _polygonCollider2D;


    private void Start(){
        AtackColiderTurnOff();
    }   
   
    private void Awake(){
       
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    public void Atack() {
        AtackColiderTurnOffOn();
        OnSwordSwing?.Invoke(this, EventArgs.Empty);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.TryGetComponent(out EamyEntity eamyEntity)){
            eamyEntity.TakeDamage(_damageAmount);
        }
    }


    public void AtackColiderTurnOff() { 
        _polygonCollider2D.enabled = false;
    }

    private void AtackColiderTurnOn()
    {
        _polygonCollider2D.enabled = true;
    }

    private void AtackColiderTurnOffOn(){
        AtackColiderTurnOff();
        AtackColiderTurnOn();
       
    }

}
