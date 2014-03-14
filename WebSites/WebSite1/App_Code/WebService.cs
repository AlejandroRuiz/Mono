using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService {
    public WebService () {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public bool Registrar(Dispositivos d)
    {
        Core c = new Core();
        c.ent = d;
        if (c.Create())
            return true;
        else
            return false;
    }
    [WebMethod]
    public bool Actualizar(Dispositivos d)
    {
        List<Dispositivos> list = Core.AllEntities();
        var filtro = list.FirstOrDefault(p => p.CIdentificador == d.CIdentificador);
        if(filtro!=null)
        {
            Core c = new Core();
            c.ent = filtro;
            c.ent.CIdentificador = d.CIdentificador;
            c.ent.IdPush = d.IdPush;
            if (c.Update())
                return true;
            else
                return false;
        }
        else
        {
            if(Registrar(d))
                return true;
            else
                return false;
        }
    }
    
}