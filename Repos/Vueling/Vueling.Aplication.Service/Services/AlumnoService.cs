using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vueling.Aplication.Dto;
using Vueling.Domain.Entities;
using Vueling.Infraestruccure.Repository.Contract;
using Vueling.Infraestructure.Repository.Repository;
using AutoMapper;
using Veling.Common.Layer;

namespace Vueling.Aplication.Service.Services
{
    public class AlumnoService : IService<AlumnoDto>
    {
        //Log4Net log = new Log4Net();

        private readonly IRepository<AlumnoEntity> alumnoRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="AlumnoService"/> class.
        /// </summary>
        public AlumnoService():this(new AlumnoRepository())
        {
            //log.TestLog();
            
        }
        public AlumnoService(AlumnoRepository alumnoRepository)
        {
            {
                this.alumnoRepository = alumnoRepository;
            }



        }

        public AlumnoDto Add(AlumnoDto alumnoDto )
        {
            AlumnoEntity alumnoEntity = new AlumnoEntity();

            var config = new MapperConfiguration(cfg=>cfg.CreateMap<AlumnoDto, AlumnoEntity>()

                .ForMember(dest => dest.Edad, sou => sou.ResolveUsing(entity => DateTime.Today.AddTicks(
                    -entity.FechaNacimiento.Ticks).Year - 1)));

            IMapper iMapper = config.CreateMapper();

            alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(alumnoDto);
            
            try
            {
             //   alumnoRepository.Add(alumnoEntity);
            }
            catch (VuelingException ex)
            {
                
                throw;
            }
            return alumnoDto;
           
         }

        public List<AlumnoDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AlumnoDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoDto Update(AlumnoDto model)
        {
            throw new NotImplementedException();
        }
    }
}
