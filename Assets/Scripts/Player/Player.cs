using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int health = 1;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();  

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }



    public static Player Instance { get; private set; }
   [SerializeField] private float movingSpeed = 5f;

    private Rigidbody2D rb;
    
    private float minMuvingSpeed = 0.1f;
    private bool isRunning = false;
    private void Awake(){
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        GameInput.Instance.OnPlayerAtack += GameInput_OnPlayerAtack;
    }

    private void GameInput_OnPlayerAtack(object sender, System.EventArgs e) {
        ActiveWeapon.Instance.GetActiveWeapon().Atack();
    }
    private void FixedUpdate(){
        HandMovment(); 
    }
    private void HandMovment() { 
        Vector2 inputVector = GameInput.Instance.GetMovmentVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (movingSpeed * Time.fixedDeltaTime));

        if (Mathf.Abs(inputVector.x) > minMuvingSpeed || Mathf.Abs(inputVector.y) > minMuvingSpeed)  {
            isRunning = true;
        }
        else  { 
            isRunning = false;
        }

    }
    public bool IsRunning()  {
        return isRunning;
    }

    public Vector3 GetPlayerScreenPosition() {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
        return playerScreenPosition;
    }
}
