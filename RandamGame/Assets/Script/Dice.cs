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
        var random = new System.Random();          // �N���X�����̉�
        var number = random.Next(00, 100);   // �ő�l�͖����Ȃ̂Œ��Ӂi�ړI�̐��l + 1�j
        hund = number.ToString().PadLeft(2, '0');
    }

    public void Onehundered()
    {
        text.text = (hund);
    }
}
