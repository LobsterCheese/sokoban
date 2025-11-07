using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    /*
    [SerializeField] private Image mySquare;
    [SerializeField] private TMP_Text scoreText;
    private int scoreValue = 0;
    */

    void Start()
    {

    }

    public void ButtonClick()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("DemoLevel");
    }
}