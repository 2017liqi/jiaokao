﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using IDAL;
using Models;

namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUsers CreateUsers()
        {
            string className = AssemblyName + "." + db + "Users";
            return (IUsers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static INote CreateNote()
        {
            string className = AssemblyName + "." + db + "Note";
            return (INote)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGoods CreateGoods()
        {
            string className = AssemblyName + "." + db + "Goods";
            return (IGoods)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IShirt CreateShirt()
        {
            string className = AssemblyName + "." + db + "Shirt";
            return (IShirt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICoat CreateCoat()
        {
            string className = AssemblyName + "." + db + "Coat";
            return (ICoat)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ISuit CreateSuit()
        {
            string className = AssemblyName + "." + db + "Suit";
            return (ISuit)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static INetherGarment CreateNetherGarment()
        {
            string className = AssemblyName + "." + db + "NetherGarment";
            return (INetherGarment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}