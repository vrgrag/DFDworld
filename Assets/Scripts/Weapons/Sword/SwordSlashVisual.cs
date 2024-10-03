using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlashVisual : MonoBehaviour
{
    [SerializeField] private Sword sword;

    private const string ATACK = "Atack";
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        sword.OnSwordSwing += Sword_OnSwordSwing;
    }
    private void Sword_OnSwordSwing(object sebder, System.EventArgs e)
    {
        animator.SetTrigger(ATACK);
    }
}
