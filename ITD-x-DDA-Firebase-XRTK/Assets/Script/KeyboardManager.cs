using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using JetBrains.Annotations;
using UnityEditor.XR.Management;

public class KeyboardManager : MonoBehaviour
{
    static string letter;
    static string num;

    [Header("Text Input")]
    public TMP_InputField textBox;

    // Number Row Function
    public void One()
    {
        num = "1";
        textBox.text += num.ToString();
    }

    public void Two()
    {
        num = "2";
        textBox.text += num.ToString();
    }

    public void Three()
    {
        num = "3";
        textBox.text += num.ToString();
    }

    public void Four()
    {
        num = "4";
        textBox.text += num.ToString();
    }

    public void Five()
    {
        num = "5";
        textBox.text += num.ToString();
    }

    public void Six()
    {
        num = "6";
        textBox.text += num.ToString();
    }

    public void Seven()
    {
        num = "7";
        textBox.text += num.ToString();
    }

    public void Eight()
    {
        num = "8";
        textBox.text += num.ToString();
    }

    public void Nine()
    {
        num = "9";
        textBox.text += num.ToString();
    }

    public void Zero()
    {
        num = "0";
        textBox.text += num.ToString();
    }


    // Alpha Row Function
    public void AInput()
    {
        
        letter = "a";
        textBox.text += letter.ToString();
    }

    public void BInput()
    {
        letter = "b";
        textBox.text += letter.ToString();
    }

    public void CInput()
    {
        letter = "c";
        textBox.text += letter.ToString();
    }

    public void DInput()
    {
        letter = "d";
        textBox.text += letter.ToString();
    }

    public void EInput()
    {
        letter = "e";
        textBox.text += letter.ToString();
    }

    public void FInput()
    {
        letter = "f";
        textBox.text += letter.ToString();
    }

    public void GInput()
    {
        letter = "g";
        textBox.text += letter.ToString();
    }

    public void HInput()
    {
        letter = "h";
        textBox.text += letter.ToString();
    }

    public void IInput()
    {
        letter = "i";
        textBox.text += letter.ToString();
    }

    public void JInput()
    {
        letter = "j";
        textBox.text += letter.ToString();
    }

    public void KInput()
    {
        letter = "k";
        textBox.text += letter.ToString();
    }

    public void LInput()
    {
        letter = "l";
        textBox.text += letter.ToString();
    }

    public void MInput()
    {
        letter = "m";
        textBox.text += letter.ToString();
    }

    public void NInput()
    {
        letter = "n";
        textBox.text += letter.ToString();
    }

    public void OInput()
    {
        letter = "o";
        textBox.text += letter.ToString();
    }

    public void PInput()
    {
        letter = "p";
        textBox.text += letter.ToString();
    }

    public void QInput()
    {
        letter = "q";
        textBox.text += letter.ToString();
    }

    public void RInput()
    {
        letter = "r";
        textBox.text += letter.ToString();
    }

    public void SInput()
    {
        letter = "s";
        textBox.text += letter.ToString();
    }

    public void TInput()
    {
        letter = "t";
        textBox.text += letter.ToString();
    }

    public void UInput()
    {
        letter = "u";
        textBox.text += letter.ToString();
    }

    public void VInput()
    {
        letter = "v";
        textBox.text += letter.ToString();
    }

    public void WInput()
    {
        letter = "w";
        textBox.text += letter.ToString();
    }

    public void XInput()
    {
        letter = "x";
        textBox.text += letter.ToString();
    }

    public void YInput()
    {
        letter = "y";
        textBox.text += letter.ToString();
    }

    public void ZInput()
    {
        letter = "z";
        textBox.text += letter.ToString();
    }

    // Caps Alpha Row Function
    public void AInputCaps()
    {

        letter = "A";
        textBox.text += letter.ToString();
    }

    public void BInputCaps()
    {
        letter = "B";
        textBox.text += letter.ToString();
    }

    public void CInputCaps()
    {
        letter = "C";
        textBox.text += letter.ToString();
    }

    public void DInputCaps()
    {
        letter = "D";
        textBox.text += letter.ToString();
    }

    public void EInputCaps()
    {
        letter = "E";
        textBox.text += letter.ToString();
    }

    public void FInputCaps()
    {
        letter = "F";
        textBox.text += letter.ToString();
    }

    public void GInputCaps()
    {
        letter = "G";
        textBox.text += letter.ToString();
    }

    public void HInputCaps()
    {
        letter = "H";
        textBox.text += letter.ToString();
    }

    public void IInputCaps()
    {
        letter = "I";
        textBox.text += letter.ToString();
    }

    public void JInputCaps()
    {
        letter = "J";
        textBox.text += letter.ToString();
    }

    public void KInputCaps()
    {
        letter = "K";
        textBox.text += letter.ToString();
    }

    public void LInputCaps()
    {
        letter = "L";
        textBox.text += letter.ToString();
    }

    public void MInputCaps()
    {
        letter = "M";
        textBox.text += letter.ToString();
    }

    public void NInputCaps()
    {
        letter = "N";
        textBox.text += letter.ToString();
    }

    public void OInputCaps()
    {
        letter = "O";
        textBox.text += letter.ToString();
    }

    public void PInputCaps()
    {
        letter = "P";
        textBox.text += letter.ToString();
    }

    public void QInputCaps()
    {
        letter = "Q";
        textBox.text += letter.ToString();
    }

    public void RInputCaps()
    {
        letter = "R";
        textBox.text += letter.ToString();
    }

    public void SInputCaps()
    {
        letter = "S";
        textBox.text += letter.ToString();
    }

    public void TInputCaps()
    {
        letter = "T";
        textBox.text += letter.ToString();
    }

    public void UInputCaps()
    {
        letter = "U";
        textBox.text += letter.ToString();
    }

    public void VInputCaps()
    {
        letter = "V";
        textBox.text += letter.ToString();
    }

    public void WInputCaps()
    {
        letter = "W";
        textBox.text += letter.ToString();
    }

    public void XInputCaps()
    {
        letter = "X";
        textBox.text += letter.ToString();
    }

    public void YInputCaps()
    {
        letter = "Y";
        textBox.text += letter.ToString();
    }

    public void ZInputCaps()
    {
        letter = "Z";
        textBox.text += letter.ToString();
    }

    public void BackInput()
    {
        textBox.text = textBox.text.Remove(textBox.text.Length - 1, 1);
        //textBox.GetComponentInChildren<TMP_InputField>().text = textBox.GetComponentInChildren<TMP_InputField>().text.Remove(textBox.GetComponentInChildren<TMP_InputField>().text.Length - 1, 1);
    }

    // Symbol Function

    public void At()
    {
        letter = "@";
        textBox.text += letter.ToString();
    }

    public void hash()
    {
        letter = "#";
        textBox.text += letter.ToString();
    }

    public void dollar()
    {
        letter = "$";
        textBox.text += letter.ToString();
    }

    public void underScore()
    {
        letter = "_";
        textBox.text += letter.ToString();
    }

    public void and()
    {
        letter = "&";
        textBox.text += letter.ToString();
    }

    public void minus()
    {
        letter = "-";
        textBox.text += letter.ToString();
    }

    public void plus() 
    {
        letter = "+";
        textBox.text += letter.ToString();
    }

    public void leftBracket()
    {
        letter = "(";
        textBox.text += letter.ToString();
    }

    public void rightBracket()
    {
        letter = ")";
        textBox.text += letter.ToString();
    }

    public void aterisk()
    {
        letter = "*";
        textBox.text += letter.ToString();
    }

    public void doubleQuote()
    {
        letter = "\"";
        textBox.text += letter.ToString();
    }

    public void singleQuote()
    {
        letter = "'";
        textBox.text += letter.ToString();
    }

    public void colon()
    {
        letter = ":";
        textBox.text += letter.ToString();
    }

    public void semiColon()
    {
        letter = ";";
        textBox.text += letter.ToString();
    }

    public void ExaclaimationMark()
    {
        letter = "!";
        textBox.text += letter.ToString();
    }

    public void QuestionMark()
    {
        letter = "?";
        textBox.text += letter.ToString();
    }
}
