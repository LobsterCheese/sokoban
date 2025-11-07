using UnityEngine;

public class AudioPlayer : Block
{

    AudioSource audioData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        audioData = GetComponent<AudioSource>();
        if (this.gameObject.name == "Smooth")
        {
            Block smoothScript = GetComponent<Block>();
            if (smoothScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
        else if (this.gameObject.name == "Slide")
        {
            Slidey slideScript = GetComponent<Slidey>();
            if (slideScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
        else if (this.gameObject.name == "Stick")
        {
            Sticky stickScript = GetComponent<Sticky>();
            if (stickScript.state == MoveStates.moving)
            {
                audioData.Play(0);
            }
        }
    }
}
