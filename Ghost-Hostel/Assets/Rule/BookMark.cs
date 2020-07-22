using UnityEngine;
using UnityEngine.SceneManagement;

//   切換關卡

public class BookMark : MonoBehaviour
{
    // 方法
    // public void 名稱 () {  }

    public void CharacterBook()
    {
        SceneManager.LoadScene("CharacterBook");
    }
}
