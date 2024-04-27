using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    string _hund;
    string _six;
    string _three;
    string _four;
    string _threeToTwo;
    string _twenty;
    [SerializeField] int _str = 9;
    [SerializeField] int _con = 9;
    [SerializeField] int _pow = 9;
    [SerializeField] int _dex = 9;
    [SerializeField] int _app = 9;
    [SerializeField] int _siz = 9;
    [SerializeField] int _int = 9;
    [SerializeField] int _edu = 9;
    bool _result = false;
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
        if (_str * 5 >= number ||_siz * 5 >= number ||_pow * 5 >= number ||_int * 5 >= number ||_app * 5 >= number ||_con * 5 >= number ||_dex * 5 >= number ||_edu * 5 >= number) 
        {
            _result = true;
        }
    }

    public void Onehundered()
    {
        if (_result) 
        {
            text.text = (_hund + "　成功");
        }
        else 
        {
            text.text = (_hund + "　失敗");
        }
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
