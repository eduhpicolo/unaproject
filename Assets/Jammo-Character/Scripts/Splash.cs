using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(goToMenu());
    }

    //CORUTINA
    IEnumerator goToMenu()
    {
        yield return new WaitForSeconds(3f);//ESPERA 3 SEGUNDOS
        SceneManager.LoadScene("Login");//PASA A LA SIGUIENTE ESCENA
        

    }



}
