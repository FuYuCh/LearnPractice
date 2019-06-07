using UnityEngine;

[System.Serializable]

public class Student  //定義Student類別
{
    #region  欄位
    public string Name;
    private int _score;
    #endregion

    /// <summary>
    /// 設定分數並限制範圍
    /// </summary>
    public int Score    //建立Score屬性
    {
        get { return _score; }
        set
        {
            if (value >= 100) value = 100;
            if (value <= 0) value = 0;
            _score = value;
        }
    }
    #region 建構函式
    public Student() { }  //無引數的建構式 1

    public Student(string _vName)  //可設定姓名的建構式 2
    {
        Name = _vName;
    }

    public Student(string _vName, int _vScore) //可設定分數姓名的建構式 3
    {
        Name = _vName;
        Score = _vScore;
    }
    #endregion
    #region 方法
    /// <summary>
    /// 顯示姓名分數方法
    /// </summary>
    /// <returns>顯示姓名分數</returns>
    public string GetMsg()
    {
        return Name + "同學的分數是" + _score;
    }
    #endregion

}