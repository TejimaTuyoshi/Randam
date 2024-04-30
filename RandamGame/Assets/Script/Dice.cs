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
    bool _resultST = false;
    bool _resultC = false;
    bool _resultP = false;
    bool _resultD = false;
    bool _resultA = false;
    bool _resultSI = false;
    bool _resultI = false;
    bool _resultE = false;
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
        if (_str * 5 >= number) 
        {
            _resultST = true;
        }
        else if (_siz * 5 >= number)
        {
            _resultSI = true;
        }
        else if (_pow * 5 >= number)
        {
            _resultP = true;
        }
        else if (_int * 5 >= number)
        {
            _resultI = true;
        }
        else if (_app * 5 >= number)
        {
            _resultA = true;
        }
        else if (_con * 5 >= number)
        {
            _resultC = true;
        }
        else if (_dex * 5 >= number)
        {
            _resultD = true;
        }
        else if (_edu * 5 >= number)
        {
            _resultE = true;
        }
        else 
        {
            _resultST = false;
            _resultC = false;
            _resultP = false;
            _resultD = false;
            _resultA = false;
            _resultSI = false;
            _resultI = false;
            _resultE = false;
        }
    }

    public void OnehunderedST()
    {
        if (_resultST) 
        {
            text.text = (_hund + "　成功");
        }
        else 
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedC()
    {
        if (_resultC)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }

    }
    public void OnehunderedP()
    {
        if (_resultP)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedD()
    {
        if (_resultD)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedA()
    {
        if (_resultA)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedSI()
    {
        if (_resultSI)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedI()
    {
        if (_resultI)
        {
            text.text = (_hund + "　成功");
        }
        else
        {
            text.text = (_hund + "　失敗");
        }
    }
    public void OnehunderedE()
    {
        if (_resultE)
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

    public void STadd()
    {
        _str += 1;
    }
    public void Cadd()
    {
        _con += 1;
    }
    public void Padd()
    {
        _pow += 1;
    }
    public void Dadd()
    {
        _dex += 1;
    }
    public void Aadd()
    {
        _app += 1;
    }
    public void SIadd()
    {
        _siz += 1;
    }
    public void Iadd()
    {
        _int += 1;
    }
    public void Eadd()
    {
        _edu += 1;
    }
    public void STminus()
    {
        _str -= 1;
    }
    public void Cminus()
    {
        _con -= 1;
    }
    public void Pminus()
    {
        _pow -= 1;
    }
    public void Dminus()
    {
        _dex -= 1;
    }
    public void Aminus()
    {
        _app -= 1;
    }
    public void SIminus()
    {
        _siz -= 1;
    }
    public void Iminus()
    {
        _int -= 1;
    }
    public void Eminus()
    {
        _edu -= 1;
    }
}
