using System;
using System.Collections.Generic;
using AutoMapper;
using System.Text;

namespace ConsoleAppMaping
{
    public static class  ResgistrerMapper
    {

        public static void Mapping() {

            Mapper.Initialize(cfg =>  //con este objeto de configuracion podemos registrar los mapeos
            {
               // cfg.CreateMap< Aqui adrentro va lo que deceo mapera>();


            });
        }
    }
}
