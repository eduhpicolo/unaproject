using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void goToNivel1() {
        SceneManager.LoadScene("Level 1");
    }
    public void goToLogin()
    {

        SceneManager.LoadScene("Login");
    }

}
