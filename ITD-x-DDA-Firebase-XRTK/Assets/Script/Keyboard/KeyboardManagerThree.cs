using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardManagerThree : MonoBehaviour
{
    static string letter;
    static string num;

    [Header("Text Input")]
    public TMP_InputField ResPWD;

    [Header("UnCap Alpha")]
    public Button a;
    public Button b;
    public Button c;
    public Button d;
    public Button e;
    public Button f;
    public Button g;
    public Button h;
    public Button i;
    public Button j;
    public Button k;
    public Button l;
    public Button m;
    public Button n;
    public Button o;
    public Button p;
    public Button q;
    public Button r;
    public Button s;
    public Button t;
    public Button u;
    public Button v;
    public Button w;
    public Button x;
    public Button y;
    public Button z;

    [Header("Caps Alpha")]
    public Button A;
    public Button B;
    public Button C;
    public Button D;
    public Button E;
    public Button F;
    public Button G;
    public Button H;
    public Button I;
    public Button J;
    public Button K;
    public Button L;
    public Button M;
    public Button N;
    public Button O;
    public Button P;
    public Button Q;
    public Button R;
    public Button S;
    public Button T;
    public Button U;
    public Button V;
    public Button W;
    public Button X;
    public Button Y;
    public Button Z;

    [Header("Symbols and Numbers")]
    public Button NumOne;
    public Button NumTwo;
    public Button NumThree;
    public Button NumFour;
    public Button NumFive;
    public Button NumSix;
    public Button NumSeven;
    public Button NumEight;
    public Button NumNine;
    public Button NumZero;

    public Button At;
    public Button Hash;
    public Button Dollar;
    public Button UnderScore;
    public Button And;
    public Button Minus;
    public Button Plus;
    public Button LeftBracket;
    public Button RightBracket;
    public Button Asterisk;
    public Button DoubleQuote;
    public Button SingleQuote;
    public Button Colon;
    public Button SimiColon;
    public Button ExaclaimationMark;
    public Button QuestionMark;

    private void Start()
    {
        // Uncap Alpha Button
        a.onClick.AddListener(AInput);
        b.onClick.AddListener(BInput);
        c.onClick.AddListener(CInput);
        d.onClick.AddListener(DInput);
        e.onClick.AddListener(EInput);
        f.onClick.AddListener(FInput);
        g.onClick.AddListener(GInput);
        h.onClick.AddListener(HInput);
        i.onClick.AddListener(IInput);
        j.onClick.AddListener(JInput);
        k.onClick.AddListener(KInput);
        l.onClick.AddListener(LInput);
        m.onClick.AddListener(MInput);
        n.onClick.AddListener(NInput);
        o.onClick.AddListener(OInput);
        p.onClick.AddListener(PInput);
        q.onClick.AddListener(QInput);
        r.onClick.AddListener(RInput);
        s.onClick.AddListener(SInput);
        t.onClick.AddListener(TInput);
        u.onClick.AddListener(UInput);
        v.onClick.AddListener(VInput);
        w.onClick.AddListener(WInput);
        x.onClick.AddListener(XInput);
        y.onClick.AddListener(YInput);
        z.onClick.AddListener(ZInput);
        
        // Caps Alpha Buttons
        A.onClick.AddListener(AInputCaps);
        B.onClick.AddListener(BInputCaps);
        C.onClick.AddListener(CInputCaps);
        D.onClick.AddListener(DInputCaps);
        E.onClick.AddListener(EInputCaps);
        F.onClick.AddListener(FInputCaps);
        G.onClick.AddListener(GInputCaps);
        H.onClick.AddListener(HInputCaps);
        I.onClick.AddListener(IInputCaps);
        J.onClick.AddListener(JInputCaps);
        K.onClick.AddListener(KInputCaps);
        L.onClick.AddListener(LInputCaps);
        M.onClick.AddListener(MInputCaps);
        N.onClick.AddListener(NInputCaps);
        O.onClick.AddListener(OInputCaps);
        P.onClick.AddListener(PInputCaps);
        Q.onClick.AddListener(QInputCaps);
        R.onClick.AddListener(RInputCaps);
        S.onClick.AddListener(SInputCaps);
        T.onClick.AddListener(TInputCaps);
        U.onClick.AddListener(UInputCaps);
        V.onClick.AddListener(VInputCaps);
        W.onClick.AddListener(WInputCaps);
        X.onClick.AddListener(XInputCaps);
        Y.onClick.AddListener(YInputCaps);
        Z.onClick.AddListener(ZInputCaps);

        // Symbol & Number Buttons
        NumOne.onClick.AddListener(One);
        NumTwo.onClick.AddListener(Two);
        NumThree.onClick.AddListener(Three);
        NumFour.onClick.AddListener(Four);
        NumFive.onClick.AddListener(Five);
        NumSix.onClick.AddListener(Six);
        NumSeven.onClick.AddListener(Seven);
        NumEight.onClick.AddListener(Eight);
        NumNine.onClick.AddListener(Nine);
        NumZero.onClick.AddListener(Zero);

        At.onClick.AddListener(at);
        Hash.onClick.AddListener(hash);
        Dollar.onClick.AddListener(dollar);
        UnderScore.onClick.AddListener(underScore);
        And.onClick.AddListener(and);
        Minus.onClick.AddListener(minus);
        Plus.onClick.AddListener(plus);
        LeftBracket.onClick.AddListener(leftBracket);
        RightBracket.onClick.AddListener(rightBracket);
        Asterisk.onClick.AddListener(aterisk);
        DoubleQuote.onClick.AddListener(doubleQuote);
        SingleQuote.onClick.AddListener(singleQuote);
        Colon.onClick.AddListener(colon);
        SimiColon.onClick.AddListener(semiColon);
        ExaclaimationMark.onClick.AddListener(exaclaimationMark);
        QuestionMark.onClick.AddListener(questionMark);
        QuestionMark.onClick.AddListener(questionMark);
    }


    // Number Row Function
    public void One()
    {
        num = "1";
        ResPWD.text += num.ToString();
    }

    public void Two()
    {
        num = "2";
        ResPWD.text += num.ToString();
    }

    public void Three()
    {
        num = "3";
        ResPWD.text += num.ToString();
    }

    public void Four()
    {
        num = "4";
        ResPWD.text += num.ToString();
    }

    public void Five()
    {
        num = "5";
        ResPWD.text += num.ToString();
    }

    public void Six()
    {
        num = "6";
        ResPWD.text += num.ToString();
    }

    public void Seven()
    {
        num = "7";
        ResPWD.text += num.ToString();
    }

    public void Eight()
    {
        num = "8";
        ResPWD.text += num.ToString();
    }

    public void Nine()
    {
        num = "9";
        ResPWD.text += num.ToString();
    }

    public void Zero()
    {
        num = "0";
        ResPWD.text += num.ToString();
    }


    // Alpha Row Function
    public void AInput()
    {
        
        letter = "a";
        ResPWD.text += letter.ToString();
    }

    public void BInput()
    {
        letter = "b";
        ResPWD.text += letter.ToString();
    }

    public void CInput()
    {
        letter = "c";
        ResPWD.text += letter.ToString();
    }

    public void DInput()
    {
        letter = "d";
        ResPWD.text += letter.ToString();
    }

    public void EInput()
    {
        letter = "e";
        ResPWD.text += letter.ToString();
    }

    public void FInput()
    {
        letter = "f";
        ResPWD.text += letter.ToString();
    }

    public void GInput()
    {
        letter = "g";
        ResPWD.text += letter.ToString();
    }

    public void HInput()
    {
        letter = "h";
        ResPWD.text += letter.ToString();
    }

    public void IInput()
    {
        letter = "i";
        ResPWD.text += letter.ToString();
    }

    public void JInput()
    {
        letter = "j";
        ResPWD.text += letter.ToString();
    }

    public void KInput()
    {
        letter = "k";
        ResPWD.text += letter.ToString();
    }

    public void LInput()
    {
        letter = "l";
        ResPWD.text += letter.ToString();
    }

    public void MInput()
    {
        letter = "m";
        ResPWD.text += letter.ToString();
    }

    public void NInput()
    {
        letter = "n";
        ResPWD.text += letter.ToString();
    }

    public void OInput()
    {
        letter = "o";
        ResPWD.text += letter.ToString();
    }

    public void PInput()
    {
        letter = "p";
        ResPWD.text += letter.ToString();
    }

    public void QInput()
    {
        letter = "q";
        ResPWD.text += letter.ToString();
    }

    public void RInput()
    {
        letter = "r";
        ResPWD.text += letter.ToString();
    }

    public void SInput()
    {
        letter = "s";
        ResPWD.text += letter.ToString();
    }

    public void TInput()
    {
        letter = "t";
        ResPWD.text += letter.ToString();
    }

    public void UInput()
    {
        letter = "u";
        ResPWD.text += letter.ToString();
    }

    public void VInput()
    {
        letter = "v";
        ResPWD.text += letter.ToString();
    }

    public void WInput()
    {
        letter = "w";
        ResPWD.text += letter.ToString();
    }

    public void XInput()
    {
        letter = "x";
        ResPWD.text += letter.ToString();
    }

    public void YInput()
    {
        letter = "y";
        ResPWD.text += letter.ToString();
    }

    public void ZInput()
    {
        letter = "z";
        ResPWD.text += letter.ToString();
    }

    // Caps Alpha Row Function
    public void AInputCaps()
    {

        letter = "A";
        ResPWD.text += letter.ToString();
    }

    public void BInputCaps()
    {
        letter = "B";
        ResPWD.text += letter.ToString();
    }

    public void CInputCaps()
    {
        letter = "C";
        ResPWD.text += letter.ToString();
    }

    public void DInputCaps()
    {
        letter = "D";
        ResPWD.text += letter.ToString();
    }

    public void EInputCaps()
    {
        letter = "E";
        ResPWD.text += letter.ToString();
    }

    public void FInputCaps()
    {
        letter = "F";
        ResPWD.text += letter.ToString();
    }

    public void GInputCaps()
    {
        letter = "G";
        ResPWD.text += letter.ToString();
    }

    public void HInputCaps()
    {
        letter = "H";
        ResPWD.text += letter.ToString();
    }

    public void IInputCaps()
    {
        letter = "I";
        ResPWD.text += letter.ToString();
    }

    public void JInputCaps()
    {
        letter = "J";
        ResPWD.text += letter.ToString();
    }

    public void KInputCaps()
    {
        letter = "K";
        ResPWD.text += letter.ToString();
    }

    public void LInputCaps()
    {
        letter = "L";
        ResPWD.text += letter.ToString();
    }

    public void MInputCaps()
    {
        letter = "M";
        ResPWD.text += letter.ToString();
    }

    public void NInputCaps()
    {
        letter = "N";
        ResPWD.text += letter.ToString();
    }

    public void OInputCaps()
    {
        letter = "O";
        ResPWD.text += letter.ToString();
    }

    public void PInputCaps()
    {
        letter = "P";
        ResPWD.text += letter.ToString();
    }

    public void QInputCaps()
    {
        letter = "Q";
        ResPWD.text += letter.ToString();
    }

    public void RInputCaps()
    {
        letter = "R";
        ResPWD.text += letter.ToString();
    }

    public void SInputCaps()
    {
        letter = "S";
        ResPWD.text += letter.ToString();
    }

    public void TInputCaps()
    {
        letter = "T";
        ResPWD.text += letter.ToString();
    }

    public void UInputCaps()
    {
        letter = "U";
        ResPWD.text += letter.ToString();
    }

    public void VInputCaps()
    {
        letter = "V";
        ResPWD.text += letter.ToString();
    }

    public void WInputCaps()
    {
        letter = "W";
        ResPWD.text += letter.ToString();
    }

    public void XInputCaps()
    {
        letter = "X";
        ResPWD.text += letter.ToString();
    }

    public void YInputCaps()
    {
        letter = "Y";
        ResPWD.text += letter.ToString();
    }

    public void ZInputCaps()
    {
        letter = "Z";
        ResPWD.text += letter.ToString();
    }

    public void BackInput()
    {
        ResPWD.text = ResPWD.text.Remove(ResPWD.text.Length - 1, 1);
        //ResPWD.GetComponentInChildren<TMP_InputField>().text = ResPWD.GetComponentInChildren<TMP_InputField>().text.Remove(ResPWD.GetComponentInChildren<TMP_InputField>().text.Length - 1, 1);
    }

    // Symbol Function

    public void at()
    {
        letter = "@";
        ResPWD.text += letter.ToString();
    }

    public void hash()
    {
        letter = "#";
        ResPWD.text += letter.ToString();
    }

    public void dollar()
    {
        letter = "$";
        ResPWD.text += letter.ToString();
    }

    public void underScore()
    {
        letter = "_";
        ResPWD.text += letter.ToString();
    }

    public void and()
    {
        letter = "&";
        ResPWD.text += letter.ToString();
    }

    public void minus()
    {
        letter = "-";
        ResPWD.text += letter.ToString();
    }

    public void plus() 
    {
        letter = "+";
        ResPWD.text += letter.ToString();
    }

    public void leftBracket()
    {
        letter = "(";
        ResPWD.text += letter.ToString();
    }

    public void rightBracket()
    {
        letter = ")";
        ResPWD.text += letter.ToString();
    }

    public void aterisk()
    {
        letter = ".";
        ResPWD.text += letter.ToString();
    }

    public void doubleQuote()
    {
        letter = "\"";
        ResPWD.text += letter.ToString();
    }

    public void singleQuote()
    {
        letter = "'";
        ResPWD.text += letter.ToString();
    }

    public void colon()
    {
        letter = ":";
        ResPWD.text += letter.ToString();
    }

    public void semiColon()
    {
        letter = ";";
        ResPWD.text += letter.ToString();
    }

    public void exaclaimationMark()
    {
        letter = "!";
        ResPWD.text += letter.ToString();
    }

    public void questionMark()
    {
        letter = "?";
        ResPWD.text += letter.ToString();
    }
}