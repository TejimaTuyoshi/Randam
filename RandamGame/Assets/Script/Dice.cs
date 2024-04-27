using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    string _hund;
    string _six;
    string _three;
    string _four;
    string _threeToTwo;
    string _twenty;
    [SerializeField] Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var random = new System.Random();         
        var number = random.Next(00, 100);   // 100面ダイス用
        var num = random.Next(01, 07);//6面ダイス用
        var num2 = random.Next(01, 04);//3面ダイス用
        var num3 = random.Next(01, 05);//4面ダイス用
        var num4 = random.Next(01, 04) + random.Next(01, 04);//3面2回ダイス用
        var num5 = random.Next(01, 21);//20面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        _six = num.ToString().PadLeft(1, '0');
        _three = num2.ToString().PadLeft(1, '0');
        _four = num3.ToString().PadLeft(1, '0');
        _threeToTwo = num4.ToString().PadLeft(1, '0');
        _twenty = num5.ToString().PadLeft(2, '0');
    }

    public void Onehundered()
    {
        text.text = (_hund);
    }
    public void Six()
    {
        text.text = (_six);
    }
    public void Three()
    {
        text.text = (_three);
    }
    public void Four()
    {
        text.text = (_four);
    }
    public void ThreeToTwo()
    {
        text.text = (_threeToTwo);
    }
    public void Twenty()
    {
        text.text = (_twenty);
    }
}
