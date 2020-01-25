using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Text equasion;
    public Text btnValue1;
    public Text btnValue2;
    public Text btnValue3;
    void Update()
    {
        equasion.text = Level.Instance.equasion;
        btnValue1.text = Level.Instance.btnValue1.ToString();
        btnValue2.text = Level.Instance.btnValue2.ToString();
        btnValue3.text = Level.Instance.btnValue3.ToString();
    }
}
