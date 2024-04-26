using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Dice : MonoBehaviour
{
    string hund;
    [SerializeField] Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var random = new System.Random();          // クラスを実体化
        var number = random.Next(00, 100);   // 最大値は未満なので注意（目的の数値 + 1）
        hund = number.ToString().PadLeft(2, '0');
    }

    public void Onehundered()
    {
        text.text = (hund);
    }
}
