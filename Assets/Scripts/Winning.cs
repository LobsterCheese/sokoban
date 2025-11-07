using UnityEngine;

public class Winning : MonoBehaviour
{

    [SerializeField] public bool win = false;
    WinChecker winChecker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        winChecker = GameObject.FindGameObjectWithTag("WinChecker").GetComponent<WinChecker>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "block")
        {
            win = true;
            winChecker.CheckLayout();
        }
    }
}
