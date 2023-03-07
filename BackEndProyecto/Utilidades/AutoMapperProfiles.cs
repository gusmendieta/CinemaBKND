using AutoMapper;
using BackEndProyecto.DTOs;
using BackEndProyecto.Entidades;
using Microsoft.AspNetCore.Identity;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProyecto.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles(GeometryFactory geometryFactory)
        {
            #region GENERO 
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();
            #endregion




            #region Usuario
            CreateMap<IdentityUser, UsuarioDTO>();

            #endregion

        }
    }
}
