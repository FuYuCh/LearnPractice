using UnityEngine;
using System;

[System.Serializable]

public class Pokemon
{
    #region  //基本欄位
    /// <summary>
    /// 基本欄位
    /// </summary>
    public string Name; //名稱

    private int _lv;  //等級
    private int _att; //Attack
    private int _def; //Defense
    private int _blood; //Blood
    private int _blood2; //blood2   20/20
    private int _exp;  //經驗
    #endregion

    #region //建構式 初始化成員資料
    /// <summary>
    /// 建構式  欄位
    /// </summary>
    /// <param name="vName"></param>
    /// <param name="vLv"></param>
    /// <param name="vExp"></param>
    /// <param name="vAtt"></param>
    /// <param name="vDef"></param>
    /// <param name="vBlood"></param>
    /// <param name="vBlood2"></param>
    public Pokemon(string vName, int vLv, int vExp, int vAtt, int vDef, int vBlood,int vBlood2)
    {
        Name = vName;
        _lv = vLv;
        _exp = vExp;
        _att = vAtt;
        _def = vDef;
        _blood = vBlood;
        _blood2 = vBlood2;      
    }
   
    /// <summary>
    /// 建立經驗屬性 設定一開始經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            return _exp;
        }
        set
        {
            if (value <= 0) value = 10;
            _exp = value;
        }
    }
    #endregion

    #region  傳回方法 
    /// <summary>
    /// 傳回方法 適用於小火龍的配置
    /// </summary>
    /// <returns> 顯示不同等級、經驗、攻擊、防禦、血量變化</returns>
    public string GetPoke()
    {
        return Name + "  "+"等級: " + _lv.ToString() +"  "+ "經驗值: " + _exp.ToString() +"  "+ "攻擊力 :" + _att.ToString()
               +"  "+ "防禦力: " + _def.ToString() +"  "+ "血量: " + _blood.ToString() + "/" + _blood2.ToString();
    }
    public string GetPoke2()
    {
        _exp = _exp * _lv;
        _att = (_att + (_lv * 2));
        _def = (_def + (_lv * 2));
        _blood = (_blood + (_lv * 2));
        _blood2 = (_blood2 + (_lv * 2));
        return Name + "  " + "等級: " + _lv.ToString() + "  " + "經驗值: " + _exp.ToString() + "  " + "攻擊力 :" + _att.ToString()
               + "  " + "防禦力: " + _def.ToString() + "  " + "血量: " + _blood.ToString() + "/" + _blood2.ToString();
    }
    #endregion
    /// <summary>
    /// 等級1的時候回傳一開始配置
    /// </summary>
    public void lvch()
    {
        if (_lv == 1)
        {
            Debug.Log(GetPoke());
        }
        else
        {
            Debug.Log(GetPoke2());
        }
    }
}
