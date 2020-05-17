using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    #region 練習1
    [Header("血條Bar")]
    public Slider slider;
    public HP hp;
    [Header("提示字")]
    public Text alert;
    #endregion

    #region 練習2
    [Header("輸入道具")]
    public InputField props;
    [Header("判斷結果")]
    public Text result;
    #endregion

    #region 練習3
    public GameObject cube;

    public void CreateTriangle(int min , int max)
    {
        for (int i = min; i <= max; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Instantiate(cube,new Vector3(i * 2, j * 2, 0),Quaternion.Euler(270,0,0));
            }
        }
    }
    #endregion

    private void Awake()
    {
        CreateTriangle(1, 10);
    }

    private void Update()
    {
        #region 練習1
        hp.hp = (int)slider.value;
        Debug.Log(hp.hp);
        if (hp.hp >= 70)
        {
            alert.text = "<color=#00DB00>" + "安全" + "</color>";
        }
        else if(hp.hp >= 30)
        {
            alert.text = "<color=#FFE153>" + "警告" + "</color>";
        }
        else if(hp.hp > 0)
        {
            alert.text = "<color=#FF0000>" + "危險" + "</color>";
        }
        else
        {
            alert.text = "<color=#4F4F4F>" + "你掛囉" + "</color>";
        }
        #endregion

        #region 練習2
        result.text = props.text == "紅水" ? "<color=#FF0000>" + "恢復血量" + "</color>" 
                                    : props.text == "藍水" ? "<color=#0080FF>" + "恢復魔力" + "</color>" 
                                    : props.text == "" ? ""
                                    : "<color=#4F4F4F>" + "輸入錯囉" + "</color>";
        #endregion
    }
}
