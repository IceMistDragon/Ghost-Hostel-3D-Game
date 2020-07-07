using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


//主角摸到出口門  遊戲結束

public class GAMEOVER : MonoBehaviour
{
    public FirstPersonController fpc;
    public GameObject final;

    private void Start()
    {
        Cursor.visible = false;                           //指標隱藏
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "Export")
        {
            final.SetActive(true);
            fpc.enabled = false;
            Cursor.visible = true;
            
            
        }
    }
}
