using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleResponsibilityPrinciple : MonoBehaviour
{
    private MailAdressValidator _validator = new MailAdressValidator();

    public bool SendMailForX(string input, string mailAdress)
    {
        if (!_validator.IsMailAdressValid(mailAdress))
        {
            return false;
        }
        return true;
    }
}

public class MailAdressValidator
{
    public bool IsMailAdressValid(string input)
    {
        //kural denetimi
        return true;
    }
}


