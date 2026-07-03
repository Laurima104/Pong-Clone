using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Telas UI")]
    [SerializeField] private GameObject StartMenu;
    [SerializeField] private GameObject GameOptions;
    [Header("Configurações de Jogo")]
    [SerializeField] private GameType GameType;
    public void Start()
    {
        StartMenu.SetActive(true);
        GameOptions.SetActive(false);
    }
    public void Jogar()
    {
        StartMenu.SetActive(false);
        GameOptions.SetActive(true);
    }
    public void CarregarSolo()
    {
        GameType.MLocal=false;
        SceneManager.LoadScene(0);
    }
    public void CarregarLocal()
    {
        GameType.MLocal=true;
        SceneManager.LoadScene(0);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
