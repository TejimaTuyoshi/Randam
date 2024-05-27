using TMPro.EditorUtilities;
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
    [SerializeField] int _move = 0;
    [SerializeField] int _str = 9;
    [SerializeField] int _con = 9;
    [SerializeField] int _pow = 9;
    [SerializeField] int _dex = 9;
    [SerializeField] int _app = 9;
    [SerializeField] int _siz = 9;
    [SerializeField] int _int = 9;
    [SerializeField] int _edu = 9;
    [SerializeField] int _hp = 0;
    [SerializeField] bool _resultST = false;
    [SerializeField] bool _resultC = false;
    [SerializeField] bool _resultP = false;
    [SerializeField] bool _resultD = false;
    [SerializeField] bool _resultA = false;
    [SerializeField] bool _resultSI = false;
    [SerializeField] bool _resultI = false;
    [SerializeField] bool _resultE = false;
    [SerializeField] bool _result = false;
    [SerializeField] bool _plus = false;
    [SerializeField] bool _Happening = false;
    [SerializeField] Text text;
    [SerializeField] Text text2;
    [SerializeField] Text text3;
    [SerializeField] Text text4;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject MinusPanel;
    [SerializeField] GameObject MinusPanel2;
    [SerializeField] GameObject MinusPanel3;
    [SerializeField] GameObject MinusPanel4;
    [SerializeField] GameObject MinusPanel5;
    [SerializeField] GameObject MinusPanel6;
    [SerializeField] GameObject PlusPanel;
    [SerializeField] GameObject PlusPanel2;
    [SerializeField] GameObject PlusPanel3;
    [SerializeField] GameObject PlusPanel4;
    [SerializeField] GameObject PlusPanel5;
    [SerializeField] GameObject PlusPanel6;
    [SerializeField] GameObject HappeningPanel;
    [SerializeField] GameObject HappeningPanel2;
    [SerializeField] GameObject HappeningPanel3;
    [SerializeField] GameObject HappeningPanel4;
    [SerializeField] GameObject HappeningPanel5;
    [SerializeField] GameObject HappeningPanel6;
    [SerializeField] GameObject ShopPanel;

    // Start is called before the first frame update
    void Start()
    {
        _hp = _con + _siz;
    }

    // Update is called once per frame
    void Update()
    {
        text2.text = ("STR:" + _str + " CON:" + _con + " POW:" + _pow + " DEX:" + _dex + " APP:" + _app + " SIZ:" + _siz + " INT:" + _int + " EDU:" + _edu);
        text3.text = ("HP:" + _hp + " / " + (_con + _siz));

        if (!_resultST && _result == true)
        {
            _result = false;
            _str--;
        }
        if (!_resultC && _result == true)
        {
            _result = false;
            _con--;
        }
        if (!_resultP && _result == true)
        {
            _result = false;
            _pow--;
        }
        if (!_resultD && _result == true)
        {
            _result = false;
            _dex--;
        }
        if (!_resultA && _result == true)
        {
            _result = false;
            _app--;
        }
        if (!_resultSI && _result == true)
        {
            _result = false;
            _siz--;
        }
        if (!_resultI && _result == true)
        {
            _result = false;
            _int--;
        }
        if (!_resultE && _result == true)
        {
            _result = false;
            _edu--;
        }
        if (!_resultST && _plus == true)
        {
            _plus = false;
            _str++;
        }
        if (!_resultC && _plus == true)
        {
            _plus = false;
            _con++;
        }
        if (!_resultP && _plus == true)
        {
            _plus = false;
            _pow++;
        }
        if (!_resultD && _plus == true)
        {
            _plus = false;
            _dex++;
        }
        if (!_resultA && _plus == true)
        {
            _plus = false;
            _app++;
        }
        if (!_resultSI && _plus == true)
        {
            _plus = false;
            _siz++;
        }
        if (!_resultI && _plus == true)
        {
            _plus = false;
            _int++;
        }
        if (!_resultE && _plus == true)
        {
            _plus = false;
            _edu++;
        }
        if (_resultST && _Happening == true)
        {
            _Happening = false;
            _str++;
            _app--;
        }
        if (_resultC && _Happening == true)
        {
            _Happening = false;
            _con++;
            _pow--;
        }
        if (_resultP && _Happening == true)
        {
            _Happening = false;
            _pow++;
            _con--;
        }
        if (_resultD && _Happening == true)
        {
            _Happening = false;
            _dex++;
            _siz--;
        }
        if (_resultA && _Happening == true)
        {
            _Happening = false;
            _app++;
            _str--;
        }
        if (_resultSI && _Happening == true)
        {
            _Happening = false;
            _siz++;
            _dex--;
        }
        if (_resultI && _Happening == true)
        {
            _Happening = false;
            _int++;
            _edu--;
        }
        if (_resultE && _Happening == true)
        {
            _Happening = false;
            _edu++;
            _int--;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Battle"))
        {
            Panel.SetActive(true);
        }
        if (other.gameObject.CompareTag("Minus"))
        {
            switch (_move)
            {
                case 1:
                    MinusPanel.SetActive(true);
                    text4.text = ("狂人が現れ、\r\n「化物!」と襲い掛かってきた！");
                    break;
                case 2:
                    MinusPanel2.SetActive(true);
                    text4.text = ("自信が発生!\r\n足場が崩れそうだ...");
                    break;
                case 3:
                    MinusPanel3.SetActive(true);
                    text4.text = ("壁が現れ、\r\n基本教養を求めてきた!");
                    break;
                case 4:
                    MinusPanel4.SetActive(true);
                    text4.text = ("足を滑らせ、\r\n奈落に落ちそうだ!");
                    break;
                case 5:
                    MinusPanel5.SetActive(true);
                    text4.text = ("墓場を発見!\r\nしかし、墓から手が伸びてきた!");
                    break;
                case 6:
                    MinusPanel6.SetActive(true);
                    text4.text = ("爆弾が音を立てている状況に遭遇!\r\nあと少しで爆発しそう...");
                    break;
            }
        }
        if (other.gameObject.CompareTag("Plus"))
        {
            switch (_move)
            {
                case 1:
                    PlusPanel.SetActive(true);
                    text4.text = ("休憩として瞑想していたら、\r\n何か思いつきそう!(成長判定=失敗で成長)");
                    break;
                case 2:
                    PlusPanel2.SetActive(true);
                    text4.text = ("湧水を飲んだ時、\r\n頭が冴えわたる!(成長判定=失敗で成長)");
                    break;
                case 3:
                    PlusPanel3.SetActive(true);
                    text4.text = ("突然妖精が現れ、\r\n助けてくれるらしいが...?(成長判定=失敗で成長)");
                    break;
                case 4:
                    PlusPanel4.SetActive(true);
                    text4.text = ("探索していたら、\r\n書斎を見つけたが荒らされている...(成長判定=失敗で成長)");
                    break;
                case 5:
                    PlusPanel5.SetActive(true);
                    text4.text = ("人助けをしたところ、叡智を\r\nくれるというが...?(成長判定=失敗で成長)");
                    break;
                case 6:
                    PlusPanel6.SetActive(true);
                    text4.text = ("協会で手を沿えた所、\r\n何者かの声が聞こえてきた...(成長判定=失敗で成長)");
                    break;
            }
        }
        if (other.gameObject.CompareTag("Happening"))
        {
            switch (_move)
            {
                case 1:
                    HappeningPanel.SetActive(true);
                    text4.text = ("商人が現れ、\r\n取引を持ちかける...");
                    break;
                case 2:
                    HappeningPanel2.SetActive(true);
                    text4.text = ("廃墟にて機械を見つけたが...");
                    break;
                case 3:
                    HappeningPanel3.SetActive(true);
                    text4.text = ("博士と名乗る人物が、\r\n「強くするヨ?」と持ちかけてきた...");
                    break;
                case 4:
                    HappeningPanel4.SetActive(true);
                    text4.text = ("謎の銅像を見つけたので\r\n祈ってみると...");
                    break;
                case 5:
                    HappeningPanel5.SetActive(true);
                    text4.text = ("「代償の間」を見つけたが、\r\n代償にするものなんて...");
                    break;
                case 6:
                    HappeningPanel6.SetActive(true);
                    text4.text = ("謎の食べ物を手に入れたが、\r\n嫌な予感がする...");
                    break;
            }
        }
        if (other.gameObject.CompareTag("Heal"))
        {
            if (_hp < (_con + _siz))
            {
                text4.text = ("HPが回復した!ﾔｯﾀﾈ!");
                HP();
            }
            else if (_hp > (_con + _siz)) 
            {
                text4.text = ("HPが多いので採血されちゃった...");
                --_hp;
            }
            else
            {
                text4.text = ("しかし何も起こらなかった...");
            }
        }
        if (other.gameObject.CompareTag("Shop"))
        { ShopPanel.SetActive(true); }
    }

    public void HP()
    { _hp++; }

    public void Result()
    { _result = true; }
    public void Plus()
    { _plus = true; }
    public void Happening()
    { _Happening = true; }
    public void NonText()
    { text4.text = ("何も買わなかった..."); }
    public void Blank()
    { text4.text = (" "); }


    public void OnehunderedST()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);
        _hund = number.ToString().PadLeft(2, '0');
        if (_str * 5 >= number)
        { _resultST = true; }
        else
        { _resultST = false; }
        if (_resultST)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedC()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_con * 5 >= number)
        { _resultC = true; }
        else
        { _resultC = false; }
        if (_resultC)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }

    }
    public void OnehunderedP()
    {
        var random = new System.Random();
        var number = random.Next();   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_pow * 5 >= number)
        { _resultP = true; }
        else
        { _resultP = false; }
        if (_resultP)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedD()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_dex * 5 >= number)
        { _resultD = true; }
        else
        { _resultD = false; }
        if (_resultD)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedA()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_app * 5 >= number)
        { _resultA = true; }
        else
        { _resultA = false; }
        if (_resultA)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedSI()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_siz * 5 >= number)
        { _resultSI = true; }
        else
        { _resultSI = false; }
        if (_resultSI)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedI()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_int * 5 >= number)
        { _resultI = true; }
        else
        { _resultI = false; }
        if (_resultI)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void OnehunderedE()
    {
        var random = new System.Random();
        var number = random.Next(01, 101);   // 100面ダイス用
        _hund = number.ToString().PadLeft(2, '0');
        if (_edu * 5 >= number)
        { _resultE = true; }
        else
        { _resultE = false; }
        if (_resultE)
        { text.text = (_hund + "　成功"); }
        else
        {
            text.text = (_hund + "　失敗");
            _hp--;
        }
    }
    public void Six()
    {
        var random = new System.Random();
        var num = random.Next(01, 07);//6面ダイス用
        _move = num;
        _six = num.ToString().PadLeft(1, '0');
        text.text = (_six);
        transform.position += transform.TransformDirection(Vector3.forward) * _move;//マス目移動なので今回はフレーム計算は無し。
    }
    public void Three()
    {
        var random = new System.Random();
        var num2 = random.Next(01, 04);//3面ダイス用
        _three = num2.ToString().PadLeft(1, '0');
        text.text = (_three);
    }
    public void Four()
    {
        var random = new System.Random();
        var num3 = random.Next(01, 05);//4面ダイス用
        _four = num3.ToString().PadLeft(1, '0');
        text.text = (_four);
    }
    public void ThreeToTwo()
    {
        var random = new System.Random();
        var num4 = random.Next(01, 04) + random.Next(01, 04);//3面2回ダイス用
        _threeToTwo = num4.ToString().PadLeft(1, '0');
        text.text = (_threeToTwo);
    }
    public void Twenty()
    {
        var random = new System.Random();
        var num5 = random.Next(01, 21);//20面ダイス用
        _twenty = num5.ToString().PadLeft(2, '0');
        text.text = (_twenty);
    }

    public void STadd()
    { _str++; }
    public void Cadd()
    { _con++; }
    public void Padd()
    { _pow++; }
    public void Dadd()
    { _dex++; }
    public void Aadd()
    { _app++; }
    public void SIadd()
    { _siz++; }
    public void Iadd()
    { _int++; }
    public void Eadd()
    { _edu++; }


    public void Ddol()
    {
        DontDestroyOnLoad(text2);
        DontDestroyOnLoad(text3);
    }
}
