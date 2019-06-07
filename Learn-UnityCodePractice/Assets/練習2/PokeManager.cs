using UnityEngine;

using System;

public class PokeManager : MonoBehaviour
{
    #region 建立物件
    /// <summary>
    /// 名稱 等級 經驗 攻擊力 防禦力 血量/血量
    /// </summary>
    public Pokemon firstPet = new Pokemon("小火龍",10,10,4,5,15,15);
    #endregion
    private void Start()
    {
        //呼叫lvch方法顯示基本屬性
        firstPet.lvch();
    }

    
}