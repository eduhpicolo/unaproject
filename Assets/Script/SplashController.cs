using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    [SerializeField] private Image logo;

    private void Start()
    {
        logo.sprite = Resources.Load<Sprite>("Image/escudo_uaa");

        StartCoroutine(GoMainMenu());
    }

    IEnumerator GoMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");
    }
}
