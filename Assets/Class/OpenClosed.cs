using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClosed : MonoBehaviour
{
    ProductM product = new ProductM();
    SilverProduct silverProduct = new SilverProduct();
    [Range(0,300)]
    [SerializeField] double sales = 100;

    private void Start()
    {
        Debug.Log(product.getSale(sales));
        Debug.Log(silverProduct.getSale(sales));
    }

}

class ProductM
{
    public virtual double getSale(double TotalSales)
    {
        return TotalSales;
    }
}

[System.Serializable]
class SilverProduct
{
    public double getSale(double TotalSales)
    {
        return TotalSales - 50;
    }
}

class GoldProduct
{
    public double getSale(double TotalSales)
    {
        return TotalSales - 100;
    }
}
