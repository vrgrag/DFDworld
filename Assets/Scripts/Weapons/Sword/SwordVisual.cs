using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordVisual : MonoBehaviour
{
    [SerializeField] private Sword sword;

    private Animator animator;
    private const string ATACK = "Atack";

    private void Awake(){
        animator = GetComponent<Animator>();
    }

    private void Start() {
        sword.OnSwordSwing += Sword_OnSwordSwing;
    }
    private void Sword_OnSwordSwing(object sebder, System.EventArgs e){
        animator.SetTrigger(ATACK);
    }

    public void TrigerEndAtackAnimation()
    {
        sword.AtackColiderTurnOff();
    }

}
