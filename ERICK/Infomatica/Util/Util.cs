
namespace Infomatica.Util
{
    using Infomatica.Restaurante.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class Util
    {
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            dr.Close();
            return list;
        }
        public string LeerIni(string Ruta, string Principal, string _Clave, string _Default)
        {
            string IniData = "";
            try
            {
                //primero que nada leo el archivo a ver si que datos tiene
                StreamReader streamReader = new StreamReader(Ruta);
                IniData = "";
                string[] VAL = streamReader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                streamReader.Close();

                bool EncontroPrincipal = false;
                bool FinalizaBusqueda = false;
                for (int i = 0; i < VAL.Count(); i++)
                {
                    if (!FinalizaBusqueda)
                    {
                        if (!EncontroPrincipal)
                        {
                            if (VAL[i].ToUpper().Contains("[" + Principal.ToUpper() + "]")) { EncontroPrincipal = true; }
                        }
                        else
                        {
                            if (VAL[i].Contains(_Clave))
                            {
                                IniData = VAL[i].Replace(_Clave, "").Replace("=", "").Trim();
                                break;
                            }
                            if (VAL[i].Contains("[")) { FinalizaBusqueda = true; }
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                if (IniData == "")
                {
                    IniData = _Default;
                }
                return IniData;
            }
            catch
            {
                return _Default;
            }
        }

    }
}
