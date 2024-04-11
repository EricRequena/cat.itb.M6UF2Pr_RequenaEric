using System;
using cat.itb.M6UF2Pr_RequenaEric.cruds;
using cat.itb.M6UF2Pr_RequenaEric.model;


namespace cat.itb.M6UF2Pr_RequenaEric
{
    public static class Program
    {
        public static void Main()
        {
            Exercici2();

            

            
        }



        public static void Exercici2()
        {


            ProductCRUD productCRUD = new ProductCRUD();
            Product product = productCRUD.SelectByid(100890);
            product.currentstock = 8;
            productCRUD.Update(product);
            product = productCRUD.SelectByid(200376);
            product.currentstock = 7;
            productCRUD.Update(product);
            product = productCRUD.SelectByid(200380);
            product.currentstock = 9;
            productCRUD.Update(product);
            product = productCRUD.SelectByid(100861);
            product.currentstock = 12;
            productCRUD.Update(product);

        }
    }
}