using Seguro.Aplication.Dto;

namespace Seguro.Aplication.Service
{
    public class AlumnoService : IClientService<ClientDto>
    {
        private readonly IRepository<AlumnoEntity> alumnoRepository;

        static MapperConfiguration configEscribir;

        static MapperConfiguration configLeer;

        static AlumnoService()
        {
            configEscribir = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>()
              .ForMember(dest => dest.Edad, sou => sou.ResolveUsing
              (entity => DateTime.Today.AddTicks(-entity.FechaNacimiento.Ticks).Year - 1)));

            configLeer = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>());
        }
        public AlumnoService() : this(new AlumnoRepository())
        {
        }
        public AlumnoService(
          ClientRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }


        public AlumnoDto Add(AlumnoDto model)
        {
            AlumnoEntity alumnoEntity = null;
            IMapper iMapper = configEscribir.CreateMapper();

            alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(model);

            try
            {
                alumnoRepository.Add(alumnoEntity);

            }
            catch (VuelingException ex)
            {
                //Log
                throw;
            }
            return model;
        }

        public List<ClientDto> GetAll()
        {
            List<AlumnoDto> listaAlumnoDtos;
            List<AlumnoEntity> listaAlumnoRepositoryLlegada;
            listaAlumnoRepositoryLlegada = alumnoRepository.GetAll();
            IMapper iMapper = configLeer.CreateMapper();

            listaAlumnoDtos = iMapper.Map<List<AlumnoDto>>(listaAlumnoRepositoryLlegada);
            return listaAlumnoDtos;
        }

        public AlumnoDto GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public AlumnoDto Update(AlumnoDto model)
        {
            throw new NotImplementedException();
        }
    }
}