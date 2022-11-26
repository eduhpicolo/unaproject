using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //public Button miButton;

    private void Awake()
    {
        //miButton.onClick.AddListener(GoGame);

        this.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("Nivel1"));
    }

    //private void GoGame()
    //{
    //    SceneManager.LoadScene("Nivel1");
    //}
}
