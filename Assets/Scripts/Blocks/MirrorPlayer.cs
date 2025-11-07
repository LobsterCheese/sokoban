using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MirrorPlayer : Block
{

    [SerializeField]
    private Animator myAnim;

    private void Update()
    {
        if (State == MoveStates.idle) MoveInput();
    }

    private void MoveInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("bruh");
            if (CheckMove(-1, 0)) transform.rotation = Quaternion.LookRotation(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (CheckMove(1, 0)) transform.rotation = Quaternion.LookRotation(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (CheckMove(0, -1)) transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (CheckMove(0, 1)) transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }

    protected override void StartMove(Cell newParent, int _deltaX, int _deltaY)
    {
        myAnim.SetBool("isMoving", true);
        base.StartMove(newParent, _deltaX, _deltaY);
    }

    protected override void FinishMove()
    {
        myAnim.SetBool("isMoving", false);
        base.FinishMove();
    }

}
