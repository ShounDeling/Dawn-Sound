using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 1f; // controle de velocidade do player
    private Rigidbody2D rig; // controlar o rigidbody2d do player -forças da física
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){ 
        // 0 = botão esquerdo 1 = botão direito do mouse
            rig.velocity=Vector2.up*speed;
            // manipula a física alterando a classe velocidadena posição para cima
        }
    }

    void OnCollisionEnter2D(Collision2D bater)
    {
        GameOver.SetActive(true);
        Time.timeScale = 1;
    }
}