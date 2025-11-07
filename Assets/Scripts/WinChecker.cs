using UnityEngine;
using UnityEngine.SceneManagement;

public class WinChecker : MonoBehaviour
{
    [SerializeField] private GameObject[] WinBoxes;
    [SerializeField] string nextLevel;
    private bool[] filledBoxes;
    string thisScene;
    bool allTrue;

    public delegate void LevelClearDelegate();

    //create event
    //public static event LevelClearDelegate LevelClear;

    void Start()
    {
        thisScene = SceneManager.GetActiveScene().name;
        WinBoxes = GameObject.FindGameObjectsWithTag("Win");
    }


    public void CheckLayout()
    {
        filledBoxes = new bool[WinBoxes.Length];

        for (int i = 0; i < WinBoxes.Length; i++)
        {
            filledBoxes[i] = WinBoxes[i].GetComponent<Winning>().win;
        }

        allTrue = true;

        for (int i = 0; i < WinBoxes.Length; i++)
        {
            if (filledBoxes[i] == false)
            {
                allTrue = false;
            }
        }
    }

    void Update()
    {
        if (allTrue)
        {
            if (Input.GetKey(KeyCode.P))
            {
                if (SceneManager.GetActiveScene().name == "DemoLevel")
                {
                    SceneManager.LoadScene("DemoLevel 1");
                }
                if (SceneManager.GetActiveScene().name == "DemoLevel")
                {
                    SceneManager.LoadScene("DemoLevel 1");
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}