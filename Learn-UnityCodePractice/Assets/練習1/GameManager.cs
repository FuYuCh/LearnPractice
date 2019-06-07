using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region //建立Student物件
    public Student student1 = new Student("Jane",-10);

    #endregion

    #region  事件
    private void Start()  //這是Unity程式的進入點
    {
        Debug.Log(student1.GetMsg());
        
    }

    #endregion
}