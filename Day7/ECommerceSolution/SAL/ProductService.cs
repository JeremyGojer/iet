namespace SAL;
using BOL;
using BLL;

public class ProductService
{

    public List<Product> GetAll(){
        ProductManager mgr=ProductManager.GetManager();
        return mgr.GetAllProducts();
    }

}
