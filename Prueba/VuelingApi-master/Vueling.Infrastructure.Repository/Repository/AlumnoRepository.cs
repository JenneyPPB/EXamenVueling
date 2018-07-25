using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using Vueling.Domain.Entities;
using Vueling.Infraestructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Properties;
using AutoMapper;
using Vueling.Infrastructure.Repository.DataModels;
using System.Linq;


namespace Vueling.Infrastructure.Repository.Repository
{
  
     public class AlumnoRepository : IRepository<AlumnoEntity>
    {
        private readonly CovalcoFlyWayEntities2 db;

        public AlumnoRepository() : this(new CovalcoFlyWayEntities2())
        {
        }
        public AlumnoRepository(
          CovalcoFlyWayEntities2 covalcoEntities)
        {
            this.db = covalcoEntities;
        }
        public AlumnoEntity Add(AlumnoEntity model)
        {
            Alumno alumno = null;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoEntity, Alumno>());
            IMapper iMapper = config.CreateMapper();
            alumno = iMapper.Map<AlumnoEntity, Alumno>(model);
            try
            {
                db.Alumnoes.Add(alumno);
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.DbUpdateConcurrencyException, ex);
            }
            catch (DbUpdateException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.DbUpdateException, ex);
            }
            
            catch (NotSupportedException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.NotSupportedException, ex);
            }
            catch (ObjectDisposedException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.ObjectDisposedException, ex);
            }
            catch (InvalidOperationException ex)
            {
                //You Must LOG
                throw new VuelingException(ResAlumno.InvalidOperationException, ex);
            }
            return model;
        }

        public List<AlumnoEntity> GetAll()
        {
            List<AlumnoEntity> alumnoEntity;
            IQueryable<Alumno> listaAlumno;

            try
            {
                listaAlumno = db.Alumnoes;
            }
            catch (Exception ex)

            {
                //You Must LOG
                throw ex;
            }

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Alumno, AlumnoEntity>());
            IMapper iMapper = config.CreateMapper();

            alumnoEntity = iMapper.Map<List<AlumnoEntity>>(listaAlumno);

            return alumnoEntity;
        }

        public AlumnoEntity GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public AlumnoEntity Update(AlumnoEntity model)
        {
            throw new NotImplementedException();
        }
    }


}
  
