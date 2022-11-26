using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
	public TMP_InputField iptUser;
	public TMP_InputField iptPass;
    public TMP_Text txtMesage;

    public Button btnLogin;

	private void Start()
	{
		btnLogin.onClick.AddListener(goToMenu);
	}

	private void goToMenu()
	{
        StartCoroutine(Upload());

        IEnumerator Upload()
        {
            WWWForm form = new WWWForm();
            form.AddField("userPost", iptUser.text);
            form.AddField("passPost", iptPass.text);

            UnityWebRequest request = UnityWebRequest.Post("https://www.amano.com.py/una/backend/login.php", form);
            yield return request.Send();

            if (request.isNetworkError)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("Form upload complete!" + request.downloadHandler.text);

                if (Convert.ToBoolean(request.downloadHandler.text))
                {
                    Debug.Log("Login succes");
                    SceneManager.LoadScene("Menu");
                }
                else 
                {
                    StartCoroutine(Feedback());

                    IEnumerator Feedback()
                    {
                        txtMesage.text = "Datos incorrectos";
                        yield return new WaitForSeconds(3);
                        txtMesage.text = "";
                    }                        
                }

            }
        }
    }

    
}
