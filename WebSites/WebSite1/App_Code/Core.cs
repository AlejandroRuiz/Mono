using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Core
/// </summary>
public class Core
{
    public static SqlConnection cn = new SqlConnection("Server=CAROLINA-PC;Database=Push;User Id=sa;Password=12345;");
    public Dispositivos ent = new Dispositivos();
    public Core()
	{
        ent.Id = 0;
        ent.CIdentificador = string.Empty;
        ent.IdPush = string.Empty;
	}
    public Core(int Id)
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Dispositivos WHERE Id="+Id, cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                ent.Id = r.GetInt32(0);
                ent.CIdentificador = r.GetString(1);
                ent.IdPush = r.GetString(2);
            }
            cn.Close();
        }
        catch (Exception x)
        {
            cn.Close();
        }
        finally
        {
            cn.Close();
        }
    }
    public bool Create()
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Dispositivos(CIdentificador, IdPush) VALUES('"+ ent.CIdentificador +"','"+ ent.IdPush +"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return true;
        }
        catch (Exception x)
        {
            cn.Close();
            return false;
        }
    }
    public bool Update()
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Dispositivos SET CIdentificador='" + ent.CIdentificador + "', IdPush='" + ent.IdPush + "' WHERE Id=" + ent.Id, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return true;
        }
        catch (Exception x)
        {
            cn.Close();
            return false;
        }
    }
    public bool Delete()
    {
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Dispositivos WHERE Id=" + ent.Id, cn);
            int res = cmd.ExecuteNonQuery();
            cn.Close();
            return true;
        }
        catch (Exception x)
        {
            cn.Close();
            return false;
        }
    }
    public static List<Dispositivos> AllEntities()
    {
        List<Dispositivos> LSalida = new List<Dispositivos>();
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Dispositivos", cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Dispositivos p = new Dispositivos();
                p.Id = r.GetInt32(0);
                p.CIdentificador = r.GetString(1);
                p.IdPush = r.GetString(2);
                LSalida.Add(p);
            }
            cn.Close();
            return LSalida;
        }
        catch (Exception x)
        {
            cn.Close();
            return LSalida;
        }

    }
}