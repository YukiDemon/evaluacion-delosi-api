using Delosi.BL.IServices;
using Delosi.DA.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delosi.BL.Services
{
    public class MatrizServices : IMatrizServices
    {
        private readonly IMatrizRepository _matrizRepository;

        public MatrizServices(IMatrizRepository matrizRepository)
        {
            _matrizRepository = matrizRepository;
        }

        //Aquí se listan los métodos
        public int[][] RotarMatriz(int[][] request)
        {
            int elemento = request.Length;
            int[][] matrizAntihorario = new int[elemento][];

            for (int i = 0; i < elemento; i++)
            {
                matrizAntihorario[i] = new int[elemento];
                for (int j = 0; j < elemento; j++)
                {
                    matrizAntihorario[i][j] = request[j][elemento - i - 1];
                }
            }

            return matrizAntihorario;
        }
    }
}
