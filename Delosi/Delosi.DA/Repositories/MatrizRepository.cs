using Delosi.DA.Data;
using Delosi.DA.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delosi.DA.Repositories
{
    public class MatrizRepository : IMatrizRepository
    {
        //Se comenta la inyeccion de dependencias debido a que no hay una conexión a la BD
        //private readonly ApplicationDbContext _context;

        //public MatrizRepository(ApplicationDbContext context) { 
        //    _context = context;
        //}

        //Aquí se implementarían los metodos de las interfaces
        public Task ExampleInterface()
        {
            throw new NotImplementedException();
        }
    }
}
