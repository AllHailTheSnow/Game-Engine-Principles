using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Player stats
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float dashSpeed = 4f;

    //Player components
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform weaponCollider;
    [SerializeField] private Transform slashAnimSpawnPoint;

    //Public player movement   
    public bool FacingLeft { get { return facingLeft; } }

    //Player components
    private PlayyerControls playerControls;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    //Player movement
    private Vector2 movement;
    private bool facingLeft, isDahsing = false;
    private float startingMoveSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
