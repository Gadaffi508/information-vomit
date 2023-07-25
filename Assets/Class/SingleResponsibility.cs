using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleResponsibility : MonoBehaviour
{

}

class FileLog
{
    public void Handle(string data)
    {
        //Handle file extension
    }
}

class Product
{
    private FileLog log = new FileLog();

    public void Add()
    {
        try
        {
            //file extension
        }
        catch (System.Exception exc)
        {

            log.Handle(exc.ToString());
        }
    }
}
