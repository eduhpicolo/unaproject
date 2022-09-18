using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour
{
	public GameObject inputFieldUsuario;
	public GameObject inputFieldContrasena;
    public GameObject textMensaje;

    TMP_InputField usuario;
    TMP_InputField contrasena ;
  
    public void Start()
        {
         usuario = inputFieldUsuario.GetComponent<TMP_InputField>();
         contrasena = inputFieldContrasena.GetComponent<TMP_InputField>();
    }
    public void goToMenu()
	{
        if (usuario.text.Equals("gabriel")
			&& contrasena.text.Equals("123"))
        {
			SceneManager.LoadScene("Menu");
        }
        else
        {
            textMensaje.GetComponent<TMP_Text>().text = "Datos incorrectos";
        }
		
    }
}
