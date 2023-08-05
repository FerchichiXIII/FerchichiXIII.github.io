using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GitHub")
        {
            Application.OpenURL("https://github.com/FerchichiXIII");

        }
        if(other.tag == "Mail")
        {
            Application.OpenURL("mailto:anasferchichi22@gmail.com");
        }
        if (other.tag == "LinkDin")
        {
            Application.OpenURL("https://www.linkedin.com/in/anas-ferchichi-7b9aa8230/");
        }
    }
}
