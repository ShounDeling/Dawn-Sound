using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string Nivel;
    public void Jogar()   
    {
        SceneManager.LoadScene(Nivel);
 
    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
